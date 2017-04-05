using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using SAPbobsCOM;

namespace MISAP
{
    sealed class Conexion
    {
        public static SAPbobsCOM.Company oCompany;
      
        public static string identificador;

        public static void InitializeCompany(string bd_sap)
        {
            identificador = DateTime.Now.ToString("yyyyMMddHHmm");

            oCompany = new SAPbobsCOM.Company();
           
                        
          

            switch (ConfigurationManager.AppSettings["SAPDbType"]) //Tipo de BD
            {
                case "2005": oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005; break;
                case "2008": oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008; break;
                case "2012": oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012; break;
            }
            //switch (ConfigurationManager.AppSettings["AMBIENTEMISAP"]) //Tipo de BD
            //{
            //    case "Pruebas":
            //        cadenaConexion_sql = @"Data Source=SAPIMECONSERVER;Initial Catalog=Z_MISAP; User ID=sa;Password=B1Admin";
            //        break;

            //    case "Produccion":
            //        cadenaConexion_sql = @"Data Source=SAPIMECONSERVER;Initial Catalog=MISAP; User ID=sa;Password=B1Admin";
            //        break;
            //}


            oCompany.DbUserName = ConfigurationManager.AppSettings["SAPDbUserName"];
            oCompany.DbPassword = ConfigurationManager.AppSettings["SAPDbPassword"]; //Contraseña usuairo SA
            oCompany.Server = ConfigurationManager.AppSettings["SAPServer"]; //IP o servidor de SQL
           // oCompany.CompanyDB = "SBO_IMECON_PRUEBAS"; //ConfigurationManager.AppSettings["DestinoDB"];  //BASE DE DATOS
            oCompany.CompanyDB = bd_sap; //ConfigurationManager.AppSettings["DestinoDB"];  //BASE DE DATOS
            oCompany.UserName = ConfigurationManager.AppSettings["SAPUserName"];
            oCompany.Password = ConfigurationManager.AppSettings["SAPPassword"]; ;  //contraseña usuario manager
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English; //lenguaje de SQL, si esta en español usa SAPbobsCOM.BoSuppLangs.ln_Spanish
            oCompany.UseTrusted = false;

          

        }
    }
}
