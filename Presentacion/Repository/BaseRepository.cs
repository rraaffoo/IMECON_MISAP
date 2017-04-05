using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using MISAP.Entity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace MISAP.Repository
{
    internal abstract partial class BaseRepository
      : IRepository
    {
    }

    internal abstract partial class BaseRepository<TEntity>
       : BaseRepository, IDisposable
                where TEntity : BaseEntity, new()
    {
        protected String nombreParametroRetorno = String.Empty;

        #region Configuración de parámetros

        protected virtual void ConfigurarParametros(DbCommand comando, TEntity item) { this.ConfigurarParametros<TEntity>(comando, item); }

        protected virtual void ConfigurarParametros<TEntity2>(DbCommand comando, TEntity2 item) where TEntity2 : BaseEntity, new() { }

        protected virtual void ConfigurarParametrosBase(DbCommand comando, TEntity item) { }

        protected virtual void ConfigurarParametrosBase(DbCommand comando, DateTime fechaRegistro, bool estado) { }

        protected virtual void ConfigurarParametrosSalida(DbCommand comando) { this.ConfigurarParametrosRetorno(comando); }

        protected virtual void ConfigurarParametrosRetorno(DbCommand comando) { }

        protected virtual void ConfigurarParametrosBuscar(DbCommand comando, TEntity item) { }

        #endregion

        #region Registrar

        internal virtual int Registrar(TEntity item, out int filasAfectadas) { throw new NotImplementedException("No se ha implementado"); }

        protected int Registrar(String procedimientoAlmacenado, TEntity item, out int filasAfectadas)
        {
            try
            {

                Database db = null;
                DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
                this.ConfigurarParametros(comando, item);
                return this.Registrar(db, comando, out filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected int Registrar(string procedimientoAlmacenado, Action<DbCommand> accion, out int filasAfectadas)
        {
            Database db = null;
            DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
            if (accion != null) accion(comando);
            return this.Registrar(db, comando, out filasAfectadas);
        }

        protected int Registrar<TEntity2>(string procedimientoAlmacenado, TEntity2 item, out int filasAfectadas) where TEntity2 : BaseEntity, new()
        {
            try
            {
                Database db = null;
                DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
                this.ConfigurarParametros<TEntity2>(comando, item);
                this.ConfigurarParametrosBase(comando, DateTime.Now, true);
                return this.Registrar(db, comando, out filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="db"></param>
        /// <param name="comando"></param>
        /// <param name="filasAfectadas"></param>
        /// <returns></returns>
        private int Registrar(Database db, DbCommand comando, out int filasAfectadas)
        {
            try
            {
                if (comando.Parameters.Contains("@pid"))
                    if (comando.Parameters["@pid"].Direction == ParameterDirection.InputOutput)
                        comando.Parameters["@pid"].Direction = ParameterDirection.Output;
                return this.RegModEli(db, comando, out  filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Modificar

        internal virtual int Modificar(TEntity item, out int filasAfectadas) { throw new NotImplementedException("No se ha implementado"); }

        //protected int Modificar(TablasEnum tbl, TEntity item, out int af)
        //{
        //    return this.Modificar(tbl.GetDescription() + "_RegMod", item, out af);
        //}

        //protected int Modificar(string procedimientoAlmacenado, TEntity item, out int filasAfectadas)
        //{
        //    try
        //    {
        //        Database db = null;
        //        DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
        //        this.ConfigurarParametros(comando, item);
        //        return this.Modificar(db, comando, out filasAfectadas);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        protected int Modificar(string procedimientoAlmacenado, Action<DbCommand> accion, out int filasAfectadas)
        {
            Database db = null;
            DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
            if (accion != null) accion(comando);
            return this.Modificar(db, comando, out filasAfectadas);
        }

        protected int Modificar<TEntity2>(string procedimientoAlmacenado, TEntity2 item, out int filasAfectadas) where TEntity2 : BaseEntity, new()
        {
            try
            {
                Database db = null;
                DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
                this.ConfigurarParametros<TEntity2>(comando, item);
                return this.Registrar(db, comando, out filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int Modificar(Database db, DbCommand comando, out int filasAfectadas)
        {
            try
            {
                return this.RegModEli(db, comando, out  filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion Modificar

        #region Eliminar

        internal virtual string Eliminar(string id, out int filasAfectadas) { throw new NotImplementedException("No se ha implementado"); }

        internal virtual int Eliminar(int id, out int filasAfectadas) { throw new NotImplementedException("No se ha implementado"); }

        protected int Eliminar(string procedimientoAlmacenado, int id, out int filasAfectadas)
        {
            Database db = null;
            DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
            nombreParametroRetorno = (!String.IsNullOrEmpty(nombreParametroRetorno)) ? nombreParametroRetorno : "@pid";
            comando.Parameters[nombreParametroRetorno].Value = id;
            this.Eliminar(db, comando, out filasAfectadas);
            return id;
        }

        protected int Eliminar(string procedimientoAlmacenado, Action<DbCommand> accion, out int filasAfectadas)
        {
            Database db = null;
            DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
            if (accion != null) accion(comando);
            return this.Eliminar(db, comando, out filasAfectadas);
        }

        private int Eliminar(Database db, DbCommand comando, out int filasAfectadas)
        {
            try
            {
                return this.RegModEli(db, comando, out filasAfectadas);
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message.Contains("constraint") == true ? "No se puede eliminar porque el registro está referenciado" : ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region RegMod

        private int GetValorParametro(DbParameterCollection parametros, string nombreParametro)
        {
            int valor = 0;
            bool existe = parametros.Contains(nombreParametro);
            if (existe)
                if (parametros[nombreParametro].Value == DBNull.Value || parametros[nombreParametro].Value == null) valor = 0;
                else valor = Convert.ToInt32(parametros[nombreParametro].Value);
            return valor;
        }

        internal virtual int RegMod(TEntity item, out int filasAfectadas)
        {
            throw new NotImplementedException("No está implementado");
        }

        protected int RegMod(string procedimientoAlmacenado, TEntity item, out int filasAfectadas)
        {
            try
            {
                Database db = null;
                DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
                this.ConfigurarParametros(comando, item);
                return this.RegModEli(db, comando, out filasAfectadas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected int RegMod(string procedimientoAlmacenado, Action<DbCommand> accion, out int filasAfectadas)
        {
            Database db = null;
            DbCommand comando = this.GetComando(procedimientoAlmacenado, out db);
            if (accion != null) accion(comando);
            return this.RegModEli(db, comando, out filasAfectadas);
        }

        private int RegModEli(Database db, DbCommand comando, out int filasAfectadas)
        {
            try
            {
                //comando.AddReturnParameter("@pfilaafectadas", DbType.Int32, -1);
                comando.Parameters["@pfilaafectadas"].Direction = ParameterDirection.Output;
                // if (ItemUsuario == null) throw new Exception("No existe un usuario");
                //DbCommand comando2 = this.GetComando("sis.contextinfo_crear");
                // comando2.Parameters["@pid"].Value = ItemUsuario.Id;
                //db.ExecuteNonQuery(comando2);
                foreach (DbParameter parametro in comando.Parameters) comando.Parameters[parametro.ParameterName].Value = comando.Parameters[parametro.ParameterName].Value ?? DBNull.Value;
                db.ExecuteNonQuery(comando);
                filasAfectadas = (int)comando.Parameters["@pfilaafectadas"].Value;
                nombreParametroRetorno = (!String.IsNullOrEmpty(nombreParametroRetorno)) ? nombreParametroRetorno : "@pid";
                return this.GetValorParametro(comando.Parameters, nombreParametroRetorno);
            }
            catch (DbException ex)
            {
                if (ex.ErrorCode == 515)
                {
                    string patron = "Cannot insert the value NULL into column '(.*)', table";
                    Match match = Regex.Match(ex.Message, patron, RegexOptions.IgnoreCase);
                    if (match.Success == false) throw new Exception("No puede insertar valores nulos");
                    else { throw new Exception(String.Format("No puede insertar valores nulos en {0}", match.Groups[1].Value)); }
                }
                if (ex.ErrorCode == 547)
                {
                    if (ex.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint"))
                        throw new Exception("No es posible insertar, hay conflictos de clave foránea");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the FOREIGN KEY constraint"))
                        throw new Exception("No es posible actualizar, hay conflictos en clave foránea");
                    throw new Exception("No se puede eliminar porque el registro está referenciado");
                }
                if (ex.ErrorCode == 2627)
                    throw new Exception("El registro ya existe, agregue uno nuevo");
                if (ex.ErrorCode == 208)
                    throw new Exception("No existe el objeto donde se va procesar los datos");
                // if (ex.ErrorCode == -2146232060)
                //       throw new Exception("No se pudo eliminar porque existe un registro asociado.");

                //if (ex.Number == 2812)
                //    throw new Exception("Procedimiento almacenado no encontrado");
                throw new Exception(ex.Message);
            }
            finally
            {
                //if (comando.Connection.State == ConnectionState.Open)
                //    comando.Connection.Close();
            }
        }

        #endregion

        private void Populate<TPopulate>(DbCommand comando, Action<IDataReader, MethodInfo, TPopulate> accion)
            where TPopulate : BasePopulate, new()
        {
            try
            {
                MethodInfo metodo = typeof(TPopulate).GetMethod("GetItem", new Type[] { typeof(IDataRecord) });
                PropertyInfo propiedad = typeof(TPopulate).GetProperty("Instance", BindingFlags.Static | BindingFlags.NonPublic);
                TPopulate populate = (TPopulate)propiedad.GetValue(null, null);
                this.SetPopulate(comando, delegate()
                {
                    foreach (DbParameter pm in comando.Parameters)
                        comando.Parameters[pm.ParameterName].Value = comando.Parameters[pm.ParameterName].Value ?? DBNull.Value;

                    using (IDataReader dr = comando.ExecuteReader())
                        accion(dr, metodo, populate);
                });
            }
            finally
            {
                this.Dispose();
            }
        }

        protected void SetPopulate(DbCommand comando, Action accion)
        {
            DbConnection connection = null;
            try
            {
                Database db = DatabaseHelper.GetDatabase();
                using (connection = db.CreateConnection())
                {
                    connection.Open();
                    DbTransaction transaction;
                    if (!(db is SqlDatabase))
                        transaction = connection.BeginTransaction();
                    comando.Connection = connection;
                    using (comando)
                    {
                        if (accion != null)
                            accion();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Listar

        //internal virtual List<TEntity> Listar()
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual List<TEntity> Listar(string procedimientoAlmacenado)
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    return this.Listar(comando);
        //}

        //protected virtual List<TEntity> Listar(string procedimientoAlmacenado, dynamic id, string nombreParametro = "@pid")
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    comando.Parameters[nombreParametro].Value = id;
        //    return this.Listar(comando);
        //}

        //protected virtual List<TEntity> Listar(string procedimientoAlmacenado, Action<DbCommand> accion)
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    if (accion != null) accion(comando);
        //    return this.Listar(comando);
        //}

        //private List<TEntity> Listar(DbCommand comando)
        //{
        //    List<TEntity> items = new List<TEntity>();
        //    try
        //    {
        //        this.SetPopulate(comando, delegate()
        //        {
        //            using (IDataReader dr = comando.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    TEntity item = BasePopulate.Instance.GetItem<TEntity>(dr);
        //                    items.Add(item);
        //                }
        //            }
        //        });
        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        #endregion

        #region Detalle
        protected TEntity2 Detalle<TPopulate, TEntity2>(DbCommand comando)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            TEntity2 item = new TEntity2();
            this.Populate<TPopulate>(comando, delegate(IDataReader dr, MethodInfo metodo, TPopulate populate)
            {
                if (dr.Read()) item = (TEntity2)metodo.Invoke(populate, new Object[] { dr });
            });
            return item;
        }

        protected TEntity Detalle<TPopulate>(DbCommand comando)
            where TPopulate : BasePopulate, new()
        {
            return this.Detalle<TPopulate, TEntity>(comando);
        }

        protected virtual TEntity Detalle<TPopulate>(string procedimientoAlmacenado, int id, string nombreParametro = "@pid")
            where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = id;
            return this.Detalle<TPopulate>(comando);
        }

        protected virtual TEntity Detalle<TPopulate>(string procedimientoAlmacenado, string codigo, string nombreParametro = "@pcodigo")
           where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = codigo;
            return this.Detalle<TPopulate>(comando);
        }

        protected virtual TEntity Detalle<TPopulate>(string procedimientoAlmacenado, Action<DbCommand> accion)
           where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null) accion(comando);
            return this.Detalle<TPopulate>(comando);
        }

        protected virtual TEntity2 Detalle<TPopulate, TEntity2>(string procedimientoAlmacenado, int id, string nombreParametro = "@pid")
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = id;
            return this.Detalle<TPopulate, TEntity2>(comando);
        }

        protected virtual TEntity2 Detalle<TPopulate, TEntity2>(string procedimientoAlmacenado, string codigo, string nombreParametro = "@pid")
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = codigo;
            return this.Detalle<TPopulate, TEntity2>(comando);
        }

        protected virtual TEntity2 Detalle<TPopulate, TEntity2>(string procedimientoAlmacenado, Action<DbCommand> accion)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null) accion(comando);
            return this.Detalle<TPopulate, TEntity2>(comando);
        }

        internal virtual TEntity Detalle(int id)
        {
            throw new NotImplementedException("No implementado");
        }

        internal virtual TEntity Detalle(String id)
        {
            throw new NotImplementedException("No implementado");
        }
        #endregion

        #region Buscar
        protected List<TEntity2> Buscar<TPopulate, TEntity2>(DbCommand comando)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            List<TEntity2> items = new List<TEntity2>();
            this.Populate<TPopulate>(comando, delegate(IDataReader dr, MethodInfo metodo, TPopulate populate)
            {
                while (dr.Read())
                {
                    TEntity2 item = (TEntity2)metodo.Invoke(populate, new Object[] { dr });
                    items.Add(item);
                }
                this.GetPaginar(comando, dr);
            });
            return items;
        }

        protected void Buscar(string procedimientoAlmacenado, Action<DbCommand> accion, out DbCommand comando)
        {
            comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null) accion(comando);
        }

        #region IDataReader

        protected List<TEntity> Buscar<TPopulate>(DbCommand comando)
           where TPopulate : BasePopulate, new()
        {
            return this.Buscar<TPopulate, TEntity>(comando);
        }

        protected virtual List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado)
            where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            return Buscar<TPopulate>(comando);
        }

        protected virtual List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado, TEntity item, PaginadorEntity paginador)
            where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            this.ConfigurarParametrosBuscar(comando, item);
            return Buscar<TPopulate>(comando, paginador);
        }

        protected virtual List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado, string nombre, PaginadorEntity paginador, string nombreParametro = "@pnombre") where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = nombre;
            return this.Buscar<TPopulate>(comando, paginador);
        }

        //protected virtual List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado, dynamic valor, string nombreParametro)
        //    where TPopulate : BasePopulate, new()
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    comando.Parameters[nombreParametro].Value = valor;
        //    return Buscar<TPopulate, TEntity>(comando);
        //}

        protected virtual List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado, Action<DbCommand> accion)
            where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null) accion(comando);
            return Buscar<TPopulate>(comando);
        }

        protected List<TEntity> Buscar<TPopulate>(string procedimientoAlmacenado, Action<DbCommand> accion, PaginadorEntity paginador)
  where TPopulate : BasePopulate, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null) accion(comando);
            return Buscar<TPopulate>(comando, paginador);
        }

        protected List<TEntity> Buscar<TPopulate>(DbCommand comando, PaginadorEntity paginador)
  where TPopulate : BasePopulate, new()
        {
            this.SetPaginar(comando, paginador);
            List<TEntity> items = this.Buscar<TPopulate>(comando);
            this.GetPaginar(comando, paginador);
            return items;
        }

        protected virtual List<TEntity2> Buscar<TPopulate, TEntity2>(string procedimientoAlmacenado)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            return Buscar<TPopulate, TEntity2>(comando);
        }

        protected virtual List<TEntity2> Buscar<TPopulate, TEntity2>(string procedimientoAlmacenado, Action<DbCommand> accion)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            if (accion != null)
                accion(comando);
            return Buscar<TPopulate, TEntity2>(comando);
        }

        protected virtual List<TEntity2> Buscar<TPopulate, TEntity2>(string procedimientoAlmacenado, int id, string nombreParametro = "@pid")
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = id;
            return Buscar<TPopulate, TEntity2>(comando);
        }

        protected virtual List<TEntity2> Buscar<TPopulate, TEntity2>(string procedimientoAlmacenado, string valor, string nombreParametro)
            where TPopulate : BasePopulate, new()
            where TEntity2 : BaseEntity, new()
        {
            DbCommand comando = this.GetComando(procedimientoAlmacenado);
            comando.Parameters[nombreParametro].Value = valor;
            return Buscar<TPopulate, TEntity2>(comando);
        }

        internal virtual List<TEntity> Buscar(string valor, PaginadorEntity paginador)
        {
            throw new NotImplementedException("No está implementado");
        }

        internal virtual List<TEntity> Buscar(int valor, PaginadorEntity paginador)
        {
            throw new NotImplementedException("No está implementado");
        }

        internal virtual List<TEntity> Buscar(TEntity item, PaginadorEntity paginador)
        {
            throw new NotImplementedException("No está implementado");
        }

        internal virtual List<TEntity> BuscarPorNombre(string nombre)
        {
            throw new NotImplementedException("No está implementado");
        }

        #endregion

        #region DataTable

        //protected DataTable Reporte(string procedimientoAlmacenado)
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    return this.Reporte(comando);
        //}

        //protected DataTable Reporte(string procedimientoAlmacenado, int id, string nombreParametro = "@pid")
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    comando.Parameters[nombreParametro].Value = id;
        //    return this.Reporte(comando);
        //}

        //protected DataTable Reporte(string procedimientoAlmacenado, TEntity item)
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    this.ConfigurarParametrosBuscar(comando, item);
        //    return this.Reporte(comando);
        //}

        //protected DataTable Reporte(string procedimientoAlmacenado, Action<DbCommand> accion)
        //{
        //    DbCommand comando = this.GetComando(procedimientoAlmacenado);
        //    if (accion != null) accion(comando);
        //    return this.Reporte(comando);
        //}

        //private DataTable Reporte(DbCommand comando)
        //{
        //    DataTable dt = new DataTable();
        //    this.SetPopulate(comando, delegate()
        //    {
        //        foreach (DbParameter parametro in comando.Parameters) comando.Parameters[parametro.ParameterName].Value = comando.Parameters[parametro.ParameterName].Value ?? DBNull.Value;
        //        using (IDataReader dr = comando.ExecuteReader())
        //        {
        //            dt.Load(dr);
        //        }
        //    });
        //    return dt;
        //}

        #endregion

        #endregion

        #region Command
        internal DbCommand GetComando(string procedimientoAlmacenado)
        {
            Database db = DatabaseHelper.GetDatabase();
            DbCommand comando = null;
            using (DbConnection conn = db.CreateConnection())
            {
                comando = db.GetStoredProcCommand(procedimientoAlmacenado);
                db.DiscoverParameters(comando);
            }
            return comando;
        }

        private DbCommand GetComando(string procedimientoAlmacenado, out Database db)
        {
            db = DatabaseHelper.GetDatabase();
            DbCommand comando = null;
            comando = db.GetStoredProcCommand(procedimientoAlmacenado);
            db.DiscoverParameters(comando);
            return comando;
        }

        #endregion

        #region Paginar

        protected void SetPaginar(DbCommand comando, PaginadorEntity item)
        {
            if (item == null) return;
            comando.Parameters["@pcolumnaordenada"].Value = item.ColumnaOrdenada;
            comando.Parameters["@ptipoorden"].Value = item.TipoOrden;
            comando.Parameters["@pregistroporpagina"].Value = item.RegistroPagina;
            comando.Parameters["@ppaginaactual"].Value = item.PaginaActual;
        }

        private void GetPaginar(DbCommand comando, PaginadorEntity item)
        {
            if (item == null) return;
            item.TotalRegistro = (int)comando.Parameters["@ptotalregistro"].Value;
            item.TotalPagina = (int)comando.Parameters["@ptotalpagina"].Value;
        }

        private void GetPaginar(DbCommand comando, IDataReader dr)
        {
            if (!dr.NextResult() || !dr.Read()) return;
            //comando.AddOutParameter("@ptotalpagina", DbType.Int32, -1);
            //comando.AddOutParameter("@ptotalregistro", DbType.Int32, -1);
            comando.Parameters["@ptotalregistro"].Value = dr["ptotalregistro"];
            comando.Parameters["@ptotalpagina"].Value = dr["ptotalpagina"];
        }
        #endregion

        public void Dispose()
        {
        }
    }
}
