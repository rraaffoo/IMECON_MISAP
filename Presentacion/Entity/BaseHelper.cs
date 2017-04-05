using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace MISAP.Entity
{
    internal abstract class BaseHelper
    {
        protected string GetValueConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        protected static string PathLog { get { return GetDirectorio(PathBase + @"logs\"); } }

        protected static string PathBase
        {
            get
            {
                string pathBase = AppDomain.CurrentDomain.BaseDirectory;
                GetPath(ref pathBase);
                return pathBase;
            }
        }

        private static void GetPath(ref string pathBase)
        {
            if (pathBase.EndsWith("\bin", StringComparison.InvariantCultureIgnoreCase) || pathBase.Contains(@"\bin\"))
                pathBase = (Directory.GetParent(pathBase.TrimEnd(new Char[] { '\\' }))).FullName + @"\";
            else
                return;

            GetPath(ref pathBase);
        }

        protected static string GetDirectorio(string directorio)
        {
            if ((directorio.Length > 0) && (!Directory.Exists(directorio)))
                Directory.CreateDirectory(directorio);

            return directorio;
        }

        public void LogBase(string path, string message, String title = "")
        {
            String pathLog = Path.Combine(PathLog, path);
            this.WriteLog(pathLog, message, title);
        }

        protected void WriteLog(string path, string message, String title = "")
        {
            if (!File.Exists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
            }
            using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                message = String.Format("Fecha: {0}, Error: {1}", DateTime.Now, message);
                using (StreamWriter writer = new StreamWriter(stream))
                    writer.WriteLine(message);
            }
        }
    }
}
