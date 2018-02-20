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
    public partial class frmBaseDeDatos : Form
    {
        private dataBase.ConexionEmP Conexion = new dataBase.ConexionEmP();
        SqlConnection conn;

        
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        private void frmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                //select empresa,dabaDatos,servidor ,usuario , clave from EmpresaConexion

                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("insert into EmpresaConexion(empresa,dabaDatos,servidor ,usuario , clave) values ('"+txtCodigo.Text+"','"+txtBaseDatos.Text+"','"+txtServidor.Text+"','"+txtUsuario.Text+"','"+txtClave.Text+"') ", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                limpiar();
                MessageBox.Show("Registrado");

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("update EmpresaConexion set dabaDatos='"+txtBaseDatos.Text+"', servidor='"+txtServidor.Text+"', usuario='"+txtUsuario.Text+"', clave='"+txtClave.Text+"' where  empresa='"+txtCodigo.Text+"'", conn);
                comando.ExecuteNonQuery();
                conn.Close();
                limpiar();

                MessageBox.Show("Registrado");

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void Registrar()
        {
            btnActualizar.Visible = false;
            btnConsultar.Visible = false;          
        
        
        }
        public void Actualizar()
        {
            btnRegistrar.Visible = false;


        }

     void limpiar()
     {

         txtClave.Clear();
         txtBaseDatos.Clear();
         txtClave.Clear();
         txtUsuario.Clear();
         txtServidor.Clear();
     
     
     }

     private void btnConsultar_Click(object sender, EventArgs e)
     {
         Conexion.buscarAch();
         conn = new SqlConnection(Conexion.Cadena);
         conn.Open();
         SqlCommand comando = new SqlCommand(@" select dabaDatos,servidor ,usuario , clave from EmpresaConexion where empresa ='"+txtCodigo.Text+"' ", conn);
         SqlDataReader leer = comando.ExecuteReader();

         if (leer.Read() == true)
         {

             txtBaseDatos.Text = leer["dabaDatos"].ToString();
             txtServidor.Text = leer["servidor"].ToString();
             txtUsuario.Text = leer["usuario"].ToString();
             txtClave.Text = leer["clave"].ToString();
             conn.Close();
         }
         else {
             conn.Close();
             MessageBox.Show("Esta empresa no existe");
         
         }
        
     }

       

       
    }
}
