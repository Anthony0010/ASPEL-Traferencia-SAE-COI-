using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using pjSystemaSeaCoi.Reporte;

namespace pjSystemaSeaCoi.interfacesCoi
{
    public partial class FrmPoliza : Form
    {
        dataBase.ConexionCoi Conexion = new dataBase.ConexionCoi();
        dataBase.SQLqueryCoi query = new dataBase.SQLqueryCoi();
        dataBase.Conexion ConexionSawin = new dataBase.Conexion();
        SqlConnection conn;
        public FrmPoliza()
        {
            InitializeComponent();
        }

        private void borrarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void FrmPoliza_Load(object sender, EventArgs e)
        {
            dgPoliza.AllowUserToAddRows.Equals(false);
            dgPoliza.ReadOnly = true;
            dgPoliza.AllowDrop = false;
            dgPoliza.AllowUserToResizeRows = false;
            dgPoliza.AllowUserToResizeColumns = false;
            txtConcepto.Text = lblTitulo.Text + " Desde :" + dtFechaInical.Value.ToString("dd/MM/yyyy") + " Hasta :" + dtFecha.Value.ToString("dd/MM/yyyy");

            txtperiodo.Text = dtFecha.Value.Month.ToString();
            txtejercio.Text = dtFecha.Value.Year.ToString();
            tipo(lblEmpresa.Text);
            numeroPartida();
            CalculoDebCre();
           

            try
            {
                for (int n = 0; n <= dgPoliza.Rows.Count - 1; n++)
                {
                    dgPoliza[0, n].Value = dgCuentas[0, n].Value;
                    
                    

                    
                }
                int nt=0;

                foreach (DataGridViewRow fila in dgPoliza.Rows)
                {
                    dgPoliza[0, nt].Visible.Equals(false);
                    dgPoliza.Columns[4].DefaultCellStyle.Format = "0.00";
                    dgPoliza.Columns[5].DefaultCellStyle.Format = "0.00";
                   
                    nt++;
                
                }
                
            }
            catch (ArgumentOutOfRangeException ex)
            { 
            //exportar a excel los productos que estabn sin cuentas y recorrer denuevo con las cuentasm
                if (MessageBox.Show("Existen productos sin numero de cuenta, Desea Exportarlo", "Cuentas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int n = 0;

                        StreamWriter escr = new StreamWriter(@"C:\conexion\proSinCuentas\Productos" + cbTipo.Text + ".xls");
                        escr.WriteLine("Descripcion ");
                        foreach (DataGridViewRow fila in dgPoliza.Rows)
                        {

                            if (fila.Cells[1].Value.ToString().Trim() == "")
                            {
                                n = fila.Cells[2].RowIndex;
                                escr.WriteLine(dgPoliza[3, n].Value.ToString());

                            }




                        }
                        escr.Close();


                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "EXCEL.EXE";
                        startInfo.Arguments = @"C:\conexion\proSinCuentas\Productos" + cbTipo.Text + ".xls";
                        Process.Start(startInfo);
                        this.Close();

                    }

                    catch (IOException ext)
                    {
                        MessageBox.Show("Debe cerrar el archivo Productos" + cbTipo.Text + ".xls para continuar" + ext.Message);
                        this.Close();
                    }

                }
                else { this.Close(); }
            }

           
        }

        private void CalculoDebCre()
        {

            decimal debito = 0, credito = 0;
            foreach (DataGridViewRow fila in dgPoliza.Rows)
            {
              
                debito += Decimal.Parse(fila.Cells[4].Value.ToString());
                credito += Decimal.Parse(fila.Cells[5].Value.ToString());
            }
            txtDebito.Text = Math.Round(debito,2).ToString();
            txtCredito.Text = Math.Round(credito,2).ToString();
        }
        private void numeroPartida()
        {

            txtNoPartida.Text = dgPoliza.Rows.Count.ToString();        
        }
        private void tipo(string empresa)
        {
            try {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT TIPPOL FROM FOLIOS"+empresa+" where  ejercicio='"+txtejercio.Text+"'", conn);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read() == true)

                {
                    cbTipo.Items.Add(leer["TIPPOL"].ToString());
                    while (leer.Read())

                    {
                        cbTipo.Items.Add(leer["TIPPOL"].ToString());
                    
                    }


                    conn.Close();
                }

            
            
            
            }
            catch (SqlException ex)
            {
                conn.Close();   
                MessageBox.Show(ex.Message); }

        }


