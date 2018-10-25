namespace EstructuraDatos
{
    partial class PruebaHilbert
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
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGuardaImagen = new System.Windows.Forms.LinkLabel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRefresh
            // 
            this.chkRefresh.Location = new System.Drawing.Point(59, 49);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(111, 27);
            this.chkRefresh.TabIndex = 14;
            this.chkRefresh.Text = "Refresh";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Red;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(3, 82);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(218, 44);
            this.btnGo.TabIndex = 13;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(118, 14);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(32, 29);
            this.txtDepth.TabIndex = 12;
            this.txtDepth.Text = "4";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(55, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 22);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Depth";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlLogo.Controls.Add(this.button1);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(800, 34);
            this.pnlLogo.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EstructuraDatos.Properties.Resources.Salir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linkGuardaImagen);
            this.panel1.Controls.Add(this.txtDepth);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.chkRefresh);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 398);
            this.panel1.TabIndex = 16;
            // 
            // linkGuardaImagen
            // 
            this.linkGuardaImagen.AutoSize = true;
            this.linkGuardaImagen.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGuardaImagen.Location = new System.Drawing.Point(5, 350);
            this.linkGuardaImagen.Name = "linkGuardaImagen";
            this.linkGuardaImagen.Size = new System.Drawing.Size(217, 33);
            this.linkGuardaImagen.TabIndex = 15;
            this.linkGuardaImagen.TabStop = true;
            this.linkGuardaImagen.Text = "Guarda la imagen.";
            this.linkGuardaImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGuardaImagen_LinkClicked);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(239, 54);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(549, 384);
            this.picCanvas.TabIndex = 10;
            this.picCanvas.TabStop = false;
            // 
            // PruebaHilbert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PruebaHilbert";
            this.Text = "Hilbert";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox picCanvas;
        internal System.Windows.Forms.CheckBox chkRefresh;
        internal System.Windows.Forms.Button btnGo;
        internal System.Windows.Forms.TextBox txtDepth;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkGuardaImagen;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}