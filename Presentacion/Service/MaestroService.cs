using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MISAP.Entity;
using System.Security.Cryptography;
using System.IO;
using MISAP.Repository;

namespace MISAP.Service
{
    public abstract class MaestroService<TEntity> : BaseService<TEntity>
       where TEntity : BaseEntity, new()
    {
        public MaestroService()
        {
        }

        private BaseRepository<TEntity> _repositorio;

        internal MaestroService(BaseRepository<TEntity> repositorio)
        {
            this._repositorio = repositorio;
        }

        public override RespuestaEntity Guardar(TEntity item)
        {
            Debug("Guardar", item);
            return base.Guardar(this._repositorio, item);
        }

        //public override RespuestaEntity<TEntity> Detalle(int id)
        //{
        //    RespuestaEntity<TEntity> respuesta = new RespuestaEntity<TEntity>();
        //    Debug("Detalle", "id - docEntry = " + id);
        //    respuesta.item = this._repositorio.Detalle(id);
        //    return respuesta;
        //}

        //public override RespuestaEntity<TEntity> Detalle(string id)
        //{
        //    RespuestaEntity<TEntity> respuesta = new RespuestaEntity<TEntity>();
        //    Debug("Detalle", "id - docEntry = " + id);
        //    respuesta.item = this._repositorio.Detalle(id);
        //    return respuesta;
        //}

        //public override RespuestaEntity<TEntity> Buscar(string nombre, PaginadorEntity paginador)
        //{
        //    RespuestaEntity<TEntity> respuesta = new RespuestaEntity<TEntity>();
        //    Debug("Buscar");
        //    respuesta.items = _repositorio.Buscar(nombre, paginador);
        //    return respuesta;
        //}

        //public override RespuestaEntity<TEntity> Buscar(TEntity item, PaginadorEntity paginador)
        //{
        //    RespuestaEntity<TEntity> respuesta = new RespuestaEntity<TEntity>();
        //    Debug("Buscar", item);
        //    respuesta.items = _repositorio.Buscar(item, paginador);
        //    return respuesta;
        //}

        private void Debug(String metodo)
        {
            Debug(metodo, new TEntity() { Usuario = itemUsuario });
        }

        public void Debug(String metodo, String parametros)
        {
            Debug(metodo, new TEntity() { Usuario = itemUsuario }, parametros);
        }

        internal static new String[] CargarParametrosLicencia(StreamReader Archivo)
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

        internal static new String Decrypt(string encryptedText)
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
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
