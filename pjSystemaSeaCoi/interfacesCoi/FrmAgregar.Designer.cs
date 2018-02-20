namespace pjSystemaSeaCoi.interfacesCoi
{
    partial class FrmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbTipoPoliza = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbControlinter = new System.Windows.Forms.TabControl();
            this.tpFiltro = new System.Windows.Forms.TabPage();
            this.ckIncluirCampos = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.lblConceptos = new System.Windows.Forms.Label();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.lblClasificaciones = new System.Windows.Forms.Label();
            this.dgRangos = new System.Windows.Forms.GroupBox();
            this.txtNumerodeConCxc = new System.Windows.Forms.TextBox();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgZona = new System.Windows.Forms.GroupBox();
            this.txtZona2 = new System.Windows.Forms.TextBox();
            this.txtZona1 = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tpArgumentoDesglose = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbAgrupamiento2 = new System.Windows.Forms.ComboBox();
            this.cbAgrupamiento1 = new System.Windows.Forms.ComboBox();
            this.ckVentasSevicio = new System.Windows.Forms.CheckBox();
            this.ckMonedaTipodeCambios = new System.Windows.Forms.CheckBox();
            this.ckVentas = new System.Windows.Forms.CheckBox();
            this.ckclientes = new System.Windows.Forms.CheckBox();
            this.lblSubArgumento = new System.Windows.Forms.Label();
            this.lblArgumento = new System.Windows.Forms.Label();
            this.lblDesglose = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbControlinter.SuspendLayout();
            this.tpFiltro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.dgRangos.SuspendLayout();
            this.dgZona.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpArgumentoDesglose.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Poliza ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Periodo Aspel-COI";
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto de la Poliza";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 53);
            this.textBox1.TabIndex = 0;
            // 
            // cbTipoPoliza
            // 
            this.cbTipoPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPoliza.FormattingEnabled = true;
            this.cbTipoPoliza.Items.AddRange(new object[] {
            "Ventas",
            "Devolución de Ventas",
            "Compras",
            "Devolución de Compras y Gastos",
            "Gastos y Servicios",
            "Reposición de caja Chica",
            "Cuenta por Cobrar",
            "Cuenta por Pagar",
            "Movimiento al Inventario",
            "Costo de Ventas"});
            this.cbTipoPoliza.Location = new System.Drawing.Point(163, 22);
            this.cbTipoPoliza.Name = "cbTipoPoliza";
            this.cbTipoPoliza.Size = new System.Drawing.Size(180, 21);
            this.cbTipoPoliza.TabIndex = 5;
            this.cbTipoPoliza.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // tbControlinter
            // 
            this.tbControlinter.Controls.Add(this.tpFiltro);
            this.tbControlinter.Controls.Add(this.tpArgumentoDesglose);
            this.tbControlinter.Location = new System.Drawing.Point(18, 193);
            this.tbControlinter.Name = "tbControlinter";
            this.tbControlinter.SelectedIndex = 0;
            this.tbControlinter.Size = new System.Drawing.Size(479, 267);
            this.tbControlinter.TabIndex = 7;
            // 
            // tpFiltro
            // 
            this.tpFiltro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpFiltro.Controls.Add(this.ckIncluirCampos);
            this.tpFiltro.Controls.Add(this.groupBox5);
            this.tpFiltro.Controls.Add(this.dgRangos);
            this.tpFiltro.Controls.Add(this.dgZona);
            this.tpFiltro.Controls.Add(this.groupBox2);
            this.tpFiltro.Location = new System.Drawing.Point(4, 22);
            this.tpFiltro.Name = "tpFiltro";
            this.tpFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltro.Size = new System.Drawing.Size(471, 241);
            this.tpFiltro.TabIndex = 0;
            this.tpFiltro.Text = "Filtro de Ventas";
            // 
            // ckIncluirCampos
            // 
            this.ckIncluirCampos.AutoSize = true;
            this.ckIncluirCampos.Location = new System.Drawing.Point(10, 215);
            this.ckIncluirCampos.Name = "ckIncluirCampos";
            this.ckIncluirCampos.Size = new System.Drawing.Size(258, 17);
            this.ckIncluirCampos.TabIndex = 3;
            this.ckIncluirCampos.Text = "Incluir campos CFDI\'s en contabilidad electronica";
            this.ckIncluirCampos.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbConcepto);
            this.groupBox5.Controls.Add(this.lblConceptos);
            this.groupBox5.Controls.Add(this.txtvendedor);
            this.groupBox5.Controls.Add(this.lblVendedor);
            this.groupBox5.Controls.Add(this.txtClasificacion);
            this.groupBox5.Controls.Add(this.lblClasificaciones);
            this.groupBox5.Location = new System.Drawing.Point(5, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 68);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(136, 37);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(317, 21);
            this.cbConcepto.TabIndex = 10;
            // 
            // lblConceptos
            // 
            this.lblConceptos.AutoSize = true;
            this.lblConceptos.Location = new System.Drawing.Point(12, 42);
            this.lblConceptos.Name = "lblConceptos";
            this.lblConceptos.Size = new System.Drawing.Size(61, 13);
            this.lblConceptos.TabIndex = 17;
            this.lblConceptos.Text = "Conceptos ";
            // 
            // txtvendedor
            // 
            this.txtvendedor.Location = new System.Drawing.Point(309, 13);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(144, 20);
            this.txtvendedor.TabIndex = 16;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(250, 18);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 15;
            this.lblVendedor.Text = "Vendedor";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(136, 14);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(107, 20);
            this.txtClasificacion.TabIndex = 14;
            // 
            // lblClasificaciones
            // 
            this.lblClasificaciones.AutoSize = true;
            this.lblClasificaciones.Location = new System.Drawing.Point(8, 18);
            this.lblClasificaciones.Name = "lblClasificaciones";
            this.lblClasificaciones.Size = new System.Drawing.Size(113, 13);
            this.lblClasificaciones.TabIndex = 14;
            this.lblClasificaciones.Text = "Calificacion del Cliente";
            // 
            // dgRangos
            // 
            this.dgRangos.Controls.Add(this.txtNumerodeConCxc);
            this.dgRangos.Controls.Add(this.dtHasta);
            this.dgRangos.Controls.Add(this.dtDesde);
            this.dgRangos.Controls.Add(this.lblHasta);
            this.dgRangos.Controls.Add(this.lblDesde);
            this.dgRangos.Location = new System.Drawing.Point(6, 85);
            this.dgRangos.Name = "dgRangos";
            this.dgRangos.Size = new System.Drawing.Size(259, 50);
            this.dgRangos.TabIndex = 2;
            this.dgRangos.TabStop = false;
            this.dgRangos.Text = "Rango de documentos";
            // 
            // txtNumerodeConCxc
            // 
            this.txtNumerodeConCxc.Location = new System.Drawing.Point(158, 23);
            this.txtNumerodeConCxc.Name = "txtNumerodeConCxc";
            this.txtNumerodeConCxc.Size = new System.Drawing.Size(84, 20);
            this.txtNumerodeConCxc.TabIndex = 17;
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHasta.Location = new System.Drawing.Point(171, 23);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(82, 20);
            this.dtHasta.TabIndex = 10;
            this.dtHasta.Value = new System.DateTime(2017, 4, 5, 0, 0, 0, 0);
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesde.Location = new System.Drawing.Point(42, 24);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(82, 20);
            this.dtDesde.TabIndex = 11;
            this.dtDesde.Value = new System.DateTime(2017, 4, 5, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(130, 26);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(5, 26);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 11;
            this.lblDesde.Text = "Desde";
            // 
            // dgZona
            // 
            this.dgZona.Controls.Add(this.txtZona2);
            this.dgZona.Controls.Add(this.txtZona1);
            this.dgZona.Controls.Add(this.lblZona);
            this.dgZona.Location = new System.Drawing.Point(271, 85);
            this.dgZona.Name = "dgZona";
            this.dgZona.Size = new System.Drawing.Size(194, 50);
            this.dgZona.TabIndex = 1;
            this.dgZona.TabStop = false;
            this.dgZona.Text = "Zona del Cliente";
            // 
            // txtZona2
            // 
            this.txtZona2.Location = new System.Drawing.Point(104, 23);
            this.txtZona2.Name = "txtZona2";
            this.txtZona2.Size = new System.Drawing.Size(84, 20);
            this.txtZona2.TabIndex = 15;
            // 
            // txtZona1
            // 
            this.txtZona1.Location = new System.Drawing.Point(39, 23);
            this.txtZona1.Name = "txtZona1";
            this.txtZona1.Size = new System.Drawing.Size(59, 20);
            this.txtZona1.TabIndex = 14;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(6, 26);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(32, 13);
            this.lblZona.TabIndex = 14;
            this.lblZona.Text = "Zona";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtfinal);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de fecha del documento";
            // 
            // dtfinal
            // 
            this.dtfinal.CustomFormat = "MM/dd/yyyy";
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfinal.Location = new System.Drawing.Point(323, 47);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(119, 20);
            this.dtfinal.TabIndex = 8;
            this.dtfinal.Value = new System.DateTime(2017, 4, 5, 0, 0, 0, 0);
            this.dtfinal.ValueChanged += new System.EventHandler(this.dtfinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.CustomFormat = "MM/dd/yyyy";
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicial.Location = new System.Drawing.Point(85, 45);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(124, 20);
            this.dtInicial.TabIndex = 9;
            this.dtInicial.Value = new System.DateTime(2017, 4, 5, 0, 0, 0, 0);
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // tpArgumentoDesglose
            // 
            this.tpArgumentoDesglose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpArgumentoDesglose.Controls.Add(this.groupBox6);
            this.tpArgumentoDesglose.Location = new System.Drawing.Point(4, 22);
            this.tpArgumentoDesglose.Name = "tpArgumentoDesglose";
            this.tpArgumentoDesglose.Padding = new System.Windows.Forms.Padding(3);
            this.tpArgumentoDesglose.Size = new System.Drawing.Size(471, 241);
            this.tpArgumentoDesglose.TabIndex = 1;
            this.tpArgumentoDesglose.Text = "Agrupamiento y Desglose";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbAgrupamiento2);
            this.groupBox6.Controls.Add(this.cbAgrupamiento1);
            this.groupBox6.Controls.Add(this.ckVentasSevicio);
            this.groupBox6.Controls.Add(this.ckMonedaTipodeCambios);
            this.groupBox6.Controls.Add(this.ckVentas);
            this.groupBox6.Controls.Add(this.ckclientes);
            this.groupBox6.Controls.Add(this.lblSubArgumento);
            this.groupBox6.Controls.Add(this.lblArgumento);
            this.groupBox6.Controls.Add(this.lblDesglose);
            this.groupBox6.Controls.Add(this.shapeContainer1);
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(459, 198);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // cbAgrupamiento2
            // 
            this.cbAgrupamiento2.FormattingEnabled = true;
            this.cbAgrupamiento2.Location = new System.Drawing.Point(157, 102);
            this.cbAgrupamiento2.Name = "cbAgrupamiento2";
            this.cbAgrupamiento2.Size = new System.Drawing.Size(117, 21);
            this.cbAgrupamiento2.TabIndex = 11;
            // 
            // cbAgrupamiento1
            // 
            this.cbAgrupamiento1.FormattingEnabled = true;
            this.cbAgrupamiento1.Location = new System.Drawing.Point(157, 59);
            this.cbAgrupamiento1.Name = "cbAgrupamiento1";
            this.cbAgrupamiento1.Size = new System.Drawing.Size(117, 21);
            this.cbAgrupamiento1.TabIndex = 12;
            // 
            // ckVentasSevicio
            // 
            this.ckVentasSevicio.AutoSize = true;
            this.ckVentasSevicio.Location = new System.Drawing.Point(301, 106);
            this.ckVentasSevicio.Name = "ckVentasSevicio";
            this.ckVentasSevicio.Size = new System.Drawing.Size(118, 17);
            this.ckVentasSevicio.TabIndex = 19;
            this.ckVentasSevicio.Text = "Ventas de servicios";
            this.ckVentasSevicio.UseVisualStyleBackColor = true;
            // 
            // ckMonedaTipodeCambios
            // 
            this.ckMonedaTipodeCambios.AutoSize = true;
            this.ckMonedaTipodeCambios.Location = new System.Drawing.Point(301, 61);
            this.ckMonedaTipodeCambios.Name = "ckMonedaTipodeCambios";
            this.ckMonedaTipodeCambios.Size = new System.Drawing.Size(145, 17);
            this.ckMonedaTipodeCambios.TabIndex = 18;
            this.ckMonedaTipodeCambios.Text = "Moneda y tipo de cambio";
            this.ckMonedaTipodeCambios.UseVisualStyleBackColor = true;
            // 
            // ckVentas
            // 
            this.ckVentas.AutoSize = true;
            this.ckVentas.Location = new System.Drawing.Point(27, 102);
            this.ckVentas.Name = "ckVentas";
            this.ckVentas.Size = new System.Drawing.Size(59, 17);
            this.ckVentas.TabIndex = 16;
            this.ckVentas.Text = "Ventas";
            this.ckVentas.UseVisualStyleBackColor = true;
            // 
            // ckclientes
            // 
            this.ckclientes.AutoSize = true;
            this.ckclientes.Location = new System.Drawing.Point(27, 61);
            this.ckclientes.Name = "ckclientes";
            this.ckclientes.Size = new System.Drawing.Size(63, 17);
            this.ckclientes.TabIndex = 15;
            this.ckclientes.Text = "Clientes";
            this.ckclientes.UseVisualStyleBackColor = true;
            // 
            // lblSubArgumento
            // 
            this.lblSubArgumento.AutoSize = true;
            this.lblSubArgumento.Location = new System.Drawing.Point(315, 22);
            this.lblSubArgumento.Name = "lblSubArgumento";
            this.lblSubArgumento.Size = new System.Drawing.Size(91, 13);
            this.lblSubArgumento.TabIndex = 13;
            this.lblSubArgumento.Text = "SubAgrupamiento";
            // 
            // lblArgumento
            // 
            this.lblArgumento.AutoSize = true;
            this.lblArgumento.Location = new System.Drawing.Point(172, 22);
            this.lblArgumento.Name = "lblArgumento";
            this.lblArgumento.Size = new System.Drawing.Size(72, 13);
            this.lblArgumento.TabIndex = 11;
            this.lblArgumento.Text = "Agrupamiento";
            // 
            // lblDesglose
            // 
            this.lblDesglose.AutoSize = true;
            this.lblDesglose.Location = new System.Drawing.Point(24, 20);
            this.lblDesglose.Name = "lblDesglose";
            this.lblDesglose.Size = new System.Drawing.Size(51, 13);
            this.lblDesglose.TabIndex = 12;
            this.lblDesglose.Text = "Desglose";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(453, 179);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 18;
            this.lineShape3.X2 = 437;
            this.lineShape3.Y1 = 117;
            this.lineShape3.Y2 = 116;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 22;
            this.lineShape2.X2 = 437;
            this.lineShape2.Y1 = 73;
            this.lineShape2.Y2 = 70;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 440;
            this.lineShape1.Y1 = 30;
            this.lineShape1.Y2 = 29;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(256, 467);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar ";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(393, 25);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 11;
            this.lblEmpresa.Text = "Empresa";
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 506);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbControlinter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbTipoPoliza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(522, 540);
            this.MinimumSize = new System.Drawing.Size(522, 540);
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaces de Aspel-COI";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.Leave += new System.EventHandler(this.FrmAgregar_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbControlinter.ResumeLayout(false);
            this.tpFiltro.ResumeLayout(false);
            this.tpFiltro.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.dgRangos.ResumeLayout(false);
            this.dgRangos.PerformLayout();
            this.dgZona.ResumeLayout(false);
            this.dgZona.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpArgumentoDesglose.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbTipoPoliza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tbControlinter;
        private System.Windows.Forms.TabPage tpFiltro;
        private System.Windows.Forms.CheckBox ckIncluirCampos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Label lblClasificaciones;
        private System.Windows.Forms.GroupBox dgRangos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox dgZona;
        private System.Windows.Forms.TextBox txtZona2;
        private System.Windows.Forms.TextBox txtZona1;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tpArgumentoDesglose;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSubArgumento;
        private System.Windows.Forms.Label lblArgumento;
        private System.Windows.Forms.Label lblDesglose;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbAgrupamiento2;
        private System.Windows.Forms.ComboBox cbAgrupamiento1;
        private System.Windows.Forms.CheckBox ckVentasSevicio;
        private System.Windows.Forms.CheckBox ckMonedaTipodeCambios;
        private System.Windows.Forms.CheckBox ckVentas;
        private System.Windows.Forms.CheckBox ckclientes;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.TextBox txtNumerodeConCxc;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label lblConceptos;
        public System.Windows.Forms.Label lblEmpresa;
    }
}