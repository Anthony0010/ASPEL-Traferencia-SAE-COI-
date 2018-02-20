namespace pjSystemaSeaCoi.interfacesCoi
{
    partial class frmPolizaConsulta
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInical = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoFolio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoPartida = new System.Windows.Forms.TextBox();
            this.dgPoliza = new System.Windows.Forms.DataGridView();
            this.DgvCueentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoliza)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "MM/dd/yyyy";
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(564, 39);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(95, 20);
            this.dtFecha.TabIndex = 7;
            this.dtFecha.Value = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            // 
            // dtFechaInical
            // 
            this.dtFechaInical.CustomFormat = "MM/dd/yyyy";
            this.dtFechaInical.Enabled = false;
            this.dtFechaInical.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInical.Location = new System.Drawing.Point(453, 39);
            this.dtFechaInical.Name = "dtFechaInical";
            this.dtFechaInical.Size = new System.Drawing.Size(95, 20);
            this.dtFechaInical.TabIndex = 9;
            this.dtFechaInical.Value = new System.DateTime(2017, 5, 17, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // txtNoFolio
            // 
            this.txtNoFolio.Location = new System.Drawing.Point(250, 43);
            this.txtNoFolio.Name = "txtNoFolio";
            this.txtNoFolio.Size = new System.Drawing.Size(84, 20);
            this.txtNoFolio.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtFechaInical);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txtNoFolio);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 160);
            this.panel1.TabIndex = 9;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(98, 80);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(370, 51);
            this.txtConcepto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conceptos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // txtNoPartida
            // 
            this.txtNoPartida.Enabled = false;
            this.txtNoPartida.Location = new System.Drawing.Point(119, -1);
            this.txtNoPartida.Name = "txtNoPartida";
            this.txtNoPartida.Size = new System.Drawing.Size(100, 20);
            this.txtNoPartida.TabIndex = 10;
            // 
            // dgPoliza
            // 
            this.dgPoliza.AllowUserToAddRows = false;
            this.dgPoliza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCueentas});
            this.dgPoliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPoliza.Location = new System.Drawing.Point(0, 160);
            this.dgPoliza.Name = "dgPoliza";
            this.dgPoliza.RowHeadersVisible = false;
            this.dgPoliza.Size = new System.Drawing.Size(827, 334);
            this.dgPoliza.TabIndex = 11;
            // 
            // DgvCueentas
            // 
            this.DgvCueentas.HeaderText = "Cuentas";
            this.DgvCueentas.Name = "DgvCueentas";
            this.DgvCueentas.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtDebito);
            this.panel3.Controls.Add(this.txtCredito);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.txtPartida);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 100);
            this.panel3.TabIndex = 12;
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDebito.Enabled = false;
            this.txtDebito.Location = new System.Drawing.Point(514, 6);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(121, 20);
            this.txtDebito.TabIndex = 15;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "No. de Partida";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(194, 20);
            this.textBox5.TabIndex = 8;
            // 
            // txtPartida
            // 
            this.txtPartida.Enabled = false;
            this.txtPartida.Location = new System.Drawing.Point(119, 6);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(100, 20);
            this.txtPartida.TabIndex = 7;
            this.txtPartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(98, 43);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(84, 20);
            this.cbTipo.TabIndex = 12;
            // 
            // frmPolizaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 594);
            this.Controls.Add(this.dgPoliza);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNoPartida);
            this.Name = "frmPolizaConsulta";
            this.Text = "Consulta Poliza ";
            this.Load += new System.EventHandler(this.frmPolizaConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoliza)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.DateTimePicker dtFechaInical;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoPartida;
        public System.Windows.Forms.DataGridView dgPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCueentas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtNoFolio;
        public System.Windows.Forms.TextBox txtConcepto;
        public System.Windows.Forms.TextBox cbTipo;
    }
}