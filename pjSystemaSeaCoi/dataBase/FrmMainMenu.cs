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

namespace pjSystemaSeaCoi.interfacesCoi
{
    public partial class FrmMainMenu : Form
    {

        dataBase.Conexion Conexion = new dataBase.Conexion();
        dataBase.ConexionEmP ConexionEmp = new dataBase.ConexionEmP();
        SqlConnection conn;

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbEmpresa.Text == string.Empty)
            {
                MessageBox.Show("Debe elegir una empresa");
                cbEmpresa.Select();
            
            }
            else
            {
                interfacesCoi.FrmAgregar frm = new FrmAgregar();
                frm.lblEmpresa.Text = cbEmpresa.Text;
                frm.ShowDialog();
            }
        }

       

             private void procedimientoVentas(string fechaInicial, string fechafina)
                {  
            try
            {

                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("EXEC  Polirep_spdetalleVentas '" + fechaInicial + "','" + fechafina + "','F'", conn);
                comando.ExecuteNonQuery();
                conn.Close();

                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas order by cuentas ", conn);

                DataSet ds = new DataSet();
                comando2.Fill(ds);
                frmPolizaConsulta frm = new frmPolizaConsulta();
                frm.dgPoliza.DataSource=ds.Tables[0];
                frm.txtConcepto.Text = concepto;
                frm.cbTipo.Text =tipo_poliza;
                frm.txtNoFolio.Text = numeroPoliza;
                frm.ShowDialog();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


             private void procedimientoVentasDevolucio(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand("EXEC   Polirep_spdetalleD '" + fechaInicial + "','" + fechafina + "','D'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas  order by cuentas ", conn);


                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();

                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }
             private void procedimientoCompra(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand(@"EXEC  Polirep_spdetalle '" + fechaInicial + "','" + fechafina + "','R'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas order by cuentas ", conn);

                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();
                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }

             private void procedimientoCompraDevolucion(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand(@"EXEC  Polirep_spdetalle '" + fechaInicial + "','" + fechafina + "','D'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas order by cuentas ", conn);

                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();

                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }

             private void procedimientoGastos(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand(@"EXEC  Polirep_spdetalle '" + fechaInicial + "','" + fechafina + "','G'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas order by cuentas ", conn);

                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();
                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }


             private void procedimientoCajaChica(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand(@"EXEC  Polirep_spdetalle '" + fechaInicial + "','" + fechafina + "','C'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select cuentas as [No.Cuenta],deptoid as [Departamento], descr as [Descripción],debito as [Debito],credito as[Credito] from repcuentas order by cuentas ", conn);

                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();

                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }

             private void procedimitoCxC(string fechaInicial, string fechafina)
             {

                 try
                 {

                     Conexion.buscarAch();
                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand(@"EXEC  sp_polizasmodelocxc '" + fechaInicial + "','" + fechafina + "'", conn);
                     comando.ExecuteNonQuery();
                     conn.Close();

                     conn = new SqlConnection(Conexion.Cadena);
                     conn.Open();
                     SqlDataAdapter comando2 = new SqlDataAdapter(@"select CUENTA_CONTA as [No.Cuenta],deptoid as [Departamento], DESCRIPCION as [Descripción],IMPORTE  as [Debito],credito as[Credito] from  polizas_Modelos order by  CUENTA_CONTA ", conn);

                     DataSet ds = new DataSet();
                     comando2.Fill(ds);
                     frmPolizaConsulta frm = new frmPolizaConsulta();
                     frm.dgPoliza.DataSource = ds.Tables[0];
                     frm.txtConcepto.Text = concepto;
                     frm.cbTipo.Text = tipo_poliza;
                     frm.txtNoFolio.Text = numeroPoliza;

                     frm.ShowDialog();

                 }
                 catch (SqlException ex)
                 {
                     MessageBox.Show(ex.Message);

                 }
             }

        


             public void cargarCombo()
             {
                 try
                 {
                     ConexionEmp.buscarAch();
                     conn = new SqlConnection(ConexionEmp.Cadena);
                     conn.Open();
                     SqlCommand comando = new SqlCommand("select empresa from EmpresaConexion", conn);
                     SqlDataReader leer = comando.ExecuteReader();

                     if (leer.Read() == true)

                     {
                         cbEmpresa.Items.Add(leer["empresa"].ToString());
                         while (leer.Read())
                         {
                             cbEmpresa.Items.Add(leer["empresa"].ToString());
                         }
                         conn.Close();
                     }
                 }
                 catch (SqlException ex)
                 { 
                 
                 }


             }
        

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (tipo_poliza == null || numeroPoliza == null || fechaIN ==null || fechaFN == null)
            {
                MessageBox.Show("Seleciona un registro de la lista");
            
            }
            else
            {
                FrmUsuarios frm = new FrmUsuarios(tipo_poliza, numeroPoliza, fechaIN, fechaFN);
                frm.ShowDialog();
            }

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            dgPolizaPrincipal.AllowUserToAddRows = false;
            dgPolizaPrincipal.ReadOnly = true;
            cargarCombo();
            

        }

        private void cargar()
        {

            try
            {
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlDataAdapter comando = new SqlDataAdapter("select tip_doc as Documento,descripcion as [Descripcion],tipo_pliza as [Tipo de Poliza],no_poliza as [No. Poliza],status_p as [Estatus],fechaIN as [Fecha Inicial],fechaFN as [Fecha Final] from polizaGenerada", conn);

                DataSet ds = new DataSet();
                comando.Fill(ds);

                dgPolizaPrincipal.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {

                //MessageBox.Show(ex.Message);

                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand(@"CREATE TABLE [dbo].[polizaGenerada](
    [tipo_pliza] [varchar](2) NULL,
    [status_p] [varchar](1) NULL,
    [fechaIN] [date] NULL,
    [fechaFN] [date] NULL,
    [no_poliza] [varchar](5) NULL,
    [tip_doc] [varchar](1) NULL,
    [descripcion] [varchar](120) NULL)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }
            }
            catch (InvalidOperationException ex) { }
        
        
        
}


        private void cargarConsuta(string fechaONe , string fechaTwo)
        {

            try
            {
                dgPolizaPrincipal.DataSource = "";
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlDataAdapter comando = new SqlDataAdapter("select tip_doc as Documento,descripcion as [Descripcion],tipo_pliza as [Tipo de Poliza],no_poliza as [No. Poliza],status_p as [Estatus],fechaIN as [Fecha Inicial],fechaFN as [Fecha Final] from polizaGenerada where fechaIN between '" + fechaONe + "' and  '" + fechaTwo + "'", conn);

                DataSet ds = new DataSet();
                comando.Fill(ds);

                dgPolizaPrincipal.DataSource = ds.Tables[0];


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex) { }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCuentasContables frm = new FrmCuentasContables();
            frm.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        int index;
        String fechaIN, fechaFN,tipo_poliza,numeroPoliza,concepto;
        private void dgPolizaPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgPolizaPrincipal.CurrentRow.Index;
            fechaIN = DateTime.Parse(dgPolizaPrincipal[5,index].Value.ToString()).ToString("MM/dd/yyyy");
            fechaFN = DateTime.Parse(dgPolizaPrincipal[6, index].Value.ToString()).ToString("MM/dd/yyyy");
            tipo_poliza = dgPolizaPrincipal[2, index].Value.ToString();
            numeroPoliza = dgPolizaPrincipal[3, index].Value.ToString();
            concepto = dgPolizaPrincipal[1, index].Value.ToString() +" Desde :"+ fechaIN + " Hasta :"+fechaFN;


        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVerModulo_Click(object sender, EventArgs e)
        {
           
            
            if (dgPolizaPrincipal[1, index].Value.ToString() == "Ventas")
            {
                procedimientoVentas(fechaIN,fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Devolución de Ventas")
            {
                procedimientoVentasDevolucio(fechaIN,fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Compras")
            {

                procedimientoCompra(fechaIN,fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Devolución de Compras y Gastos")
            {

                procedimientoCompraDevolucion(fechaIN, fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Gastos y Servicios")
            {

                procedimientoGastos(fechaIN, fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Reposición de caja Chica")
            {

                procedimientoCajaChica(fechaIN, fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Cuenta por Cobrar")
            {
                procedimitoCxC(fechaIN, fechaFN);
                fechaIN = null;
                fechaFN = null;
            
            }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Cuenta por Pagar")
            { }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Movimiento al Inventario")
            { }
            else if (dgPolizaPrincipal[1, index].Value.ToString() == "Costo de Ventas")
            { }
           
           
        }

      

       
        public string dataBase;
        private void cbEmpresa_DropDownClosed(object sender, EventArgs e)
        {

            try
            {
                ConexionEmp.buscarAch();
                conn = new SqlConnection(ConexionEmp.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand("select dabaDatos, servidor ,usuario , clave  from EmpresaConexion where empresa ='" + cbEmpresa.Text + "' ", conn);
                SqlDataReader leer = comando.ExecuteReader();


                if (leer.Read() == true)
                {
                    if (File.Exists(@"C:\conexion\SQLconn.txt"))
                    {
                        File.Delete(@"C:\conexion\SQLconn.txt");
                        dataBase = leer["dabaDatos"].ToString();
                        dgPolizaPrincipal.DataSource = "";
                        StreamWriter escribir = new StreamWriter(@"C:\conexion\SQLconn.txt");
                        escribir.WriteLine("Cadena de conexion");
                        escribir.WriteLine("Data Source=" + leer["servidor"].ToString() + ";Initial Catalog=" + leer["dabaDatos"].ToString() + "; User ID=" + leer["usuario"].ToString() + "; password=" + leer["clave"].ToString() + "");
                        escribir.Close();


                        conn.Close();
                        //cargar();
                    }
                    else
                    {
                       
                        dataBase = leer["dabaDatos"].ToString();
                        dgPolizaPrincipal.DataSource = "";
                        StreamWriter escribir = new StreamWriter(@"C:\conexion\SQLconn.txt");
                        escribir.WriteLine("Cadena de conexion");
                        escribir.WriteLine("Data Source=" + leer["servidor"].ToString() + ";Initial Catalog=" + leer["dabaDatos"].ToString() + "; User ID=" + leer["usuario"].ToString() + "; password=" + leer["clave"].ToString() + "");
                        escribir.Close();


                        conn.Close();
                    
                    }



                }
                else
                {
                    MessageBox.Show("La empresa no exite");

                    cbEmpresa.Items.Clear();
                    cargarCombo();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                this.Refresh();
            
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos frm = new frmBaseDeDatos();
            frm.Registrar();
            frm.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos frm = new frmBaseDeDatos();
            frm.Actualizar();
            frm.ShowDialog();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtFinal.Value.Month != dtInicial.Value.Month || dtFinal.Value.Year != dtInicial.Value.Year)
            {
                dtFinal.Value = dtInicial.Value;
                MessageBox.Show("El rango de fechas debe estar dentro del mismo mes");
            }
            else
            {
                cargarConsuta(dtInicial.Text, dtFinal.Text);
            }
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            cargarConsuta(dtInicial.Text, dtFinal.Text);
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dtInicial.Value.Month != dtFinal.Value.Month || dtInicial.Value.Year != dtFinal.Value.Year)
            {
                dtFinal.Value = dtInicial.Value;

            }
        }

       

       


       

       
    }
}
