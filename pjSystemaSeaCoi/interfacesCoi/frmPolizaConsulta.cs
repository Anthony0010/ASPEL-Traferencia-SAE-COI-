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
    public partial class frmPolizaConsulta : Form
    {

        dataBase.ConexionCoi conexion = new dataBase.ConexionCoi();
        SqlConnection conn;
        public frmPolizaConsulta()
        {
            InitializeComponent();
        }

        private void frmPolizaConsulta_Load(object sender, EventArgs e)
        {
            CalculoDebCre();
            numeroPartida();
        }

        public void cosulta(string descripcion,string tipoPoliza,string tipo_doc,string fechaIN, string fechaFN )
        {
            try {

                

                conexion.buscarAch();
                conn = new SqlConnection(conexion.Cadena);
                SqlDataAdapter dt = new SqlDataAdapter(@"Select  A.NUM_CTA,A.NUMDEPTO,A.CONCEP_PO,A.DEBE_HABER ,A.MONTOMOV from coiwin.dbo.AUXILIAR1701 A, Saewin.dbo.polizaGenerada G
where A.TIPO_POLI= G.tipo_pliza AND A.TIPO_POLI ='" + tipoPoliza + "' ", conn);

                DataSet ds = new DataSet();

                dt.Fill(ds);

                dgPoliza.DataSource = ds.Tables[0];
            
            
            
            }
            catch(SqlException ex) {


                MessageBox.Show(ex.Message);
            
            
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
            txtDebito.Text = debito.ToString("0,00");
            txtCredito.Text = credito.ToString("0,00");
        }


        private void numeroPartida()
        {

            txtPartida.Text = dgPoliza.Rows.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        

      

      
       
    }
}
