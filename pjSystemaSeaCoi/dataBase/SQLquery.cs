using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pjSystemaSeaCoi.dataBase
{
   
    class SQLquery
    {
        private Conexion conexion= new Conexion();
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlDataReader leer;



        public void sql_Insert(string tabla, string campos)
        {
            try
            {
                conexion.buscarAch();
                conn = new SqlConnection(conexion.Cadena);
                conn.Open();
                comando = new SqlCommand("Inset into " + tabla + " value (" + campos + ")",conn);
                comando.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registrado");
            }
            catch (SqlException ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        public void sql_Update(string tabla, string campos, string condicion)
        {
            try
            {
                conexion.buscarAch();
                conn = new SqlConnection(conexion.Cadena);
                conn.Open();
                comando = new SqlCommand("update " + tabla + " set " + campos + " where "+condicion+"",conn);
                comando.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registrado");
            }
            catch (SqlException ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public void sql_Delete(string tabla, string condicion)
        {
            try
            {
                conexion.buscarAch();
                conn = new SqlConnection(conexion.Cadena);
                conn.Open();
                comando = new SqlCommand("Delete from" + tabla + " where " + condicion + "",conn);
                comando.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registrado");
            }
            catch (SqlException ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        
        
    }
}
