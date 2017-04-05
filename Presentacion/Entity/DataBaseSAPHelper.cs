using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbobsCOM;

namespace MISAP.Entity
{
    internal sealed class DataBaseSAPHelper
      : BaseHelper
    {
        private String _server;
        private String _licenseServer;
        private String _companyDB;
        private String _dbUserName;
        private String _dbPassword;
        private String _userName;
        private String _password;
        private String _dbServerType;
        private String _language;

        public DataBaseSAPHelper()
        {
            this._server = GetValueConfig("SAP_Server");
            this._licenseServer = GetValueConfig("SAP_LicenseServer");
            this._companyDB = GetValueConfig("SAP_CompanyDB");
            this._dbUserName = GetValueConfig("SAP_DbUserName");
            this._dbPassword = GetValueConfig("SAP_DbPassword");
            this._dbServerType = GetValueConfig("SAP_DbServerType");
            this._language = GetValueConfig("SAP_Language");
        }

        internal Company getConnectionSAP()
        {
            if (String.IsNullOrEmpty(this._userName))
                throw new Exception("Debe ingresar un Usuario");

            if (String.IsNullOrEmpty(this._password))
                throw new Exception("Debe ingresar una Clave");

            //BoDataServerTypes aaa = (BoDataServerTypes)Enum.Parse(typeof(BoDataServerTypes), this._dbServerType);
            //BoSuppLangs lan = (BoSuppLangs)Enum.Parse(typeof(BoSuppLangs), this._language);
            //String prueba = String.Empty;

            Company oCompany = new Company()
            {
                Server = this._server,
                LicenseServer = this._licenseServer,
                CompanyDB = this._companyDB,
                DbUserName = this._dbUserName,
                DbPassword = this._dbPassword,
                UserName = this._userName,
                Password = this._password,
                DbServerType = (BoDataServerTypes)Enum.Parse(typeof(BoDataServerTypes), this._dbServerType),
                language = (BoSuppLangs)Enum.Parse(typeof(BoSuppLangs), this._language),
                UseTrusted = false
            };

            return oCompany;
        }

        internal Company ConnectarSAP(string usuario, string clave, out int errorCode, out string errorDescription, Boolean login = false)
        {
            int cod = 0;
            Company oCompany = null;
            errorCode = 0;
            errorDescription = String.Empty;

            this._userName = usuario ?? GetValueConfig("SAP_UserName");
            this._password = clave ?? GetValueConfig("SAP_Password");

            try
            {
                oCompany = getConnectionSAP();
                var xx1 = oCompany.DbServerType;

                if (oCompany.Connected)
                    oCompany.Disconnect();

                cod = oCompany.Connect();

                if (cod < 0)
                {
                    errorCode = oCompany.GetLastErrorCode();
                    errorDescription = oCompany.GetLastErrorDescription();
                }

                if (oCompany.Connected && !login)
                    oCompany.Disconnect();
            }
            catch (Exception ex)
            {
                oCompany = null;
                errorCode = -1;
                errorDescription = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }

            return oCompany;
        }
    }
}
