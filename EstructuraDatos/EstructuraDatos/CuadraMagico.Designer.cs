namespace EstructuraDatos
{
    partial class CuadraMagico
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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgrid1 = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.btnEjemplo2 = new System.Windows.Forms.Button();
            this.lbDiagonal = new System.Windows.Forms.Label();
            this.lbDialogo1 = new System.Windows.Forms.Label();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlLogo.Size = new System.Drawing.Size(800, 34);
            this.pnlLogo.TabIndex = 17;
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
            this.btnSalir.Location = new System.Drawing.Point(752, 0);
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
            // Dgrid1
            // 
            this.Dgrid1.AllowUserToAddRows = false;
            this.Dgrid1.AllowUserToDeleteRows = false;
            this.Dgrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgrid1.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid1.GridColor = System.Drawing.Color.Silver;
            this.Dgrid1.Location = new System.Drawing.Point(22, 40);
            this.Dgrid1.Name = "Dgrid1";
            this.Dgrid1.RowHeadersWidth = 60;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgrid1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgrid1.Size = new System.Drawing.Size(466, 279);
            this.Dgrid1.TabIndex = 21;
            this.Dgrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid1_CellClick);
            this.Dgrid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid1_CellEndEdit);
            this.Dgrid1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid1_CellLeave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.Location = new System.Drawing.Point(138, 325);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(218, 44);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuraDatos.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(552, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(257, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(218, 44);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(218, 44);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.BackColor = System.Drawing.Color.Silver;
            this.btnEjemplo1.FlatAppearance.BorderSize = 0;
            this.btnEjemplo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEjemplo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEjemplo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo1.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEjemplo1.Location = new System.Drawing.Point(561, 263);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(218, 44);
            this.btnEjemplo1.TabIndex = 22;
            this.btnEjemplo1.Text = "Ejemplo 1";
            this.btnEjemplo1.UseVisualStyleBackColor = false;
            // 
            // btnEjemplo2
            // 
            this.btnEjemplo2.BackColor = System.Drawing.Color.Silver;
            this.btnEjemplo2.FlatAppearance.BorderSize = 0;
            this.btnEjemplo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEjemplo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEjemplo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo2.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEjemplo2.Location = new System.Drawing.Point(561, 313);
            this.btnEjemplo2.Name = "btnEjemplo2";
            this.btnEjemplo2.Size = new System.Drawing.Size(218, 44);
            this.btnEjemplo2.TabIndex = 22;
            this.btnEjemplo2.Text = "Ejemplo 2";
            this.btnEjemplo2.UseVisualStyleBackColor = false;
            // 
            // lbDiagonal
            // 
            this.lbDiagonal.AutoSize = true;
            this.lbDiagonal.Location = new System.Drawing.Point(453, 322);
            this.lbDiagonal.Name = "lbDiagonal";
            this.lbDiagonal.Size = new System.Drawing.Size(35, 13);
            this.lbDiagonal.TabIndex = 24;
            this.lbDiagonal.Text = "label1";
            // 
            // lbDialogo1
            // 
            this.lbDialogo1.AutoSize = true;
            this.lbDialogo1.Location = new System.Drawing.Point(12, 325);
            this.lbDialogo1.Name = "lbDialogo1";
            this.lbDialogo1.Size = new System.Drawing.Size(35, 13);
            this.lbDialogo1.TabIndex = 24;
            this.lbDialogo1.Text = "label1";
            // 
            // CuadraMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDialogo1);
            this.Controls.Add(this.lbDiagonal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEjemplo2);
            this.Controls.Add(this.btnEjemplo1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Dgrid1);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuadraMagico";
            this.Text = "CuadraMagico";
            this.Load += new System.EventHandler(this.CuadraMagico_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgrid1;
        internal System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnEjemplo1;
        internal System.Windows.Forms.Button btnEjemplo2;
        private System.Windows.Forms.Label lbDiagonal;
        private System.Windows.Forms.Label lbDialogo1;
    }
}