using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOra
{
    public class Conectar
    {
        static String con = "DATA SOURCE=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = portafolio.cmva6l5m8wzt.sa-east-1.rds.amazonaws.com)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = PORTA)));USER ID=Admin ;PASSWORD=admin123";
        static OracleConnection ora = new OracleConnection(con);
        static Conectar conn = new Conectar();
        private Conectar()
        {
            ora.Open();
        }
        public static OracleConnection Conexion
        {
            get
            {
                if (ora != null)
                {
                    return ora;
                }
                else
                {
                    return ora = new OracleConnection(con);
                }
            }
        }
    }
}
