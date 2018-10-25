namespace EstructuraDatos
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMemo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unidadIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practica1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebadeFibonnaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalDeHibertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transpuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoMagicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlMemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(801, 29);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlMemo);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.textBox1);
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 29);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(801, 421);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlMemo
            // 
            this.pnlMemo.BackgroundImage = global::EstructuraDatos.Properties.Resources.spawn_todd_mcfarlane_670x410;
            this.pnlMemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMemo.Controls.Add(this.pictureBox2);
            this.pnlMemo.Controls.Add(this.button1);
            this.pnlMemo.Controls.Add(this.txtNOmbre);
            this.pnlMemo.Controls.Add(this.label4);
            this.pnlMemo.Controls.Add(this.label3);
            this.pnlMemo.Location = new System.Drawing.Point(123, 62);
            this.pnlMemo.Name = "pnlMemo";
            this.pnlMemo.Size = new System.Drawing.Size(529, 285);
            this.pnlMemo.TabIndex = 4;
            this.pnlMemo.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans ExtraBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNOmbre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOmbre.ForeColor = System.Drawing.Color.White;
            this.txtNOmbre.Location = new System.Drawing.Point(117, 140);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(258, 41);
            this.txtNOmbre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans ExtraBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Memorama";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans ExtraBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingresa Tu nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "El objetivo de la materia:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(207, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 192);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "El alumno desarrollará aplicaciones que organicen información con base a estructu" +
    "ras de datos abstractas empleando el paradigma orientado a objetos para agilizar" +
    " el acceso a los datos almacenados. ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadIToolStripMenuItem,
            this.unidadIIToolStripMenuItem,
            this.unidadIIIToolStripMenuItem,
            this.unidadIVToolStripMenuItem,
            this.unidadVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unidadIToolStripMenuItem
            // 
            this.unidadIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeDatosToolStripMenuItem,
            this.recursivaToolStripMenuItem});
            this.unidadIToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadIToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.unidadIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadIToolStripMenuItem.Image")));
            this.unidadIToolStripMenuItem.Name = "unidadIToolStripMenuItem";
            this.unidadIToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.unidadIToolStripMenuItem.Text = "Unidad I";
            // 
            // tiposDeDatosToolStripMenuItem
            // 
            this.tiposDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practica1ToolStripMenuItem});
            this.tiposDeDatosToolStripMenuItem.Name = "tiposDeDatosToolStripMenuItem";
            this.tiposDeDatosToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.tiposDeDatosToolStripMenuItem.Text = "Tipos de datos abstractos";
            // 
            // practica1ToolStripMenuItem
            // 
            this.practica1ToolStripMenuItem.Name = "practica1ToolStripMenuItem";
            this.practica1ToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.practica1ToolStripMenuItem.Text = "Practica 1";
            this.practica1ToolStripMenuItem.Click += new System.EventHandler(this.practica1ToolStripMenuItem_Click);
            // 
            // recursivaToolStripMenuItem
            // 
            this.recursivaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fibonacciToolStripMenuItem,
            this.mCDToolStripMenuItem,
            this.busquedaBinariasToolStripMenuItem,
            this.pruebadeFibonnaciToolStripMenuItem,
            this.fractalDeHibertToolStripMenuItem});
            this.recursivaToolStripMenuItem.Name = "recursivaToolStripMenuItem";
            this.recursivaToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.recursivaToolStripMenuItem.Text = "Recursiva";
            this.recursivaToolStripMenuItem.Click += new System.EventHandler(this.recursivaToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // mCDToolStripMenuItem
            // 
            this.mCDToolStripMenuItem.Name = "mCDToolStripMenuItem";
            this.mCDToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.mCDToolStripMenuItem.Text = "MCD";
            this.mCDToolStripMenuItem.Click += new System.EventHandler(this.mCDToolStripMenuItem_Click);
            // 
            // busquedaBinariasToolStripMenuItem
            // 
            this.busquedaBinariasToolStripMenuItem.Name = "busquedaBinariasToolStripMenuItem";
            this.busquedaBinariasToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.busquedaBinariasToolStripMenuItem.Text = "Busqueda binarias";
            this.busquedaBinariasToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariasToolStripMenuItem_Click);
            // 
            // pruebadeFibonnaciToolStripMenuItem
            // 
            this.pruebadeFibonnaciToolStripMenuItem.Name = "pruebadeFibonnaciToolStripMenuItem";
            this.pruebadeFibonnaciToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.pruebadeFibonnaciToolStripMenuItem.Text = "Prueba de Fibonnaci";
            this.pruebadeFibonnaciToolStripMenuItem.Click += new System.EventHandler(this.pruebadeFibonnaciToolStripMenuItem_Click);
            // 
            // fractalDeHibertToolStripMenuItem
            // 
            this.fractalDeHibertToolStripMenuItem.Name = "fractalDeHibertToolStripMenuItem";
            this.fractalDeHibertToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.fractalDeHibertToolStripMenuItem.Text = "Fractal de Hibert";
            this.fractalDeHibertToolStripMenuItem.Click += new System.EventHandler(this.fractalDeHibertToolStripMenuItem_Click);
            // 
            // unidadIIToolStripMenuItem
            // 
            this.unidadIIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoramaToolStripMenuItem,
            this.metodosDeOrdenamientoToolStripMenuItem,
            this.sumaToolStripMenuItem,
            this.inversaToolStripMenuItem,
            this.transpuestaToolStripMenuItem,
            this.cuadradoMagicoToolStripMenuItem});
            this.unidadIIToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadIIToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unidadIIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadIIToolStripMenuItem.Image")));
            this.unidadIIToolStripMenuItem.Name = "unidadIIToolStripMenuItem";
            this.unidadIIToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.unidadIIToolStripMenuItem.Text = "Unidad II";
            // 
            // memoramaToolStripMenuItem
            // 
            this.memoramaToolStripMenuItem.Name = "memoramaToolStripMenuItem";
            this.memoramaToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.memoramaToolStripMenuItem.Text = "Memorama";
            this.memoramaToolStripMenuItem.Click += new System.EventHandler(this.memoramaToolStripMenuItem_Click);
            // 
            // metodosDeOrdenamientoToolStripMenuItem
            // 
            this.metodosDeOrdenamientoToolStripMenuItem.Name = "metodosDeOrdenamientoToolStripMenuItem";
            this.metodosDeOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.metodosDeOrdenamientoToolStripMenuItem.Text = "Metodos de ordenamiento";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // inversaToolStripMenuItem
            // 
            this.inversaToolStripMenuItem.Name = "inversaToolStripMenuItem";
            this.inversaToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.inversaToolStripMenuItem.Text = "Inversa";
            // 
            // transpuestaToolStripMenuItem
            // 
            this.transpuestaToolStripMenuItem.Name = "transpuestaToolStripMenuItem";
            this.transpuestaToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.transpuestaToolStripMenuItem.Text = "Transpuesta";
            // 
            // cuadradoMagicoToolStripMenuItem
            // 
            this.cuadradoMagicoToolStripMenuItem.Name = "cuadradoMagicoToolStripMenuItem";
            this.cuadradoMagicoToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.cuadradoMagicoToolStripMenuItem.Text = "cuadrado Magico";
            this.cuadradoMagicoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoMagicoToolStripMenuItem_Click);
            // 
            // unidadIIIToolStripMenuItem
            // 
            this.unidadIIIToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadIIIToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unidadIIIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadIIIToolStripMenuItem.Image")));
            this.unidadIIIToolStripMenuItem.Name = "unidadIIIToolStripMenuItem";
            this.unidadIIIToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.unidadIIIToolStripMenuItem.Text = "Unidad III";
            // 
            // unidadIVToolStripMenuItem
            // 
            this.unidadIVToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadIVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unidadIVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadIVToolStripMenuItem.Image")));
            this.unidadIVToolStripMenuItem.Name = "unidadIVToolStripMenuItem";
            this.unidadIVToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.unidadIVToolStripMenuItem.Text = "Unidad IV";
            // 
            // unidadVToolStripMenuItem
            // 
            this.unidadVToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unidadVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadVToolStripMenuItem.Image")));
            this.unidadVToolStripMenuItem.Name = "unidadVToolStripMenuItem";
            this.unidadVToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.unidadVToolStripMenuItem.Text = "UnidadV";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlMemo.ResumeLayout(false);
            this.pnlMemo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem unidadIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadIIIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practica1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebadeFibonnaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractalDeHibertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoramaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transpuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoMagicoToolStripMenuItem;
    }
}

