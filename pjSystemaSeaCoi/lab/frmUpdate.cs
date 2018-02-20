using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pjSystemaSeaCoi.lab
{
    public partial class frmUpdate : Form
    {
        dataBase.ConexionCoi Conexion = new dataBase.ConexionCoi();
        SqlConnection conn;

        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }

        private void updating(string cuenta)
        {
            string cuentas = null;

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();

                if (cuenta != null)
                {
                    SqlCommand comado = new SqlCommand("Select cta_papa, nivel from CUENTAS1701 WHERE cta_papa !='-1' and num_cta='" + cuenta + "'  ", conn);
                    SqlDataReader leer = comado.ExecuteReader();


                    if (leer.Read() == true)
                    {

                        MessageBox.Show(leer["cta_papa"].ToString() + " nivel " + leer["nivel"].ToString() +" (1)");
                        cuentas = leer["cta_papa"].ToString();
                        conn.Close();

                        conn.Open();

                        SqlCommand comado1 = new SqlCommand("Select cta_papa, nivel from CUENTAS1701 WHERE cta_papa !='-1' and  num_cta='" + cuentas + "'  ", conn);
                        SqlDataReader leer1 = comado1.ExecuteReader();

                        if (leer1.Read() == true)
                        {

                            MessageBox.Show(leer1["cta_papa"].ToString() + " nivel " + leer1["nivel"].ToString() + " (2)");
                            cuentas = leer1["cta_papa"].ToString();
                            conn.Close();

                            conn.Open();
                            SqlCommand comado2 = new SqlCommand("Select cta_papa, nivel from CUENTAS1701 WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                            SqlDataReader leer2 = comado2.ExecuteReader();

                            if (leer2.Read() == true)
                            {

                                MessageBox.Show(leer2["cta_papa"].ToString() + " nivel " + leer2["nivel"].ToString() + " (3)");
                                cuentas = leer2["cta_papa"].ToString();
                                conn.Close();

                                conn.Open();
                                SqlCommand comado3 = new SqlCommand("Select cta_papa, nivel from CUENTAS1701 WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                                SqlDataReader leer3 = comado2.ExecuteReader();

                                if (leer3.Read() == true)
                                {

                                    MessageBox.Show(leer3["cta_papa"].ToString() + " nivel " + leer3["nivel"].ToString() + " (4)");
                                    cuentas = leer3["cta_papa"].ToString();
                                    conn.Close();

                                    conn.Open();
                                    SqlCommand comado4 = new SqlCommand("Select cta_papa, nivel from CUENTAS1701 WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                                    SqlDataReader leer4 = comado4.ExecuteReader();

                                    if (leer4.Read() == true)
                                    {

                                        MessageBox.Show(leer4["cta_papa"].ToString() + " nivel " + leer4["nivel"].ToString() + " (5)");
                                        conn.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cuenta raiz :" + cuentas);
                                        conn.Close();

                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Cuenta raiz :" + cuentas);
                                    conn.Close();

                                }

                            }
                            else
                            {
                                MessageBox.Show("Cuenta raiz :" + cuentas);
                                conn.Close();

                            }


                        }
                        else
                        {
                            MessageBox.Show("Cuenta raiz :" + cuentas);
                            conn.Close();
                        
                        }

                    




                    }
                    else
                    {


                        MessageBox.Show("Esta cuenta no existe");

                        conn.Close();


                    }

                }







            }
            catch (SqlException ex)

            {

                MessageBox.Show(ex.Message,"ERROR CONEXION");
            
            }







        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            updating(txtcuenta.Text);
        }


    }
}
