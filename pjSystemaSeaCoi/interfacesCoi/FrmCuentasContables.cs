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
    public partial class FrmCuentasContables : Form
    {

        dataBase.Conexion Conexion = new dataBase.Conexion();
        SqlConnection conn;
        private SqlDataAdapter adpater;
        private DataSet ds;
        private int index;
        FrmInsertar frmInsert;

        public FrmCuentasContables()
        {
            InitializeComponent();
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

           
        }

        private void FrmCuentasContables_Load(object sender, EventArgs e)
        {
            generales();
            zona();
            clientes();
            proveedor();
            almacenes();
            cuentaPorCobrar();
            cuentaPorPagar();
            movimientoAlmacen();
            lineas();
            inventario();
            
            
        }


        public void generales()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select TIPO as [No.],DESC_CUENTA as[Descripción],CUENTAS as [Cuentas Contables] from CUENTAS_CONTABLES", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgGeneral.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CUENTAS_CONTABLES add CUENTAS varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();
                
                
                
                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);
                
                
                }
            }


        }



        
        public void zona()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select CVE_ZONA as [No.], DESC_CUENTA as[Descripción], CTA_CONT as [Cuentas Contables] from ZONA01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgZonas.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("create table ZONA01( CVE_ZONA VARCHAR(20),DESC_CUENTA VARCHAR(20),CTA_CONT VARCHAR(20))", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }


        public void clientes()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();               
                adpater = new SqlDataAdapter("select   NUM_REG as [No.], NOMBRE as[Descripción], CUENTA_CONTABLE as [Cuentas Contables] from CLIE01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgClientes.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);


                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CLIE01 add CUENTA_CONTABLE varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }

        public void proveedor()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select   NUM_REG as [No.], NOMBRE as[Descripción], CUENTA_CONTABLE as [Cuentas Contables] from PROV01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgProveedores.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table PROV01 add CUENTA_CONTABLE varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }

               
            }


        }

        public void almacenes()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();             
                adpater = new SqlDataAdapter("select ALMACEN as [No.], DESC_ALMACEN as[Descripción], Cuenta_contable as [Cuentas Contables] from ALMACENES", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgAlmacen.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table ALMACENES add  Cuenta_contable varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }

        public void cuentaPorCobrar()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select NUM_CPTO as [No.],DESCR as[Descripción],CUEN_CONT as [Cuentas Contables] from CONC01", conn);
                ds = new DataSet();
                adpater.Fill(ds);
                               
                dgCxC.DataSource = ds.Tables[0];
                 

            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CONC01 add  CUEN_CONT varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }
        
        
        }
        public void movimientoAlmacen()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select NUM_REG as [No.],DESCR as[Descripción],CUEN_CONT as [Cuentas Contables] from CONM01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgMovimientoInventario.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CONM01 add  CUEN_CONT varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }


        public void cuentaPorPagar()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select NUM_REG as [No.] , DESCR as[Descripción],CUEN_CONT as [Cuentas Contables] from CONP01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgCxp.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CONP01 add  CUEN_CONT varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }
        public void lineas()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();                
                adpater = new SqlDataAdapter("select NUM_REG as [No.] , DESC_LIN as[Descripción],CUENTA_COI as [Cuentas Contables] from CLIN01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgLineas.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table CLIN01 add  CUENTA_COI  varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }
        public void inventario()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                adpater = new SqlDataAdapter("select NUM_REG as [No.] , DESCR as[Descripción], CUENTA_CONTABLE as [Cuentas Contables] from INVE01", conn);
                ds = new DataSet();
                adpater.Fill(ds);

                dgInventario.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);


                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table INVE01 add  CUENTA_CONTABLE  varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }


        }



        private void dgCxC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = dgCxC.CurrentRow.Index;
                frmInsert = new FrmInsertar(Int32.Parse(dgCxC[0, index].Value.ToString()), dgCxC[1, index].Value.ToString(), dgCxC[2, index].Value.ToString(), tpCxC.Text);
                frmInsert.ShowDialog();
                cuentaPorCobrar();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
        }

        private void dgGeneral_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

            index = dgGeneral.CurrentRow.Index;
            frmInsert = new FrmInsertar(dgGeneral[0, index].Value.ToString(), dgGeneral[1, index].Value.ToString(), dgGeneral[2, index].Value.ToString(), tpGeneales.Text);
            frmInsert.ShowDialog();
            generales();
            
                

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla "+ ex.Message);
            }

        }

        private void dgZonas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgZonas.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgZonas[0, index].Value.ToString()), dgZonas[1, index].Value.ToString(), dgZonas[2, index].Value.ToString(), tpZona.Text);
            frmInsert.ShowDialog();
            zona();
          
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla "+ ex.Message);
            }
        }

        private void dgCpxp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgCxp.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgCxp[0, index].Value.ToString()), dgCxp[1, index].Value.ToString(), dgCxp[2, index].Value.ToString(), tpCxp.Text);
            frmInsert.ShowDialog();
            cuentaPorPagar();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
        }

      

        private void dgMovimientoInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         try
         {
            index = dgMovimientoInventario.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgMovimientoInventario[0, index].Value.ToString()), dgMovimientoInventario[1, index].Value.ToString(), dgMovimientoInventario[2, index].Value.ToString(), tpMovimientoAlinventario.Text);
            frmInsert.ShowDialog();
            movimientoAlmacen();
         }
         catch (NullReferenceException ex)
         {
             MessageBox.Show("No hay datos en esta tabla " + ex.Message);
         }
        }

        private void dgLineas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgLineas.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgLineas[0, index].Value.ToString()), dgLineas[1, index].Value.ToString(), dgLineas[2, index].Value.ToString(), tpLineas.Text);
            frmInsert.ShowDialog();
            lineas();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
        }

        private void dgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgClientes.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgClientes[0, index].Value.ToString()), dgClientes[1, index].Value.ToString(), dgClientes[2, index].Value.ToString(), tpClientes.Text);
            frmInsert.ShowDialog();
            clientes();
            
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
    
        }

        private void dgProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgProveedores.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgProveedores[0, index].Value.ToString()), dgProveedores[1, index].Value.ToString(), dgProveedores[2, index].Value.ToString(), tpProveedores.Text);
            frmInsert.ShowDialog();
            proveedor();
         
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
        }

        private void dgInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         try 
         {
            index = dgInventario.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgInventario[0, index].Value.ToString()), dgInventario[1, index].Value.ToString(), dgInventario[2, index].Value.ToString(), tpInventario.Text);
            frmInsert.ShowDialog();
            inventario();
         }
         catch (NullReferenceException ex)
         {
             MessageBox.Show("No hay datos en esta tabla " + ex.Message);
         }
        }

        private void dgAlmacen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            index = dgAlmacen.CurrentRow.Index;
            frmInsert = new FrmInsertar(Int32.Parse(dgAlmacen[0, index].Value.ToString()), dgAlmacen[1, index].Value.ToString(), dgAlmacen[2, index].Value.ToString(), tpAlmacen.Text);
            frmInsert.ShowDialog();
            almacenes();
            
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay datos en esta tabla " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

   
    }
}
