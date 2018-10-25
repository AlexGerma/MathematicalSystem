using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pruebadeFibonnaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebaFibonacci frm = new FrmPruebaFibonacci();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonacci frm = new FrmFibonacci();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDato frm = new FrmTipoDato();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void recursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMcd frm = new FrmMcd();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void busquedaBinariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBinario frm = new FrmBinario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMemo.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) => pnlMemo.Visible = false;

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMemorama frm = new FrmMemorama();
            frm.SetValores(txtNOmbre.Text);
            pnlMemo.Visible = false;
            txtNOmbre.Clear();
            frm.ShowDialog();
            
        }

        private void fractalDeHibertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaHilbert frm = new PruebaHilbert();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumaMatriz frm = new SumaMatriz();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cuadradoMagicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuadraMagico frm = new CuadraMagico();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
