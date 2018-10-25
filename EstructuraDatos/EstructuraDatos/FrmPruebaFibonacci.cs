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
    public partial class FrmPruebaFibonacci : Form
    {
        public FrmPruebaFibonacci()
        {
            InitializeComponent();
        }
        private void buscar()
        {
            if (Int32.Parse(textBox1.Text) == 1)
            {
                lbRes.Text = "El #1 Fibonacci es 0";
            }
            else if(Int32.Parse(textBox1.Text) == 2)
            {
                lbRes.Text = "El #2 Fibonacci es 1";
            }
            else
            {
                lbRes.Text = "El #" + textBox1.Text +" de Fibonacci "+ Prueba(Int32.Parse(textBox1.Text));
            }
        }
        private long Prueba(int i)
        {
            if (i ==0 || i == 1)
            {
                return 1;
            }
            else
            {
                return Prueba(i - 1) + Prueba(i - 2);
            }
           
        }
        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        private void Generar()
        {
            DgridNumeros.Rows.Clear();
            int f0 = 0, f1 = 1, fn = 0;
            DgridNumeros.Rows.Add("0");
            if (4200 == 1)
            {
                DgridNumeros.Rows.Add("1");

            }
            for (int i = 0; i < 4200; i++)
            {
                if (fn == 1)
                {
                    DgridNumeros.Rows.Add(fn.ToString());

                }
                if (fn > 4200)
                {
                    break;
                }
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                if (fn <= 4200)
                {

                    DgridNumeros.Rows.Add(fn.ToString());
                }
                setRowNumber(DgridNumeros);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                }

            }
            else if (Int32.Parse(textBox1.Text) > 20)
            {
                lbRes.Text = "Ingresa un nuemero de 1 a 20";
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
            if (!Validaciones.numeros(textBox1.Text))
            {
                textBox1.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            buscar();
        }

        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void FrmPruebaFibonacci_Load(object sender, EventArgs e)
        {
            Generar();
        }
    }
}
