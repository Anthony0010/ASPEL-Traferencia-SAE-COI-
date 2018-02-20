using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pjSystemaSeaCoi.Reporte
{
    public partial class FrmReporteR : Form
    {
        CRReportePoliza poliza = new CRReportePoliza();
        dataBase.Conexion conexion = new dataBase.Conexion();

        public FrmReporteR()
        {
            InitializeComponent();
        }

        private void FrmReporteR_Load(object sender, EventArgs e)
        {
            reportes();
        }

        public void reportParametro(string poliza, string Descriopcion, string noPoliza)
        {

           
           
            CRreporte_poliza22.SetParameterValue("poliza", poliza);
            CRreporte_poliza22.SetParameterValue("descripcion", Descriopcion);
            CRreporte_poliza22.SetParameterValue("noPoliza", noPoliza);



        }

        public void reportes()
        {

            try
            {
                conexion.buscarAch();
                SqlConnection conn = new SqlConnection(conexion.Cadena);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select cuentas,deptoid , descr ,debito ,credito  from repcuentas order by cuentas", conn);
                Reporte._repcuentas ds = new _repcuentas();
                adapter.Fill(ds, "repcuentas");

                //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
                conn.Close();


                //CRReportePoliza objRpt = new CRReportePoliza();
                CRreporte_poliza22.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = CRreporte_poliza22;
                //crystalReportViewer1.Refresh();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }





        }
    }
}
