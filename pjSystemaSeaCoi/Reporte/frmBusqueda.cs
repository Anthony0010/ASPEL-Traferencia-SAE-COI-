using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pjSystemaSeaCoi.Reporte
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
        }

        public void reportParametro(string poliza, string Descriopcion, string noPoliza)
        {

            //CRReportePoliza1.SetDatabaseLogon("mbs","mbs");
        
            CRReportePoliza1.SetParameterValue("poliza", poliza);
            CRReportePoliza1.SetParameterValue("descripcion", Descriopcion);
            CRReportePoliza1.SetParameterValue("noPoliza", noPoliza);



        }
    }
}
