using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Datos
{


    class Configuracion
    {
        public static string cadenaConexion_sql;
        public static string cadenaConexion_interfaz = @"Data Source=SAPIMECONSERVER;Initial Catalog=INTERFAZB1; User ID=sa;Password=B1Admin";
        public static string cadenaConexion_sap = @"Data Source=SAPIMECONSERVER;Initial Catalog=ZZZ_IMECON_10FEB2017; User ID=sa;Password=B1Admin"; // @"Data Source=SAPIMECONSERVER;Initial Catalog=SBO_IMECON_PRODUCCION; User ID=sa;Password=B1Admin";
        public static string cadenaConexion_s10 = @"Data Source=10.0.0.20\S10;Initial Catalog=Base_2007; User ID=sa;Password=1m3c0n";
        public static string cadenaConexion_imerp = @"Data Source=10.0.0.7;Initial Catalog=erpdb; User ID=admin;Password=lpadmin;CHARSET=utf8;convert zero datetime=True;Connect Timeout=200";
        public static string cadenaConexion_starsoft = @"Data Source=10.0.0.20\STARSOFT;Initial Catalog=015BDCONTABILIDAD; User ID=sa;Password=$46Zim*23";
        public static string cadenaConexion_planilla = @"Data Source=10.0.0.20\STARSOFT;Initial Catalog=IMECON; User ID=sa;Password=$46Zim*23";
        public static string cadenaConexion_conasist = @"Data Source=10.0.0.20\CONASIST;Initial Catalog=DAT0003; User ID=sa;Password=1m3c0n";
        public static string cadenaConexion_mcop = @"Data Source=10.0.0.20\IMESAP;Initial Catalog=MCOP; User ID=sa;Password=bd1m3c0n~2014";
        public static string cadenaConexion_SCIRERH = @"Data Source=10.0.0.20\ALVISOFT;Initial Catalog=SCIRERH; User ID=sa;Password=bd1m3c0n~2014";

        static void definir_ambiente()
        {
            switch (ConfigurationManager.AppSettings["AMBIENTEMISAP"]) //Ambiente
           {
               case "Pruebas":
                   cadenaConexion_sql= @"Data Source=SAPIMECONSERVER;Initial Catalog=MISAP; User ID=sa;Password=B1Admin";
               break;

               case "Produccion":
                    cadenaConexion_sql = @"Data Source=SAPIMECONSERVER;Initial Catalog=MISAP; User ID=sa;Password=B1Admin";
               break;

           }
        }

        public static string CadenaConexion_sql
        {
            get
            {
                definir_ambiente();
                return cadenaConexion_sql;
            }
        }


        public static string CadenaConexion_mcop
        {
            get { return cadenaConexion_mcop; }
        }

        public static string CadenaConexion_SCIRERH
        {
            get { return cadenaConexion_SCIRERH; }
        }

        public static string CadenaConexion_interfaz
        {
            get { return cadenaConexion_interfaz; }
        }

        public static string CadenaConexion_conasist
        {
            get { return cadenaConexion_conasist; }
        }

        public static string CadenaConexion_sap
        {
            get { return cadenaConexion_sap; }
        }

        public static string CadenaConexion_s10
        {
            get { return cadenaConexion_s10; }
        }

        public static string CadenaConexion_imerp
        {
            get
            {
                return cadenaConexion_imerp;
            }
        }

        public static string CadenaConexion_starsoft
        {
            get
            {
                return cadenaConexion_starsoft;
            }
        }

        public static string CadenaConexion_planilla
        {
            get
            {
                return cadenaConexion_planilla;
            }
        }

    }

}
