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
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmFibonacci_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DgridNaacci.Rows.Clear();         
            int f0 = 0, f1 = 1, fn = 0;
            DgridNaacci.Rows.Add("0");
            if (int.Parse(txtNumber.Text) == 1)
            {
                DgridNaacci.Rows.Add("1");

            }
            for (int i = 0; i < int.Parse(txtNumber.Text); i++)
            {
                if (fn == 1)
                {
                    DgridNaacci.Rows.Add(fn.ToString());
                    
                }
                if (fn > int.Parse(txtNumber.Text))
                {
                    break;
                }
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                if (fn <= int.Parse(txtNumber.Text))
                {
                    
                    DgridNaacci.Rows.Add(fn.ToString());
                }

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();  
        
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (!Validaciones.numeros(txtNumber.Text))
            {
                txtNumber.Clear();
            }
        }
    }
}
