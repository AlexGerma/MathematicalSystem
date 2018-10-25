namespace EstructuraDatos
{
    partial class FrmTipoDato2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbloho = new System.Windows.Forms.Label();
            this.lbElemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.DgridDato = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbElemntoo = new System.Windows.Forms.Label();
            this.lbSelect = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.gbxAltura = new System.Windows.Forms.GroupBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridDato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbxAltura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.lbloho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 37);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::EstructuraDatos.Properties.Resources.depositphotos_36124233_stock_illustration_vector_close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(577, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.Red;
            this.lbTipo.Location = new System.Drawing.Point(266, 5);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(44, 24);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo";
            // 
            // lbloho
            // 
            this.lbloho.AutoSize = true;
            this.lbloho.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloho.ForeColor = System.Drawing.Color.White;
            this.lbloho.Location = new System.Drawing.Point(3, 5);
            this.lbloho.Name = "lbloho";
            this.lbloho.Size = new System.Drawing.Size(126, 24);
            this.lbloho.TabIndex = 0;
            this.lbloho.Text = "Tipo de dato 2";
            // 
            // lbElemento
            // 
            this.lbElemento.AutoSize = true;
            this.lbElemento.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElemento.Location = new System.Drawing.Point(18, 61);
            this.lbElemento.Name = "lbElemento";
            this.lbElemento.Size = new System.Drawing.Size(143, 24);
            this.lbElemento.TabIndex = 2;
            this.lbElemento.Text = "Elemento[0,0] =";
            this.lbElemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(167, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(146, 31);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.Gray;
            this.btnCapturar.FlatAppearance.BorderSize = 0;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.White;
            this.btnCapturar.Location = new System.Drawing.Point(396, 80);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(157, 49);
            this.btnCapturar.TabIndex = 4;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Gray;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(396, 148);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(157, 49);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // DgridDato
            // 
            this.DgridDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridDato.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgridDato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgridDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgridDato.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgridDato.GridColor = System.Drawing.Color.Gainsboro;
            this.DgridDato.Location = new System.Drawing.Point(0, 271);
            this.DgridDato.Name = "DgridDato";
            this.DgridDato.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgridDato.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgridDato.Size = new System.Drawing.Size(613, 198);
            this.DgridDato.TabIndex = 5;
            this.DgridDato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridDato_CellClick);
            this.DgridDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridDato_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EstructuraDatos.Properties.Resources.Raya;
            this.pictureBox2.Location = new System.Drawing.Point(167, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 5);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lbElemntoo
            // 
            this.lbElemntoo.AutoSize = true;
            this.lbElemntoo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElemntoo.Location = new System.Drawing.Point(18, 105);
            this.lbElemntoo.Name = "lbElemntoo";
            this.lbElemntoo.Size = new System.Drawing.Size(143, 24);
            this.lbElemntoo.TabIndex = 2;
            this.lbElemntoo.Text = "Elemento[0,0] =";
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect.Location = new System.Drawing.Point(167, 105);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(43, 24);
            this.lbSelect.TabIndex = 2;
            this.lbSelect.Text = "###";
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(156, 0);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(146, 31);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EstructuraDatos.Properties.Resources.Raya;
            this.pictureBox3.Location = new System.Drawing.Point(156, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 5);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.Location = new System.Drawing.Point(59, 8);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(79, 24);
            this.lbAltura.TabIndex = 2;
            this.lbAltura.Text = "Altura = ";
            this.lbAltura.Click += new System.EventHandler(this.lbAltura_Click);
            // 
            // gbxAltura
            // 
            this.gbxAltura.Controls.Add(this.txtBase);
            this.gbxAltura.Controls.Add(this.pictureBox4);
            this.gbxAltura.Controls.Add(this.txtAltura);
            this.gbxAltura.Controls.Add(this.label1);
            this.gbxAltura.Controls.Add(this.pictureBox3);
            this.gbxAltura.Controls.Add(this.lbAltura);
            this.gbxAltura.Location = new System.Drawing.Point(7, 152);
            this.gbxAltura.Name = "gbxAltura";
            this.gbxAltura.Size = new System.Drawing.Size(323, 113);
            this.gbxAltura.TabIndex = 7;
            this.gbxAltura.TabStop = false;
            this.gbxAltura.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBase.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(156, 44);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(146, 31);
            this.txtBase.TabIndex = 3;
            this.txtBase.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EstructuraDatos.Properties.Resources.Raya;
            this.pictureBox4.Location = new System.Drawing.Point(156, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(146, 5);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base =";
            this.label1.Click += new System.EventHandler(this.lbAltura_Click);
            // 
            // FrmTipoDato2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(613, 471);
            this.Controls.Add(this.gbxAltura);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DgridDato);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.lbElemntoo);
            this.Controls.Add(this.lbElemento);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoDato2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoDato2";
            this.Load += new System.EventHandler(this.FrmTipoDato2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridDato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbxAltura.ResumeLayout(false);
            this.gbxAltura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbloho;
        private System.Windows.Forms.Label lbElemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView DgridDato;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbElemntoo;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.GroupBox gbxAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}