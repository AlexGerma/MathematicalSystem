namespace EstructuraDatos
{
    partial class FrmTipoDato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbloho = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnADT2 = new System.Windows.Forms.RadioButton();
            this.btnADT1 = new System.Windows.Forms.RadioButton();
            this.btnString = new System.Windows.Forms.RadioButton();
            this.btnChair = new System.Windows.Forms.RadioButton();
            this.btnDecimal = new System.Windows.Forms.RadioButton();
            this.btnDouble = new System.Windows.Forms.RadioButton();
            this.btnInt = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbloho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 32);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::EstructuraDatos.Properties.Resources.depositphotos_36124233_stock_illustration_vector_close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(284, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbloho
            // 
            this.lbloho.AutoSize = true;
            this.lbloho.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloho.ForeColor = System.Drawing.Color.White;
            this.lbloho.Location = new System.Drawing.Point(3, 4);
            this.lbloho.Name = "lbloho";
            this.lbloho.Size = new System.Drawing.Size(110, 24);
            this.lbloho.TabIndex = 0;
            this.lbloho.Text = "Tipo de dato";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::EstructuraDatos.Properties.Resources.cuabro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnADT2);
            this.panel2.Controls.Add(this.btnADT1);
            this.panel2.Controls.Add(this.btnString);
            this.panel2.Controls.Add(this.btnChair);
            this.panel2.Controls.Add(this.btnDecimal);
            this.panel2.Controls.Add(this.btnDouble);
            this.panel2.Controls.Add(this.btnInt);
            this.panel2.Location = new System.Drawing.Point(64, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 302);
            this.panel2.TabIndex = 1;
            // 
            // btnADT2
            // 
            this.btnADT2.AutoSize = true;
            this.btnADT2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADT2.Location = new System.Drawing.Point(42, 242);
            this.btnADT2.Name = "btnADT2";
            this.btnADT2.Size = new System.Drawing.Size(84, 30);
            this.btnADT2.TabIndex = 0;
            this.btnADT2.TabStop = true;
            this.btnADT2.Text = "ADT 2";
            this.btnADT2.UseVisualStyleBackColor = true;
            // 
            // btnADT1
            // 
            this.btnADT1.AutoSize = true;
            this.btnADT1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADT1.Location = new System.Drawing.Point(42, 206);
            this.btnADT1.Name = "btnADT1";
            this.btnADT1.Size = new System.Drawing.Size(84, 30);
            this.btnADT1.TabIndex = 0;
            this.btnADT1.TabStop = true;
            this.btnADT1.Text = "ADT 1";
            this.btnADT1.UseVisualStyleBackColor = true;
            // 
            // btnString
            // 
            this.btnString.AutoSize = true;
            this.btnString.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnString.Location = new System.Drawing.Point(41, 170);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(83, 30);
            this.btnString.TabIndex = 0;
            this.btnString.TabStop = true;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            // 
            // btnChair
            // 
            this.btnChair.AutoSize = true;
            this.btnChair.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair.Location = new System.Drawing.Point(41, 134);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(71, 30);
            this.btnChair.TabIndex = 0;
            this.btnChair.TabStop = true;
            this.btnChair.Text = "Char";
            this.btnChair.UseVisualStyleBackColor = true;
            this.btnChair.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnDecimal
            // 
            this.btnDecimal.AutoSize = true;
            this.btnDecimal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(42, 98);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(104, 30);
            this.btnDecimal.TabIndex = 0;
            this.btnDecimal.TabStop = true;
            this.btnDecimal.Text = "Decimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            this.btnDouble.AutoSize = true;
            this.btnDouble.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(42, 62);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(93, 30);
            this.btnDouble.TabIndex = 0;
            this.btnDouble.TabStop = true;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // btnInt
            // 
            this.btnInt.AutoSize = true;
            this.btnInt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(42, 26);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(54, 30);
            this.btnInt.TabIndex = 0;
            this.btnInt.TabStop = true;
            this.btnInt.Text = "Int";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.CheckedChanged += new System.EventHandler(this.btnInt_CheckedChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Gray;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(64, 360);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(187, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmTipoDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(320, 420);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoDato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoDato";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbloho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btnString;
        private System.Windows.Forms.RadioButton btnChair;
        private System.Windows.Forms.RadioButton btnDecimal;
        private System.Windows.Forms.RadioButton btnDouble;
        private System.Windows.Forms.RadioButton btnInt;
        private System.Windows.Forms.RadioButton btnADT2;
        private System.Windows.Forms.RadioButton btnADT1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciar;
    }
}