namespace pjSystemaSeaCoi.interfacesCoi
{
    partial class FrmPoliza
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.dtFechaInical = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtNoFolio = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgCuentas = new System.Windows.Forms.DataGridView();
            this.dgPoliza = new System.Windows.Forms.DataGridView();
            this.DgvCueentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtejercio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtNoPartida = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoliza)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.insertarPartidaToolStripMenuItem,
            this.borrarPartidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // insertarPartidaToolStripMenuItem
            // 
            this.insertarPartidaToolStripMenuItem.Name = "insertarPartidaToolStripMenuItem";
            this.insertarPartidaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.insertarPartidaToolStripMenuItem.Text = "Insertar Partida";
            // 
            // borrarPartidaToolStripMenuItem
            // 
            this.borrarPartidaToolStripMenuItem.Name = "borrarPartidaToolStripMenuItem";
            this.borrarPartidaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.borrarPartidaToolStripMenuItem.Text = "Borrar Partida";
            this.borrarPartidaToolStripMenuItem.Click += new System.EventHandler(this.borrarPartidaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblTipoDoc);
            this.panel1.Controls.Add(this.dtFechaInical);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.txtNoFolio);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 128);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(638, 98);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(638, 75);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(48, 13);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "TipoDoc";
            // 
            // dtFechaInical
            // 
            this.dtFechaInical.CustomFormat = "MM/dd/yyyy";
            this.dtFechaInical.Enabled = false;
            this.dtFechaInical.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInical.Location = new System.Drawing.Point(453, 15);
            this.dtFechaInical.Name = "dtFechaInical";
            this.dtFechaInical.Size = new System.Drawing.Size(95, 20);
            this.dtFechaInical.TabIndex = 9;
            this.dtFechaInical.Value = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 54);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(638, 54);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 13;
            this.lblEmpresa.Text = "Empresa";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "MM/dd/yyyy";
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(564, 15);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(95, 20);
            this.dtFecha.TabIndex = 7;
            this.dtFecha.Value = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(98, 23);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // txtNoFolio
            // 
            this.txtNoFolio.Location = new System.Drawing.Point(297, 15);
            this.txtNoFolio.Name = "txtNoFolio";
            this.txtNoFolio.Size = new System.Drawing.Size(84, 20);
            this.txtNoFolio.TabIndex = 5;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(98, 60);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(401, 51);
            this.txtConcepto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conceptos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dgCuentas);
            this.panel2.Controls.Add(this.dgPoliza);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 274);
            this.panel2.TabIndex = 2;
            // 
            // dgCuentas
            // 
            this.dgCuentas.AllowUserToAddRows = false;
            this.dgCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuentas.Location = new System.Drawing.Point(332, 22);
            this.dgCuentas.Name = "dgCuentas";
            this.dgCuentas.RowHeadersVisible = false;
            this.dgCuentas.Size = new System.Drawing.Size(190, 231);
            this.dgCuentas.TabIndex = 1;
            this.dgCuentas.Visible = false;
            this.dgCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuentas_CellContentClick);
            // 
            // dgPoliza
            // 
            this.dgPoliza.AllowUserToAddRows = false;
            this.dgPoliza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCueentas});
            this.dgPoliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPoliza.Location = new System.Drawing.Point(0, 0);
            this.dgPoliza.Name = "dgPoliza";
            this.dgPoliza.RowHeadersVisible = false;
            this.dgPoliza.Size = new System.Drawing.Size(777, 274);
            this.dgPoliza.TabIndex = 0;
            this.dgPoliza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoliza_CellContentClick);
            // 
            // DgvCueentas
            // 
            this.DgvCueentas.HeaderText = "Cuentas";
            this.DgvCueentas.Name = "DgvCueentas";
            this.DgvCueentas.Visible = false;
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDebito.Enabled = false;
            this.txtDebito.Location = new System.Drawing.Point(514, 6);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(121, 20);
            this.txtDebito.TabIndex = 15;
            this.txtDebito.TextChanged += new System.EventHandler(this.txtDebito_TextChanged);
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCredito.Enabled = false;
            this.txtCredito.Location = new System.Drawing.Point(641, 6);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(133, 20);
            this.txtCredito.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtDebito);
            this.panel3.Controls.Add(this.txtCredito);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtejercio);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtperiodo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.txtNoPartida);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 100);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ejercio (A_o)";
            // 
            // txtejercio
            // 
            this.txtejercio.Enabled = false;
            this.txtejercio.Location = new System.Drawing.Point(407, 37);
            this.txtejercio.Name = "txtejercio";
            this.txtejercio.Size = new System.Drawing.Size(77, 20);
            this.txtejercio.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Periodo(Mes)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtperiodo
            // 
            this.txtperiodo.Enabled = false;
            this.txtperiodo.Location = new System.Drawing.Point(407, 10);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(77, 20);
            this.txtperiodo.TabIndex = 9;
            this.txtperiodo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. de Partida";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(194, 20);
            this.textBox5.TabIndex = 8;
            // 
            // txtNoPartida
            // 
            this.txtNoPartida.Enabled = false;
            this.txtNoPartida.Location = new System.Drawing.Point(119, 6);
            this.txtNoPartida.Name = "txtNoPartida";
            this.txtNoPartida.Size = new System.Drawing.Size(100, 20);
            this.txtNoPartida.TabIndex = 7;
            this.txtNoPartida.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 6;
            // 
            // FrmPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Diario";
            this.Load += new System.EventHandler(this.FrmPoliza_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoliza)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarPartidaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtNoFolio;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtNoPartida;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgPoliza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtejercio;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.Label lblEmpresa;
        public System.Windows.Forms.DataGridView dgCuentas;
        public System.Windows.Forms.DateTimePicker dtFechaInical;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txtCredito;
        public System.Windows.Forms.Label lblTipoDoc;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCueentas;
    }
}