        private void Folio(string mes1, string tipo)
        {
            if (mes1.Length == 1)
            {
                mes1 = "0" +mes;
            
            }

            Mes();

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("SELECT isnull(Max(FOLIO"+mes+"),0)+1 folio FROM FOLIOS"+lblEmpresa.Text+" where TIPPOL='"+tipo+"'AND EJERCICIO='"+txtejercio.Text+"' ", conn);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read() == true)
                {


                    txtNoFolio.Text = leer["folio"].ToString();

                    conn.Close();
                }




            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
        int n;
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (cbTipo.Text== string.Empty || txtNoFolio.Text ==string.Empty)
           {
               MessageBox.Show("Tipo poliza no puede estar vacio");

           }
           else if (!(Decimal.Parse(txtCredito.Text) < Decimal.Parse(txtDebito.Text) + 1 && Decimal.Parse(txtDebito.Text) < Decimal.Parse(txtCredito.Text)+ 1))
           {
               MessageBox.Show("La poliza esta descuadrada");
           
           }
           else
           {

               GuardarPoliza();

               foreach (DataGridViewRow fila in dgPoliza.Rows)
               {

                   if (fila.Cells[0].Value.ToString().Trim() != "")
                   {
                       n = fila.Cells[0].RowIndex;
                       updating(dgPoliza[0, n].Value.ToString(), dgPoliza[4, n].Value.ToString(), dgPoliza[5, n].Value.ToString());


                   }




               }
               MessageBox.Show("Guardado");
               this.Hide();

               if (lblTitulo.Text != "Cuenta por Cobrar")
               {
                   FrmReporteR frm = new FrmReporteR();
                   frm.reportParametro(cbTipo.Text, txtConcepto.Text, txtNoFolio.Text);
                   frm.ShowDialog();
               }
               else {

                   FrmReporte frm = new FrmReporte();
                   frm.reportParametroO(cbTipo.Text, txtConcepto.Text, txtNoFolio.Text);
                   frm.ShowDialog();
               
               }

           }


        }

