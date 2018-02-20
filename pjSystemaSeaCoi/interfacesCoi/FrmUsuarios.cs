using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pjSystemaSeaCoi.interfacesCoi
{
    public partial class FrmUsuarios : Form
    {
      private dataBase.Conexion conexion = new dataBase.Conexion();
        private SqlConnection conn;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        string tipo_poliza, numeroPoliza, fechaIN, fechaFN;

        public FrmUsuarios(string tipo_poliza1, string numeroPoliza1 ,string  fechaIN1 ,string  fechaFN1)
        {
            this.tipo_poliza = tipo_poliza1;
            this.numeroPoliza = numeroPoliza1;
            this.fechaFN = fechaFN1;
            this.fechaIN = fechaIN1;
            InitializeComponent();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToUpper() == "POLIZA" && txtClave.Text.ToUpper() == "POLIZA")
            {
                try
                {

                    conexion.buscarAch();
                    conn = new SqlConnection(conexion.Cadena);
                    conn.Open();
                    SqlCommand comando1 = new SqlCommand("update polizaGenerada set status_p ='C' where tipo_pliza='" + tipo_poliza + "'and no_poliza='" + numeroPoliza + "'and fechaIN='" + fechaIN + "'and fechaFN ='" + fechaFN + "'", conn);
                    comando1.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Actualizado");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            //try
            //{
            //    conexion.buscarAch();
            //    conn = new SqlConnection(conexion.Cadena);
            //    conn.Open();
            //    SqlCommand comando = new SqlCommand(@"select NOMBRE  from usuarios where CLAVE ='"+txtClave.Text+"' and usuario ='"+txtUsuario.Text+"' and TIPO_USUARIO ='A'", conn);
            //    SqlDataReader leer = comando.ExecuteReader();

            //    if (leer.Read() == true)
            //    {
            //        conn.Close();

            //        conexion.buscarAch();
            //        conn = new SqlConnection(conexion.Cadena);
            //        conn.Open();
            //        SqlCommand comando1 = new SqlCommand("update polizaGenerada set status_p ='C' where tipo_pliza='" + tipo_poliza + "'and no_poliza='" + numeroPoliza + "'and fechaIN='" + fechaIN + "'and fechaFN ='" + fechaFN + "'", conn);
            //        comando1.ExecuteNonQuery();
            //        conn.Close();
                   
            //        MessageBox.Show("Actualizado");
            //        this.Close();

                  

            //    }
            //    else
            //    {

            //        MessageBox.Show("Este usuario no esta autorizado");
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
