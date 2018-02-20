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
    public partial class FrmInsertar : Form
    {
      private dataBase.SQLquery Querry = new dataBase.SQLquery();
      private interfacesCoi.FrmCuentasContables cuentaContable = new FrmCuentasContables();



        public FrmInsertar()
        {
            
        }

        
        


        public FrmInsertar(int codigo, string descripcion, string cuentas,string nombre)
        {
            InitializeComponent();
            this.txtNo.Text = codigo.ToString();
            this.txtDescripcion.Text = descripcion;
            this.txtCuenta.Text = cuentas;
            this.lblNombre.Text = nombre;
            
        
        }

        public FrmInsertar(string codigo, string descripcion, string cuentas, string nombre)
        {
            InitializeComponent();
            this.txtNo.Text = codigo.ToString();
            this.txtDescripcion.Text = descripcion;
            this.txtCuenta.Text = cuentas;
            this.lblNombre.Text = nombre;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            if (lblNombre.Text == "Generales")
            {

                Querry.sql_Update("CUENTAS_CONTABLES", " CUENTAS=" + txtCuenta.Text + "", " TIPO='" + txtNo.Text + "' ");
            }
            if (lblNombre.Text == "Zonas")
                {
                   
                    Querry.sql_Update("ZONA01", " CTA_CONT=" + txtCuenta.Text + "", " CVE_ZONA='" + txtNo.Text + "' ");
                }

                    if(lblNombre.Text =="CxC")
                    {
                                        
                        Querry.sql_Update("CONC01", " CUEN_CONT=" + txtCuenta.Text + "", " NUM_CPTO='"+txtNo.Text+"' ");                       

                    
                    }
                        if(lblNombre.Text =="CxP")
                        {
                       
                            Querry.sql_Update("CONP01", " CUEN_CONT=" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");                          


                        }
                           
                            if (lblNombre.Text == "Movimiento al inventario")
                                {
                                                           
                                    Querry.sql_Update("CONM01", " CUEN_CONT=" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");
                                
                            }
                                if (lblNombre.Text == "Lineas") 
                                {
                               
                                    Querry.sql_Update("CLIN01", " CUENTA_COI=" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");

                                }
                                   
                                    if (lblNombre.Text == "Clientes")
                                         { 
                                  
                                             Querry.sql_Update("CLIE01", " CUENTA_CONTABLE=" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");
                                     }
                                         if (lblNombre.Text == "Proveedores")
                                                 {
                                             
                                                     Querry.sql_Update("PROV01", " CUENTA_CONTABLE=" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");
                                         
                                         }
                                         if (lblNombre.Text == "Inventario")
                                           {
                                      
                                               Querry.sql_Update("INVE01", " CUENTA_CONTABLE =" + txtCuenta.Text + "", " NUM_REG='" + txtNo.Text + "' ");
                                         }
                                         if (lblNombre.Text == "Almacen")
                                                { 
                                            
                                                    Querry.sql_Update("ALMACENES", " Cuenta_contable =" + txtCuenta.Text + "", " ALMACEN='" + txtNo.Text + "' ");
                                         }
                                         this.Close();


        }

        private void FrmInsertar_Load(object sender, EventArgs e)
        {

        }
    }
}
