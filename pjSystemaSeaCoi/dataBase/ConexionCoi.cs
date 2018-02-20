using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace pjSystemaSeaCoi.dataBase
{
    class ConexionCoi
    {
        private string cadena;

        public string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }


        public String buscarAch()
        {

            String directorio = "c:\\conexion\\SQLconnCoi.txt";
            StreamReader read = new StreamReader(directorio);
            ListBox lista = new ListBox();


            while (read.ReadLine() != null)
            {
                cadena = read.ReadLine();

            }

            return cadena;


        }



    }
}
