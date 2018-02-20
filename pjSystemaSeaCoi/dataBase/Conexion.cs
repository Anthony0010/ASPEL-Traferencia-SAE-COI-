using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace pjSystemaSeaCoi.dataBase
{
    class Conexion
    {

        private string cadena;

        public string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }

        
        public String buscarAch()
        {
            try
            {

                String directorio = "c:\\conexion\\SQLconn.txt";
                StreamReader read = new StreamReader(directorio);
                ListBox lista = new ListBox();


                while (read.ReadLine() != null)
                {
                    cadena = read.ReadLine();

                }

               

            }
            catch (FileNotFoundException ex) { }
            return cadena;

        }







    }
}