        private void GuardarPoliza()
        {
            try {

                Mes();

                if (txtNoFolio.Text.Length == 1)
                {

                    txtNoFolio.Text = "    " + txtNoFolio.Text;
                }
                else if (txtNoFolio.Text.Length == 2)
                {
                    txtNoFolio.Text = "   " + txtNoFolio.Text;
                }
                else if (txtNoFolio.Text.Length == 3)
                {
                    txtNoFolio.Text = "  " + txtNoFolio.Text;
                }
                else if (txtNoFolio.Text.Length == 4)
                {
                    txtNoFolio.Text = " " + txtNoFolio.Text;
                }
                else if (txtNoFolio.Text.Length == 5)
                {
                    txtNoFolio.Text = txtNoFolio.Text;
                }

                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
               //Lineas con uud   SqlCommand comando1 = new SqlCommand("insert into POLIZAS" + txtejercio.Text.Substring(2, 2) + lblEmpresa.Text + " ( TIPO_POLI ,  NUM_POLIZ ,  PERIODO ,  EJERCICIO ,  FECHA_POL ,  NUM_PART ,  LOGAUDITA ,  CONTABILIZ ,  NUMPARCUA ,  TIENEDOCUMENTOS ,  PROCCONTAB ,  ORIGEN ,  UUID ,  ESPOLIZAPRIVADA, CONCEP_PO ) values ('" + cbTipo.Text + "','" + txtNoFolio.Text + "'," + Int32.Parse(txtperiodo.Text) + "," +Int32.Parse(txtejercio.Text) + ",'" + dtFecha.Text + "'," + Int32.Parse(txtNoPartida.Text) + ",'N','S','0','0','0','COI','','0','"+txtConcepto.Text+"')", conn);
                SqlCommand comando1 = new SqlCommand("insert into POLIZAS" + txtejercio.Text.Substring(2, 2) + lblEmpresa.Text + " ( TIPO_POLI ,  NUM_POLIZ ,  PERIODO ,  EJERCICIO ,  FECHA_POL ,  NUM_PART ,  LOGAUDITA ,  CONTABILIZ ,  NUMPARCUA ,  TIENEDOCUMENTOS ,  PROCCONTAB ,  ORIGEN ,  CONCEP_PO ) values ('" + cbTipo.Text + "','" + txtNoFolio.Text + "'," + Int32.Parse(txtperiodo.Text) + "," + Int32.Parse(txtejercio.Text) + ",'" + dtFecha.Text + "'," + Int32.Parse(txtNoPartida.Text) + ",'N','S','0','0','0','COI','" + txtConcepto.Text + "')", conn);
                comando1.ExecuteNonQuery();
                conn.Close();


                ConexionSawin.buscarAch();
                conn = new SqlConnection(ConexionSawin.Cadena);
                conn.Open();
                SqlCommand comando2 = new SqlCommand("insert into polizaGenerada(tipo_pliza,status_p,fechaIN,fechaFN,no_poliza,tip_doc,descripcion) values ('" + cbTipo.Text + "','A','" + dtFechaInical.Text + "','" + dtFecha.Text + "','" + txtNoFolio.Text + "','" + lblTipoDoc.Text + "','" + lblTitulo.Text + "')", conn);
                comando2.ExecuteNonQuery();
                conn.Close();

                //if (txtperiodo.Text.Length == 1)
                //{
                //    txtperiodo.Text = "0" + txtperiodo.Text;

                //}
                //en la tabla el numero es el la empresa y en el campo el numero es el mes
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando3 = new SqlCommand("update FOLIOS"+lblEmpresa.Text+" set FOLIO"+mes+" = FOLIO"+mes+" + 1  where EJERCICIO ='" + txtejercio.Text + "'", conn);
                comando3.ExecuteNonQuery();
                conn.Close();


                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                string ejercio = txtejercio.Text.Substring(2, 2);
               // SqlCommand comando = new SqlCommand(@"insert into  AUXILIAR"+ejercio+ lblEmpresa.Text +" ( TIPO_POLI ,  NUM_POLIZ ,  NUM_PART ,  PERIODO ,  EJERCICIO ,  NUM_CTA ,  FECHA_POL ,  CONCEP_PO ,  DEBE_HABER ,  MONTOMOV ,  NUMDEPTO ,  TIPCAMBIO ,  CONTRAPAR ,  ORDEN ,  CCOSTOS ,  CGRUPOS ,  IDINFADIPAR ,  IDUUID ) values(@TIPO_POLI ,  @NUM_POLIZ ,  @NUM_PART ,  @PERIODO ,  @EJERCICIO ,  @NUM_CTA ,  @FECHA_POL ,  @CONCEP_PO ,  @DEBE_HABER ,  @MONTOMOV ,  @NUMDEPTO ,  @TIPCAMBIO ,  @CONTRAPAR ,  @ORDEN ,  @CCOSTOS ,  @CGRUPOS ,  @IDINFADIPAR ,  @IDUUID )", conn);
                SqlCommand comando = new SqlCommand(@"insert into  AUXILIAR" + ejercio + lblEmpresa.Text + " ( TIPO_POLI ,  NUM_POLIZ ,  NUM_PART ,  PERIODO ,  EJERCICIO ,  NUM_CTA ,  FECHA_POL ,  CONCEP_PO ,  DEBE_HABER ,  MONTOMOV ,  NUMDEPTO ,  TIPCAMBIO ,  CONTRAPAR ,  ORDEN ,  CCOSTOS ,  CGRUPOS  ) values(@TIPO_POLI ,  @NUM_POLIZ ,  @NUM_PART ,  @PERIODO ,  @EJERCICIO ,  @NUM_CTA ,  @FECHA_POL ,  @CONCEP_PO ,  @DEBE_HABER ,  @MONTOMOV ,  @NUMDEPTO ,  @TIPCAMBIO ,  @CONTRAPAR ,  @ORDEN ,  @CCOSTOS ,  @CGRUPOS  )", conn);

                int n = 1;

                foreach (DataGridViewRow fila in dgPoliza.Rows)
                {


                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@TIPO_POLI",Convert.ToString(cbTipo.Text));

                    if (txtNoFolio.Text.Length == 1)
                    {

                        txtNoFolio.Text = "    " + txtNoFolio.Text;
                    }
                    else if (txtNoFolio.Text.Length == 2)
                    {
                        txtNoFolio.Text = "   " + txtNoFolio.Text;
                    }
                    else if (txtNoFolio.Text.Length == 3)
                    {
                        txtNoFolio.Text = "  " + txtNoFolio.Text;
                    }
                    else if (txtNoFolio.Text.Length == 4)
                    {
                        txtNoFolio.Text = " " + txtNoFolio.Text;
                    }
                    else if (txtNoFolio.Text.Length == 5)
                    {
                        txtNoFolio.Text =  txtNoFolio.Text;
                    }

                   
                    




                    comando.Parameters.AddWithValue("@NUM_POLIZ", Convert.ToString(txtNoFolio.Text));
                
                    comando.Parameters.AddWithValue("@NUM_PART",Convert.ToString(n) );
                    comando.Parameters.AddWithValue("@PERIODO", Convert.ToString(txtperiodo.Text));
                    comando.Parameters.AddWithValue("@EJERCICIO", Convert.ToString(txtejercio.Text));
                    comando.Parameters.AddWithValue("@NUM_CTA", Convert.ToString(fila.Cells[0].Value.ToString()));
                    comando.Parameters.AddWithValue("@FECHA_POL",Convert.ToString(dtFecha.Text));
                    comando.Parameters.AddWithValue("@CONCEP_PO", Convert.ToString(fila.Cells[3].Value.ToString()));
                    if (fila.Cells[4].Value.ToString() != "0")
                    {
                        comando.Parameters.AddWithValue("@DEBE_HABER","D");
                        comando.Parameters.AddWithValue("@MONTOMOV", fila.Cells[4].Value.ToString());
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@DEBE_HABER", "H");
                        comando.Parameters.AddWithValue("@MONTOMOV", fila.Cells[5].Value.ToString()); 
                    }

                    
                    comando.Parameters.AddWithValue("@NUMDEPTO", fila.Cells[2].Value.ToString());

                    comando.Parameters.AddWithValue("@TIPCAMBIO", "1");
                    comando.Parameters.AddWithValue("@CONTRAPAR", "0");
                    comando.Parameters.AddWithValue("@ORDEN", "2");
                    comando.Parameters.AddWithValue("@CCOSTOS", "0");

                    comando.Parameters.AddWithValue("@CGRUPOS", "0");
                   // comando.Parameters.AddWithValue("@IDINFADIPAR","-1");
                    //comando.Parameters.AddWithValue("@IDUUID", "-1");

                    comando.ExecuteNonQuery();
                    n++;
                }
                conn.Close();


               
             

              



            
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Folio(txtperiodo.Text, cbTipo.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void updating( string cuenta, string debito, string credito)

        {
            string cuentas = null;

            try
            {
                Mes();
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();

                if (cuenta != null)
                {
                    //updating 

                    ////MessageBox.Show(cuenta);
                    query.sql_Update(@"SALDOS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + "", "CARGO" + mes + " = CARGO" + mes + " + " + debito + ", ABONO" + mes + " = ABONO" + mes + " + " + credito + ", CARGOEX" + mes + " = CARGOEX" + mes + " + 0, ABONOEX" + mes + " = ABONOEX" + mes + " + 0, MOV" + mes + " = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuenta + "' ");

                    SqlCommand comado = new SqlCommand("Select cta_papa, nivel from CUENTAS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + " WHERE cta_papa !='-1' and num_cta='" + cuenta + "'  ", conn);
                    SqlDataReader leer = comado.ExecuteReader();


                    if (leer.Read() == true)
                    {

                        //MessageBox.Show(leer["cta_papa"].ToString() + " nivel " + leer["nivel"].ToString() + " (1)");
                        cuentas = leer["cta_papa"].ToString();
                        conn.Close();
                        //updating 
                        query.sql_Update(@"SALDOS" + txtejercio.Text.Substring(2, 2) + lblEmpresa.Text + "", "CARGO" + mes + " = CARGO" + mes + " + " + debito + ", ABONO" + mes + " = ABONO" + mes + " + " + credito + ", CARGOEX" + mes + " = CARGOEX" + mes + " + 0, ABONOEX" + mes + " = ABONOEX" + mes + " + 0, MOV" + mes + " = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuentas + "' ");                
                        conn.Open();

                        SqlCommand comado1 = new SqlCommand("Select cta_papa, nivel from CUENTAS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + " WHERE cta_papa !='-1' and  num_cta='" + cuentas + "'  ", conn);
                        SqlDataReader leer1 = comado1.ExecuteReader();

                        if (leer1.Read() == true)
                        {

                            //MessageBox.Show(leer1["cta_papa"].ToString() + " nivel " + leer1["nivel"].ToString() + " (2)");
                            cuentas = leer1["cta_papa"].ToString();
                            conn.Close();
                            //updating 
                            query.sql_Update(@"SALDOS" + txtejercio.Text.Substring(2, 2) + lblEmpresa.Text + "", "CARGO" + mes + " = CARGO" + mes + " + " + debito + ", ABONO" + mes + " = ABONO" + mes + " + " + credito + ", CARGOEX" + mes + " = CARGOEX" + mes + " + 0, ABONOEX" + mes + " = ABONOEX" + mes + " + 0, MOV" + mes + " = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuentas + "' ");                
                       
                            conn.Open();
                            SqlCommand comado2 = new SqlCommand("Select cta_papa, nivel from CUENTAS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + " WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                            SqlDataReader leer2 = comado2.ExecuteReader();

                            if (leer2.Read() == true)
                            {

                                //MessageBox.Show(leer2["cta_papa"].ToString() + " nivel " + leer2["nivel"].ToString() + " (3)");
                                cuentas = leer2["cta_papa"].ToString();
                                conn.Close();
                                //updating 
                                query.sql_Update(@"SALDOS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + "", "CARGO" + mes + " = CARGO" + mes + " + " + debito + ", ABONO" + mes + " = ABONO" + mes + " + " + credito + ", CARGOEX" + mes + " = CARGOEX" + mes + " + 0, ABONOEX" + mes + " = ABONOEX" + mes + " + 0, MOV" + mes + " = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuentas + "' ");                
                       
                                conn.Open();
                                SqlCommand comado3 = new SqlCommand("Select cta_papa, nivel from CUENTAS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + " WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                                SqlDataReader leer3 = comado2.ExecuteReader();

                                if (leer3.Read() == true)
                                {

                                    //MessageBox.Show(leer3["cta_papa"].ToString() + " nivel " + leer3["nivel"].ToString() + " (4)");
                                    cuentas = leer3["cta_papa"].ToString();
                                    conn.Close();
                                    //updating 
                                    //query.sql_Update(@"SALDOS1701", "CARGO01 = CARGO01 + " + debito + ", ABONO01 = ABONO01 + " + credito + ", CARGOEX01 = CARGOEX01 + 0, ABONOEX01 = ABONOEX01 + 0, MOV01 = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuentas + "' ");                
                       
                                    conn.Open();
                                    SqlCommand comado4 = new SqlCommand("Select cta_papa, nivel from CUENTAS" + txtejercio.Text.Substring(2, 2) + lblEmpresa.Text+" WHERE cta_papa !='-1' and num_cta='" + cuentas + "'  ", conn);
                                    SqlDataReader leer4 = comado4.ExecuteReader();

                                    if (leer4.Read() == true)
                                    {

                                        //MessageBox.Show(leer4["cta_papa"].ToString() + " nivel " + leer4["nivel"].ToString() + " (5)");
                                        cuentas = leer4["cta_papa"].ToString();
                                        conn.Close();
                                        query.sql_Update(@"SALDOS" + txtejercio.Text.Substring(2, 2) + "" + lblEmpresa.Text + "", "CARGO" + mes + " = CARGO" + mes + " + " + debito + ", ABONO" + mes + " = ABONO" + mes + " + " + credito + ", CARGOEX" + mes + " = CARGOEX" + mes + " + 0, ABONOEX" + mes + " = ABONOEX" + mes + " + 0, MOV" + mes + " = 1 ", "EJERCICIO ='" + txtejercio.Text + "' AND NUM_CTA ='" + cuentas + "' ");                
                       

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

                MessageBox.Show(ex.Message, "ERROR CONEXION");

            }

        }

        String mes;
        private String Mes()
        { 
        if(txtperiodo.Text.Length==1)
        {
        mes = "0"+txtperiodo.Text;
        } else if (txtperiodo.Text.Length==2)
        {
            mes = txtperiodo.Text;
        }

        return mes;
        
        }
        private void dgCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtejercio.Text.Substring(2,2));
        }

        private void txtDebito_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgPoliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    
       
      
        

        

      
    }
}
