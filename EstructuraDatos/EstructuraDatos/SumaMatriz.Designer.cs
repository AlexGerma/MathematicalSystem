namespace EstructuraDatos
{
    partial class SumaMatriz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMatriz = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.btnRamdom = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgrid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgrid3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNm2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNm1 = new System.Windows.Forms.TextBox();
            this.pnlLogo.SuspendLayout();
            this.pnlMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLogo.Controls.Add(this.btnSalir);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(924, 34);
            this.pnlLogo.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::EstructuraDatos.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(876, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(321, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suma de matriz";
            // 
            // pnlMatriz
            // 
            this.pnlMatriz.BackColor = System.Drawing.Color.DimGray;
            this.pnlMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMatriz.Controls.Add(this.btnGenerar);
            this.pnlMatriz.Controls.Add(this.label3);
            this.pnlMatriz.Controls.Add(this.txtNumber2);
            this.pnlMatriz.Controls.Add(this.label1);
            this.pnlMatriz.Controls.Add(this.txtNumber1);
            this.pnlMatriz.Location = new System.Drawing.Point(554, 320);
            this.pnlMatriz.Name = "pnlMatriz";
            this.pnlMatriz.Size = new System.Drawing.Size(370, 172);
            this.pnlMatriz.TabIndex = 17;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(76, 105);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(218, 44);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Renglones:";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(155, 62);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(185, 29);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Columnas:";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(155, 25);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(185, 29);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // btnRamdom
            // 
            this.btnRamdom.BackColor = System.Drawing.Color.Silver;
            this.btnRamdom.FlatAppearance.BorderSize = 0;
            this.btnRamdom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRamdom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRamdom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRamdom.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRamdom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRamdom.Location = new System.Drawing.Point(12, 419);
            this.btnRamdom.Name = "btnRamdom";
            this.btnRamdom.Size = new System.Drawing.Size(218, 44);
            this.btnRamdom.TabIndex = 14;
            this.btnRamdom.Text = "Random";
            this.btnRamdom.UseVisualStyleBackColor = false;
            this.btnRamdom.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(231, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Suma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(601, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 44);
            this.label4.TabIndex = 19;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(286, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = "+";
            // 
            // Dgrid1
            // 
            this.Dgrid1.AllowUserToAddRows = false;
            this.Dgrid1.AllowUserToDeleteRows = false;
            this.Dgrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid1.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Dgrid1.GridColor = System.Drawing.Color.Silver;
            this.Dgrid1.Location = new System.Drawing.Point(12, 62);
            this.Dgrid1.Name = "Dgrid1";
            this.Dgrid1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgrid1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgrid1.Size = new System.Drawing.Size(256, 252);
            this.Dgrid1.TabIndex = 20;
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
            // Dgrid2
            // 
            this.Dgrid2.AllowUserToAddRows = false;
            this.Dgrid2.AllowUserToDeleteRows = false;
            this.Dgrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid2.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Dgrid2.GridColor = System.Drawing.Color.Silver;
            this.Dgrid2.Location = new System.Drawing.Point(339, 62);
            this.Dgrid2.Name = "Dgrid2";
            this.Dgrid2.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgrid2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgrid2.Size = new System.Drawing.Size(256, 252);
            this.Dgrid2.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Dgrid3
            // 
            this.Dgrid3.AllowUserToAddRows = false;
            this.Dgrid3.AllowUserToDeleteRows = false;
            this.Dgrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid3.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.Dgrid3.GridColor = System.Drawing.Color.Silver;
            this.Dgrid3.Location = new System.Drawing.Point(649, 62);
            this.Dgrid3.Name = "Dgrid3";
            this.Dgrid3.ReadOnly = true;
            this.Dgrid3.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgrid3.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgrid3.Size = new System.Drawing.Size(256, 252);
            this.Dgrid3.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(132, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "#2:";
            // 
            // txtNm2
            // 
            this.txtNm2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNm2.Location = new System.Drawing.Point(175, 378);
            this.txtNm2.Name = "txtNm2";
            this.txtNm2.Size = new System.Drawing.Size(185, 29);
            this.txtNm2.TabIndex = 23;
            this.txtNm2.TextChanged += new System.EventHandler(this.txtNm2_TextChanged);
            this.txtNm2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNm2_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(132, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "#1:";
            // 
            // txtNm1
            // 
            this.txtNm1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNm1.Location = new System.Drawing.Point(175, 341);
            this.txtNm1.Name = "txtNm1";
            this.txtNm1.Size = new System.Drawing.Size(185, 29);
            this.txtNm1.TabIndex = 21;
            this.txtNm1.TextChanged += new System.EventHandler(this.txtNm1_TextChanged);
            // 
            // SumaMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(924, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNm2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNm1);
            this.Controls.Add(this.Dgrid3);
            this.Controls.Add(this.Dgrid2);
            this.Controls.Add(this.Dgrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRamdom);
            this.Controls.Add(this.pnlMatriz);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SumaMatriz";
            this.Text = "SumaMatriz";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlMatriz.ResumeLayout(false);
            this.pnlMatriz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        internal System.Windows.Forms.Button btnGenerar;
        internal System.Windows.Forms.Button btnRamdom;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView Dgrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView Dgrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNm2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNm1;
    }
}