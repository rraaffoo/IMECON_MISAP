using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using MISAP.Entity;
using System.Diagnostics;
using MISAP.Repository;
using System.Transactions;

namespace MISAP.Service
{
    public abstract partial class BaseService
      : IBaseService, IDisposable//, IValidatableObject
    {
        internal static readonly string PasswordHash = "P@@Sw0rd";
        internal static readonly string SaltKey = "S@LT&KEY";
        internal static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        protected static string PathBase
        {
            get
            {
                string pathBase = AppDomain.CurrentDomain.BaseDirectory;
                if (pathBase.EndsWith("\bin", StringComparison.InvariantCultureIgnoreCase) || pathBase.Contains(@"\bin\"))
                    return (Directory.GetParent(pathBase.TrimEnd(new Char[] { '\\' }))).FullName + @"\";
                return pathBase;
            }
        }

        static BaseService()
        {
        }

        public void Dispose() { }

        //public IEnumerable<ValidationResult> Validate(ValidationContext context)
        //{
        //    return null;
        //}

        protected void LlamarTareas(string Arguments)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = PathBase + @"bin\Tareas.exe";
            myProcess.StartInfo.Arguments = Arguments;
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.Start();
        }
    }

    public abstract partial class BaseService<TEntity>
       : BaseService
        where TEntity : BaseEntity, new()
    {
        public BaseService()
            : base()
        {
        }

        public UsuarioEntity itemUsuario;
        public EmpresaEntity itemEmpresa;
        public String nomArchivoDebug = "Debug";

        protected void Transaccion(Action accion)
        {
            using (TransactionScope transaccion = new TransactionScope(TransactionScopeOption.Required))
            {
                if (accion != null)
                    accion();

                transaccion.Complete();
            }
        }

        public virtual RespuestaEntity Guardar(TEntity item)
        {
            throw new NotImplementedException("No está implementado");
        }

        public virtual RespuestaEntity Guardar(List<TEntity> items)
        {
            throw new NotImplementedException("No está implementado");
        }

        internal RespuestaEntity Guardar(BaseRepository<TEntity> repositorio, TEntity item, out int filasAfectadas)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            filasAfectadas = 0;

            try
            {
                int id = 0;
                string mensaje = string.Empty;
                respuesta.success = true; respuesta.extra = id.ToString(); respuesta.message = mensaje;
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.SetMessage(ex);
                return respuesta;
            }
        }

        internal RespuestaEntity Guardar(BaseRepository<TEntity> repositorio, TEntity item)
        {
            RespuestaEntity respuesta = new RespuestaEntity();
            try
            {
                int id = 0;
                string mensaje = string.Empty;
                respuesta.success = true; respuesta.extra = id.ToString(); respuesta.message = mensaje;
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.SetMessage(ex);
                return respuesta;
            }
        }

        internal int Guardar(BaseRepository<TEntity> repositorio, TEntity item, out string mensaje, out int filasAfectadas)
        {
            try
            {
                mensaje = String.Empty;
                int id = 0;
                filasAfectadas = 0;
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal RespuestaEntity Guardar<TRepository>(TEntity item) where TRepository : BaseRepository<TEntity>, new()
        {
            TRepository repositorio = new TRepository();
            return this.Guardar(repositorio, item);
        }

        public virtual RespuestaEntity<TEntity> Detalle(int id)
        {
            throw new NotImplementedException("No está implementado");
        }

        public virtual RespuestaEntity<TEntity> Detalle(string id)
        {
            throw new NotImplementedException("No está implementado");
        }

        public virtual RespuestaEntity<TEntity> Buscar(string valor, PaginadorEntity paginador)
        {
            throw new NotImplementedException("No implementado");
        }

        public virtual RespuestaEntity<TEntity> Buscar(TEntity item, PaginadorEntity paginador)
        {
            throw new NotImplementedException("No implementado");
        }

        public virtual RespuestaEntity<TEntity> Buscar(TEntity item)
        {
            throw new NotImplementedException("No implementado");
        }

        //internal virtual List<TEntity> Buscar(BaseRepository<TEntity> repositorio, String valor, PaginadorEntity paginador)
        //{
        //    try
        //    {
        //        return repositorio.Buscar(valor, paginador);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //internal virtual List<TEntity> Buscar(BaseRepository<TEntity> repositorio, int valor, PaginadorEntity paginador)
        //{
        //    try
        //    {
        //        return repositorio.Buscar(valor, paginador);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //internal virtual List<TEntity> Buscar(BaseRepository<TEntity> repositorio, TEntity item, PaginadorEntity paginador)
        //{
        //    try
        //    {
        //        return repositorio.Buscar(item, paginador);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        internal static String[] CargarParametrosLicencia(StreamReader Archivo)
        {
            String line, lineas = String.Empty;
            while ((line = Archivo.ReadLine()) != null)
                lineas += Decrypt(line) + "|";
            Archivo.Close();
            String[] parametros = lineas.Split('|');
            if (parametros.Length != 4)
                parametros = new String[] { "", "", "0", "" };

            return parametros;
        }

        internal static String Decrypt(string encryptedText)
        {
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();

                String retval = Encoding.UTF8
                   .GetString(plainTextBytes, 0, decryptedByteCount)
                   .TrimEnd("\0".ToCharArray());

                return retval;
            }
            catch
            {
                return String.Empty;
            }
        }

        protected static string PathLog
        {
            get { return GetDirectorio(PathBase + @"logs\"); }
        }

        protected static string GetDirectorio(string directorio)
        {
            if ((directorio.Length > 0) && (!Directory.Exists(directorio)))
                Directory.CreateDirectory(directorio);

            return directorio;
        }

        public virtual void Debug(String metodo, TEntity item)
        {
            throw new NotImplementedException("No está implementado.");
        }

        public virtual void Debug(String metodo, TEntity item, String parametro)
        {
            throw new NotImplementedException("No está implementado.");
        }

        //public void Debug(String clase, String metodo, String parametros)//, String nomUsuario, String nomProyecto)
        //{
        //    if (String.IsNullOrEmpty(nomArchivoDebug))
        //        nomArchivoDebug = "Debug";
        //    DebugHandler Debug = new DebugHandler();
        //    String nomUsuario, nomProyecto;
        //    nomUsuario = nomProyecto = String.Empty;
        //    if (itemUsuario != null)
        //        nomUsuario = itemUsuario.nomUsu;
        //    if (itemUsuario != null && itemUsuario.Proyecto != null)
        //        nomProyecto = String.Format("{0} - {1}", itemUsuario.Proyecto.codProy, itemUsuario.Proyecto.nomProy);
        //    Debug.EscribirDebug(PathLog, nomArchivoDebug + ".XML", clase, metodo, parametros, 1, nomUsuario, nomProyecto);
        //}

        //public void Error(Exception ex)
        //{
        //    try
        //    {
        //        ErrorHandler Error = new ErrorHandler();
        //        String nomUsuario, nomProyecto, Error_Type, Error_Description, Error_Source, Error_Stack_Trace, Error_Caused_By_Method;
        //        nomUsuario = nomProyecto = Error_Type = Error_Description = Error_Source = Error_Stack_Trace = Error_Caused_By_Method = String.Empty;

        //        if (itemUsuario != null)
        //            nomUsuario = itemUsuario.nomUsu;

        //        if (itemUsuario != null && itemUsuario.Proyecto != null)
        //            nomProyecto = String.Format("{0} - {1}", itemUsuario.Proyecto.codProy, itemUsuario.Proyecto.nomProy);

        //        //Error_Type = (ex.InnerException == null) ? ex.Data.ToString() : (ex.InnerException.InnerException == null ? ex.InnerException.Data.ToString() : ex.InnerException.InnerException.Data.ToString());
        //        //Error_Description = (ex.InnerException == null) ? ex.Message : (ex.InnerException.InnerException == null ? ex.InnerException.Message : ex.InnerException.InnerException.Message);
        //        //Error_Source = (ex.InnerException == null) ? ex.Source : (ex.InnerException.InnerException == null ? ex.InnerException.Source : ex.InnerException.InnerException.Source);
        //        //Error_Stack_Trace = (ex.InnerException == null) ? ex.StackTrace : (ex.InnerException.InnerException == null ? ex.InnerException.StackTrace : ex.InnerException.InnerException.StackTrace);
        //        //Error_Caused_By_Method = (ex.InnerException == null) ? ex.TargetSite.ToString() : (ex.InnerException.InnerException == null ? (ex.InnerException.TargetSite == null ? "" : ex.InnerException.TargetSite.ToString()) : ex.InnerException.InnerException.TargetSite.ToString());

        //        Error_Type = ex.Data.ToString();
        //        Error_Description = ex.Message;
        //        if (ex.InnerException != null)
        //            Error_Description += ", inner:" + ex.InnerException.Message;
        //        if (ex.InnerException != null && ex.InnerException.InnerException != null)
        //            Error_Description += ", inner:" + ex.InnerException.InnerException.Message;
        //        Error_Source = ex.Source;
        //        Error_Stack_Trace = ex.StackTrace;
        //        if (ex.InnerException != null)
        //            Error_Stack_Trace += ", inner:" + ex.InnerException.StackTrace;
        //        Error_Caused_By_Method = (ex.TargetSite != null) ? ex.TargetSite.ToString() : "-";

        //        Error.EscribirError(
        //           PathLog,
        //           "Error.XML",
        //           nomUsuario,
        //           nomProyecto,
        //           Error_Type, Error_Description,
        //           Error_Source, Error_Stack_Trace,
        //           Error_Caused_By_Method);

        //    }
        //    catch { }
        //}
    }
}
