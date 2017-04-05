using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbobsCOM;
using System.Reflection;
using System.IO;

namespace MISAP.Entity
{
    /// <summary>
    /// Representa el estado del enlace de conexion hacia SAP.
    /// </summary>
    public class LinkStatus
    {
        /// <summary>
        /// Codigo de estado de conexion
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Mensaje de estado de conexion.
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// Cargador de scripts SQL para una base de datos especifica dependiendo de la configuración.
    /// </summary>
    public class VSSQLFactory
       : IDisposable
    {
        public Company oCompany;

    //    /// <summary>
    //    /// Inicializa una nueva instancia de la clase <see cref="VSSQLFactory"/>.
    //    /// </summary>
    //    public VSSQLFactory()
    //    {
    //    }

    //    /// <summary>
    //    /// Pre-requisito para comprobar y establecer conexion con SAP.
    //    /// NOTA: es posible que deba agregarse parametros de usuario y clave de sap (no de db)
    //    /// </summary>
    //    /// <returns>Estado del enlace a SAP.</returns>
        public LinkStatus Link()
        {
            int ec = 0;
            string ed = "OK";

            if (oCompany == null || !oCompany.Connected)
            {
                var sap = new DataBaseSAPHelper();
                System.Diagnostics.Debug.WriteLine("Conexion interna con credenciales estaticas desde archivo de configuracion");
                oCompany = sap.ConnectarSAP(null, null, out ec, out ed, true);
            }

            return new LinkStatus
            {
                Code = ec,
                Message = ed
            };
        }

    //    /// <summary>
    //    /// Devuelve el script indicado por <paramref name="indice"/>.
    //    /// </summary>
    //    /// <param name="indice">Numero del script SQL.</param>
    //    /// <param name="datos">Matriz con los datos para la secuencia SQL.</param>
    //    /// <returns>Script para la base de datos indicada en la configuracion.</returns>
        private string GetScript(string indice, string[] datos)
        {
            string archivo = (indice).ToString().PadLeft(5, '0'); //((int)indice).ToString().PadLeft(5, '0');
            string tipo = "";

            switch (oCompany.DbServerType)
            {
                case BoDataServerTypes.dst_MSSQL:
                case BoDataServerTypes.dst_MSSQL2005:
                case BoDataServerTypes.dst_MSSQL2008:
                case BoDataServerTypes.dst_MSSQL2012:
                case BoDataServerTypes.dst_MSSQL2014:
                    tipo = "MSSQL";
                    break;
                case BoDataServerTypes.dst_HANADB:
                    tipo = "HANA";
                    break;
                default:
                    tipo = "";
                    break;
            }

            archivo += ("_" + tipo + ".sql");

            Assembly thisTxt = Assembly.GetExecutingAssembly();
            string nombre = thisTxt.GetName().Name + ".Scripts." + archivo;
            Stream file = thisTxt.GetManifestResourceStream(nombre);
            StreamReader reader = null;
            string script = "";
            try
            {
                reader = new StreamReader(file);
                while (!reader.EndOfStream)
                {
                    script += reader.ReadLine() + " ";
                }

                if (datos != null && datos.Length > 0)
                {
                    for (int i = 0; i < datos.Length; i++)
                    {
                        script = script.Replace("${param" + (i + 1) + "}", datos[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                //script = "Error: " + ex.Message;
                throw; // new SapException("Script " + tipo + " tiene errores en los paramétros.", ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (file != null)
                    file.Dispose();
            }

            return script;
        }

    //    /// <summary>
    //    /// Devuelve un bloque dde datos.
    //    /// </summary>
    //    /// <param name="indice">Indice de la consulta.</param>
    //    /// <param name="datos">Parametros para la consulta.</param>
    //    /// <returns>Lista de matriz unidimensional de datos.</returns>
        public List<object[]> GetBlock(string indice , string[] datos) //Consulta indice
        {
            Recordset rs = null;
            List<object[]> list = new List<object[]>();

            try
            {
                string query = GetScript(indice, datos);
                rs = (Recordset)oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);
                rs.DoQuery(query);

                int filas = rs.RecordCount;
                rs.MoveFirst();
                while (!rs.EoF)
                {
                    List<object> d = new List<object>();

                    for (int i = 0; i < rs.Fields.Count; i++)
                    {
                        d.Add(rs.Fields.Item(i).Value);
                    }
                    list.Add(d.ToArray());
                    rs.MoveNext();
                }
            }
            catch (Exception ex)
            {
                throw; // new SapException("Error en llamada a SAP.", ex);
            }
            finally
            {
                //if (rs != null)
                //   System.Runtime.InteropServices.Marshal.ReleaseComObject(rs);
                //rs = null;
                //GC.Collect();
            }

            return list;
        }

    //    /// <summary>
    //    /// Devuelve un valor único de la consulta.
    //    /// </summary>
    //    /// <typeparam name="T">Tipo de dato a devolver.</typeparam>
    //    /// <param name="indice">Indice de la consulta.</param>
    //    /// <param name="datos">Matriz con los datos para la secuencia SQL.</param>
    //    /// <returns>valor único de la consulta.</returns>
        public T GetValue<T>(string indice, string[] datos)
        {
            Recordset rs = null;
            T scalar = default(T);
            try
            {
                string query = GetScript(indice, datos);
                rs = (Recordset)oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);
                rs.DoQuery(query);

                int filas = rs.RecordCount;
                //if (!rs.EoF)
                    //scalar = Convert.ChangeType(rs.Fields.Item(0).Value, typeof(T));
            }
            catch (Exception ex)
            {
                throw; // new SapException("Error en llamada a SAP. ", ex);
            }
            finally
            {
                if (rs != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(rs);
                rs = null;
                GC.Collect();
            }

            return scalar;
        }

        public void Dispose()
        {
            if (oCompany != null/* && _instance.Connected*/)
                oCompany.Disconnect();
        }
    }
}
