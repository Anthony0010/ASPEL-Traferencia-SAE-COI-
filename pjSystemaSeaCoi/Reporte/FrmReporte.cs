using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace pjSystemaSeaCoi.Reporte
{
    public partial class FrmReporte : Form
    {
        CRReportePoliza poliza = new CRReportePoliza();
        dataBase.Conexion conexion = new dataBase.Conexion();
        

        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            reportesO();
        }


        public void reportParametroO(string poliza, string Descriopcion, string noPoliza)
        {

          
            CRReportePoliza2.SetParameterValue("poliza", poliza);
            CRReportePoliza2.SetParameterValue("descripcion", Descriopcion);
            CRReportePoliza2.SetParameterValue("noPoliza", noPoliza);
           


        }

       
        public void reportesO()
        {

            try
            {
                conexion.buscarAch();
                SqlConnection conn = new SqlConnection(conexion.Cadena);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select CUENTA_CONTA ,deptoid , DESCRIPCION ,IMPORTE  ,credito  from  polizas_Modelos order by  CUENTA_CONTA ", conn);
                Reporte.Poliza_Modelos ds = new Poliza_Modelos();
                adapter.Fill(ds, "polizas_Modelos");

               
                conn.Close();


               
                CRReportePoliza2.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = CRReportePoliza2;
                crystalReportViewer1.Refresh();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }





        }


       
    }
}
