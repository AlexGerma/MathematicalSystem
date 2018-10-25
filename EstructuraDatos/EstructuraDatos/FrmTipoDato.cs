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
    public partial class FrmTipoDato : Form
    {
        int dato = 0;
        public FrmTipoDato()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnInt.Checked)
            {
                dato = 1;
            }
            else if (btnDouble.Checked)
            {
                dato = 2;
            }
            else if (btnDecimal.Checked)
            {
                dato = 3;
            }
            else if (btnChair.Checked)
            {
                dato = 4;
            }
            else if (btnString.Checked)
            {
                dato = 5;
            }
            else if (btnADT1.Checked)
            {
                dato = 6;
            }
            else if (btnADT2.Checked)
            {
                dato = 7;
            }
            
            FrmTipoDato2 frm = new FrmTipoDato2();
            frm.SetValores(dato);
            frm.ShowDialog();

        }

        private void btnInt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
