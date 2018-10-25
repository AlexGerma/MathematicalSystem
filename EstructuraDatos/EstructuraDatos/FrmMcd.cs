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
    public partial class FrmMcd : Form
    {
        public FrmMcd()
        {
            InitializeComponent();
        }

        private void FrmMcd_Load(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            //if (txtNum1.Text == "-")
            //{

            //}
            //else 
            //{
            //    if (!Validaciones.numeros(txtNum1.Text))
            //    {

            //    }
            //    txtNum1.Clear();
            //}
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            //if (!Validaciones.numeros(txtNum2.Text))
            //{
            //    txtNum2.Clear();
            //}
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private int Mcd(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                a = a < 0 ? 1 * -1 : a;
                a = a < 0 ? 1 * -1 : b;

                return Mcd(a, b);
            }
            else if(b > a) return Mcd(b, a);
           
            else if (b == 0) return a;          
            else
            {
                return Mcd(a - b,b);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
             lbResultado.Text = Mcd(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
