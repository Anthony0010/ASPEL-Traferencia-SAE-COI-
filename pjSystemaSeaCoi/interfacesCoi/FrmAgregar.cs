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
    public partial class FrmAgregar : Form
    {

        dataBase.Conexion Conexion = new dataBase.Conexion();
        SqlConnection conn;
        private String tipoDoc;


        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            cbTipoPoliza.Text = "Ventas";
            dtfinal.Value = DateTime.Now;
            dtInicial.Value = DateTime.Now;

        }

        private void VisibleObje()
        {

            ckclientes.Visible = true;
            ckVentas.Visible = true;
            ckMonedaTipodeCambios.Visible = true;
            ckVentasSevicio.Visible = true;
            cbAgrupamiento1.Visible = true;
            cbAgrupamiento2.Visible = true;
            lblSubArgumento.Visible = true;
            lblDesglose.Visible = true;
            lblArgumento.Visible = true;
            txtZona1.Visible = true; 

            txtNumerodeConCxc.Visible = false;
            dgRangos.Text = "Rango de documentos";
            dtDesde.Visible = true;
            dtHasta.Visible = true;
            lblDesde.Text = "Desde";

            ckIncluirCampos.Visible = true;
            lblZona.Text = "Zona";

            lblConceptos.Visible = false;
            cbConcepto.Visible = false;
            
            
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (cbTipoPoliza.Text == "Ventas")
            {


                tipoDoc = "F";
                tbControlinter.SelectTab(0);
                VisibleObje();
                tpFiltro.Text = "Filtro de Ventas";

                ckclientes.Checked = false;
                ckVentas.Checked = false;
                ckclientes.Text = "Clientes";
                ckVentas.Text = "Ventas";

                dgZona.Text = "Zona del Cliente";
                lblClasificaciones.Text = "Calificacion del Cliente";
                txtvendedor.Visible = true;
                lblVendedor.Visible = true;


                


          }
            if (cbTipoPoliza.Text == "Devolución de Ventas")
                 {


                     tipoDoc = "D";
                     tbControlinter.SelectTab(0);
                     VisibleObje();
                     tpFiltro.Text = "Filtro de Devolución por Ventas";

                     ckclientes.Checked = false;
                     ckVentas.Checked = false;
                     ckclientes.Text = "Clientes";
                     ckVentas.Text = "Devolución de Ventas";

                     dgZona.Text = "Zona del Cliente";
                     lblClasificaciones.Text = "Calificacion del Cliente";
                     txtvendedor.Visible = true;
                     lblVendedor.Visible = true;
            
            }
            if (cbTipoPoliza.Text == "Compras")
                             {

                                 tipoDoc = "R";                 
                tbControlinter.SelectTab(0);
                                 VisibleObje();
                                 tpFiltro.Text = "Filtro de Compras ";

                                 ckclientes.Checked = false;
                                 ckVentas.Checked = false;
                                 ckclientes.Text = "Proveedores";
                                 ckVentas.Text = "Inventario";


                                 dgZona.Text = "Zona del Proveedor";
                                 lblClasificaciones.Text = "Calificacion del Proveedor";
                                 txtvendedor.Visible = false;
                                 lblVendedor.Visible = false;
                                 txtClasificacion.Text = "?????";
            
            
            }
            if (cbTipoPoliza.Text == "Devolución de Compras y Gastos")
                                     {

                                         tipoDoc = "D";                        
                tbControlinter.SelectTab(0);
                                         VisibleObje();
                                         tpFiltro.Text = "Filtro de Devolución por Compras ";

                                         ckclientes.Checked = false;
                                         ckVentas.Checked = false;
                                         ckclientes.Text = "Proveedores";
                                         ckVentas.Text = "Devolución de Compras";

                                         dgZona.Text = "Zona del Proveedor";
                                         lblClasificaciones.Text = "Calificacion del Proveedor";
                                         txtvendedor.Visible = false;
                                         lblVendedor.Visible = false;
                                         txtClasificacion.Text = "?????";
            
            
            
            }
            if (cbTipoPoliza.Text == "Cuenta por Cobrar")
                             {

                                 tipoDoc = "C";
                                 tbControlinter.SelectTab(0);
                                 VisibleObje();
                                 tpFiltro.Text = "Filtro de Cuenta por Cobrar ";

                                 ckclientes.Checked = false;
                                 ckVentas.Checked = false;
                                 ckclientes.Text = "Clientes";
                                 ckVentas.Text = "Conceptos";
                                 cbAgrupamiento2.Visible = false;
                                 ckMonedaTipodeCambios.Visible = false;
                                 ckVentasSevicio.Visible = false;
                                 lblSubArgumento.Visible = false;

                                 lblDesde.Text = "Número de concepto de CxC";
                                 txtNumerodeConCxc.Visible = true;
                                 dgRangos.Text = "Número de concepto";
                
                                 dtDesde.Visible = false;
                                 dtHasta.Visible = false;
                                 lblHasta.Visible = false;
                                 lblVendedor.Visible = false;
                                 txtvendedor.Visible = false;
                                 ckIncluirCampos.Visible = false;
                                 txtClasificacion.Text = "?????";


                                   
            }
            if (cbTipoPoliza.Text == "Cuenta por Pagar")
                                         {

                                             tipoDoc = "C";
                                             tbControlinter.SelectTab(0);
                                             VisibleObje();
                                             tpFiltro.Text = "Filtro de Cuenta por Pagar ";

                                             ckclientes.Checked = false;
                                             ckVentas.Checked = false;
                                             ckclientes.Text = "Proveedores";
                                             ckVentas.Text = "Conceptos";
                                             cbAgrupamiento2.Visible = false;
                                             ckMonedaTipodeCambios.Visible = false;
                                             ckVentasSevicio.Visible = false;
                                             lblSubArgumento.Visible = false;

                                             lblDesde.Text = "Número de concepto de CxP";
                                             txtNumerodeConCxc.Visible = true;
                                             dgRangos.Text = "Número de concepto";
                                             dgZona.Text = "Zona del Proveedor";

                                             dtDesde.Visible = false;
                                             dtHasta.Visible = false;
                                             lblHasta.Visible = false;
                                             lblVendedor.Visible = false;
                                             txtvendedor.Visible = false;
                                             ckIncluirCampos.Visible = false;
                                             txtClasificacion.Text = "?????";
                                             lblClasificaciones.Text = "Calificacion del Proveedor";
            
            }
            if (cbTipoPoliza.Text == "Movimiento al Inventario")
                            {

                                tipoDoc = "";
                                tbControlinter.SelectTab(0);
                                VisibleObje();
                                tpFiltro.Text = "Filtro de Movimiento al Inventario";


                                ckclientes.Checked = false;
                                ckVentas.Visible = false;
                                ckclientes.Text = "Conceptos";
                                ckVentas.Visible = false;
                                cbAgrupamiento2.Visible = false;
                                ckMonedaTipodeCambios.Visible = false;
                                ckVentasSevicio.Visible = false;
                                lblSubArgumento.Visible = false;

                                lblZona.Text = "Almacen";
                                txtZona1.Visible = false;
                                dgZona.Text = "";
                                dgRangos.Text = "Rango de Producto";
                                ckIncluirCampos.Visible = false;

                                lblConceptos.Visible = true;
                                cbConcepto.Visible = true;
                                lblVendedor.Visible = false;
                                txtvendedor.Visible = false;
                                lblClasificaciones.Text = "Linea de Productos";

                    
            



            }
            if (cbTipoPoliza.Text == "Costo de Ventas")
                            {

                                tipoDoc = "";
                                tbControlinter.SelectTab(0);
                                VisibleObje();
                                tpFiltro.Text = "Filtro de Costo de Ventas";

                                ckclientes.Checked = false;
                                ckVentas.Checked = false;
                                ckclientes.Text = "Costo de Venta";
                                ckVentas.Text = "Almacén";
                                cbAgrupamiento2.Visible = false;
                                ckMonedaTipodeCambios.Visible = false;
                                ckVentasSevicio.Visible = false;
                                lblSubArgumento.Visible = false;

                                lblZona.Text = "Almacen";
                                txtZona1.Visible = false;
                                dgZona.Text = "";
                                dgRangos.Text = "Rango de Producto";
                                ckIncluirCampos.Visible = false;

                                lblConceptos.Visible = true;
                                cbConcepto.Visible = true;
                                lblVendedor.Visible = false;
                                txtvendedor.Visible = false;
                                lblClasificaciones.Text = "Linea de Productos";
            

            }
            if (cbTipoPoliza.Text == "Gastos y Servicios")
            {


                tipoDoc = "G";
                tbControlinter.SelectTab(0);
                VisibleObje();
                tpFiltro.Text = "Filtro de Compras ";

                ckclientes.Checked = false;
                ckVentas.Checked = false;
                ckclientes.Text = "Proveedores";
                ckVentas.Text = "Inventario";


                dgZona.Text = "Zona del Proveedor";
                lblClasificaciones.Text = "Calificacion del Proveedor";
                txtvendedor.Visible = false;
                lblVendedor.Visible = false;
                txtClasificacion.Text = "?????";
            
            
            }


            if (cbTipoPoliza.Text == "Reposición de caja Chica")
            {

                tipoDoc = "C";

                tbControlinter.SelectTab(0);
                VisibleObje();
                tpFiltro.Text = "Filtro de Compras ";

                ckclientes.Checked = false;
                ckVentas.Checked = false;
                ckclientes.Text = "Proveedores";
                ckVentas.Text = "Inventario";


                dgZona.Text = "Zona del Proveedor";
                lblClasificaciones.Text = "Calificacion del Proveedor";
                txtvendedor.Visible = false;
                lblVendedor.Visible = false;
                txtClasificacion.Text = "?????";


            }
            ////if (cbTipoPoliza.Text == "Devolución de Gastos")
            ////{

            ////    tipoDoc = "";
            ////    tbControlinter.SelectTab(0);
            ////    VisibleObje();
            ////    tpFiltro.Text = "Filtro de Devolución por Compras ";

            ////    ckclientes.Checked = false;
            ////    ckVentas.Checked = false;
            ////    ckclientes.Text = "Proveedores";
            ////    ckVentas.Text = "Devolución de Compras";

            ////    dgZona.Text = "Zona del Proveedor";
            ////    lblClasificaciones.Text = "Calificacion del Proveedor";
            ////    txtvendedor.Visible = false;
            ////    lblVendedor.Visible = false;
            ////    txtClasificacion.Text = "?????";
            
            
            ////}
        }

        private void dtfinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtfinal.Value.Month != dtInicial.Value.Month || dtfinal.Value.Year != dtInicial.Value.Year)
            {
                dtfinal.Value = dtInicial.Value;
                //MessageBox.Show("El rango de fechas debe estar dentro del mismo mes"); 
            }
        }

        private void FrmAgregar_Leave(object sender, EventArgs e)
        {

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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;
                frm.dgCuentas.DataSource = dset.Tables[0];
                frm.ShowDialog();

            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                try
                {

                    Conexion.buscarAch();
                    conn = new SqlConnection(Conexion.Cadena);
                    conn.Open();
                    SqlCommand comando = new SqlCommand("alter table repcuentas add  deptoid  varchar(20)", conn);
                    comando.ExecuteNonQuery();
                    conn.Close();



                }
                catch (SqlException ext)
                {
                    MessageBox.Show(ext.Message);


                }

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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;
                frm.dgCuentas.DataSource = dset.Tables[0];

                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;
                frm.dgCuentas.DataSource = dset.Tables[0];

                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;

                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
                frm.dgCuentas.DataSource = dset.Tables[0];
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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;
                frm.dgCuentas.DataSource = dset.Tables[0];

                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                CuentasDigito();
                frm.dtFechaInical.Value = dtInicial.Value;
                frm.dgCuentas.DataSource = dset.Tables[0];
                    
                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;
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
                FrmPoliza frm = new FrmPoliza();
                frm.lblEmpresa.Text = lblEmpresa.Text;
                frm.dgPoliza.DataSource = ds.Tables[0];
                frm.dtFecha.Value = dtfinal.Value;
                
                CuentasDigito2();
                frm.dtFechaInical.Value = dtInicial.Value;

                frm.lblTipoDoc.Text = tipoDoc;
                frm.lblTitulo.Text = cbTipoPoliza.Text;

                frm.dgCuentas.DataSource = dset.Tables[0];
                frm.ShowDialog();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private DataSet dset;

        private DataSet CuentasDigito()

        {
            FrmMainMenu frm = new FrmMainMenu();

            try {

                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlDataAdapter comando2 = new SqlDataAdapter(@"select NUM_CTA as [Cuenta] from "+frm.dataBase+".dbo.repcuentas A,coiwin.dbo.CUENTAS1701 B where REPLACE(A.cuentas,'-','')=SUBSTRING(B.num_cta,0,13) order by num_cta ", conn);

                dset = new DataSet();
                comando2.Fill(dset);

            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            return dset;
        
        }

        private DataSet CuentasDigito2()
        {
            FrmMainMenu frm = new FrmMainMenu();

            try
            {

                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlDataAdapter comando2 = new SqlDataAdapter(@"select num_cta as [Cuenta] from " + frm.dataBase + ".dbo.polizas_Modelos A,coiwin.dbo.CUENTAS1701 B where REPLACE(A.CUENTA_CONTA,'-','')=SUBSTRING(B.num_cta,0,13) order by num_cta ", conn);

                dset = new DataSet();
                comando2.Fill(dset);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dset;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                string fecha1 ="", fecha2 ="",descripcion ="";
                Conexion.buscarAch();
                conn = new SqlConnection(Conexion.Cadena);
                conn.Open();
                SqlCommand comando = new SqlCommand(@"select no_poliza,descripcion,fechaIN, fechaFN  from polizaGenerada where  status_p !='C' and descripcion='"+cbTipoPoliza.Text+"'  and no_poliza =(select  MAX(Convert(int,no_poliza)) from polizaGenerada where tip_doc ='"+tipoDoc+"' and status_p !='C')", conn);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read() == true)
                {
                    fecha1= leer["fechaIN"].ToString();
                    fecha2 = leer["fechaFN"].ToString();
                    descripcion = leer["descripcion"].ToString();

                   
                    conn.Close();
                    //if (DateTime.Parse(fecha1).Day >= dtInicial.Value.Day  || dtfinal.Value.Day <= DateTime.Parse(fecha2).Day)
                    //{
                    //    MessageBox.Show(" ");
                    //} else
                    //if (dtInicial.Value.Day > DateTime.Parse(fecha2).Day && dtfinal.Value.Day > DateTime.Parse(fecha2).Day && dtInicial.Value.Month > DateTime.Parse(fecha2).Month || dtInicial.Value.Year > DateTime.Parse(fecha2).Year )
                    //    {
                    //        aceptar();

                    //    }
                    //    else { MessageBox.Show("Tipo de poliza generada para este rango de fecha"); }

                    if (dtInicial.Value.Year == DateTime.Parse(fecha2).Year)
                    {
                        if (dtInicial.Value.Month == DateTime.Parse(fecha2).Month && dtfinal.Value.Month == DateTime.Parse(fecha1).Month)
                        {
                            if (dtInicial.Value.Day > DateTime.Parse(fecha2).Day && dtfinal.Value.Day > DateTime.Parse(fecha2).Day)
                            {

                                aceptar();
                            }
                            else
                            {
                                MessageBox.Show("Tipo de poliza generada para este rango de fecha");
                            }


                        }
                        else
                        {

                            if (dtfinal.Value.Day >= dtInicial.Value.Day)
                            {

                                aceptar();
                            }
                            else
                            {
                                MessageBox.Show("la fecha Fianal tiene que ser mayor o igual a la fecha inicial");

                            }


                        }


                    }
                    else
                    {
                        aceptar();
                    
                    }
                  
                }
                else
                {
                    conn.Close();
                    aceptar();

                }
            }
                

                            

                        catch(SqlException ex)
                        {

                            MessageBox.Show(ex.Message);

                        }

        }

        private void aceptar()
        { 
        if (cbTipoPoliza.Text == "Ventas")
                                {

                                    procedimientoVentas(dtInicial.Text, dtfinal.Text);


                                }
                                else if (cbTipoPoliza.Text == "Devolución de Ventas")
                                {
                                    procedimientoVentasDevolucio(dtInicial.Text, dtfinal.Text);
                                }
                                else if (cbTipoPoliza.Text == "Compras")
                                {
                                    procedimientoCompra(dtInicial.Text, dtfinal.Text);
                                }
                                else if (cbTipoPoliza.Text == "Devolución de Compras y Gastos")
                                {
                                    procedimientoCompraDevolucion(dtInicial.Text, dtfinal.Text);
                                }
                                else if (cbTipoPoliza.Text == "Gastos y Servicios")
                                {
                                    procedimientoGastos(dtInicial.Text, dtfinal.Text);
                                }
                                else if (cbTipoPoliza.Text == "Reposición de caja Chica")
                                {
                                    procedimientoCajaChica(dtInicial.Text, dtfinal.Text);
                                }
                                else if (cbTipoPoliza.Text == "Cuenta por Cobrar")
                                {
                                    procedimitoCxC(dtInicial.Text, dtfinal.Text);

                                }
                                else if (cbTipoPoliza.Text == "Cuenta por Pagar")
                                { }
                                else if (cbTipoPoliza.Text == "Movimiento al Inventario")
                                { }
                                else if (cbTipoPoliza.Text == "Costo de Ventas")
                                { }
                                else { MessageBox.Show("El tipo de Poliza no esta bien especificado "); cbTipoPoliza.Select(); }

                            }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {

            if (dtInicial.Value.Month != dtfinal.Value.Month || dtInicial.Value.Year != dtfinal.Value.Year)
            {
                dtfinal.Value = dtInicial.Value;
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
    }
        
        
        }
    

