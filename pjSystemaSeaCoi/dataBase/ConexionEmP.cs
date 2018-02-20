using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace pjSystemaSeaCoi.dataBase
{
    class ConexionEmP
    {

        private string cadena;

        public string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }


        public String buscarAch()
        {

            String directorio = "c:\\conexion\\SQLconnEmp.txt";
            StreamReader read = new StreamReader(directorio);
            


            while (read.ReadLine() != null)
            {
                cadena = read.ReadLine();

            }

            return cadena;

        }
    }
}