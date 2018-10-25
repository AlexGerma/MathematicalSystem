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
    public partial class SumaMatriz : Form
    {
        public SumaMatriz()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones.numeros(txtNumber2.Text))
                {
                    txtNumber2.Clear();
                }
                else
                {
                    if (txtNumber2.TextLength == 1)
                    {
                        if (txtNumber2.Text == "0")
                        {
                            txtNumber2.Clear();
                        }
                    }
                    else
                    {
                        if (Int32.Parse(txtNumber2.Text) > 25)
                        {
                            txtNumber2.Clear();
                        }
                    }
                    
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones.numeros(txtNumber1.Text))
                {
                    txtNumber1.Clear();
                }
                else
                {
                    if (txtNumber1.TextLength == 1)
                    {

                        if (txtNumber1.Text == "0")
                        {
                            if (txtNumber1.Text == "")
                            {

                            }
                            else
                            {
                                txtNumber1.Clear();
                            }

                        }
                    }
                    else
                    {

                        if (Int32.Parse(txtNumber1.Text) > 25)
                        {
                            if (txtNumber1.Text == "")
                            {

                            }
                            else
                            {
                                txtNumber1.Clear();
                            }


                        }

                    }

                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Random nm = new Random();
                int Numero = nm.Next(1, 10);

                Dgrid1.Columns.Clear();
                Dgrid2.Columns.Clear();
                Dgrid3.Columns.Clear();
                for (int i = 0; i < Int32.Parse(txtNumber1.Text); i++)
                {
                    Dgrid1.Columns.Add("", "Columna " + i);
                    Dgrid2.Columns.Add("", "Columna " + i);
                    Dgrid3.Columns.Add("", "Columna " + i);
                }
                for (int i = 0; i < Int32.Parse(txtNumber2.Text); i++)
                {
                    Dgrid1.Rows.Add("");
                    Dgrid2.Rows.Add("");
                    Dgrid3.Rows.Add("");
                }
                txtNumber1.Clear();
                txtNumber2.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("No puedes dejar Campos Vacios");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int col = 0;
                int numero = 0;
                Random nm = new Random();
                int var1 = Int32.Parse(txtNm1.Text);
                int var2 = Int32.Parse(txtNm2.Text);
                if (var1 > var2)
                {
                    var1 = Int32.Parse(txtNm2.Text);
                    var2 = Int32.Parse(txtNm1.Text);
                }

                for (int i = 0; i < Dgrid1.ColumnCount; i++)
                {

                    for (int y = 0; y < Dgrid1.Rows.Count; y++)
                    {
                        numero = 0;
                        numero = nm.Next(var1, var2);
                        Dgrid1.Rows[y].Cells[col].Value = numero.ToString();
                    }
                    for (int y = 0; y < Dgrid1.Rows.Count; y++)
                    {
                        numero = 0;
                        numero = nm.Next(var1, var2);
                        Dgrid2.Rows[y].Cells[col].Value = numero.ToString();
                    }
                    col++;
                }
                txtNm1.Clear();
                txtNm2.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("No puedes Dejar Campos Vacios");
            }
            
        }

        private void txtNm1_TextChanged(object sender, EventArgs e)
        {
            if (!Validaciones.numeros(txtNm1.Text))
            {
                txtNm1.Clear();
            }
        }

        private void txtNm2_TextChanged(object sender, EventArgs e)
        {
            if (!Validaciones.numeros(txtNm2.Text))
            {
                txtNm2.Clear();
            }
        }
        private void Suma()
        {
            try
            {
                int col = 0;
                for (int i = 0; i < Dgrid1.ColumnCount; i++)
                {

                    for (int y = 0; y < Dgrid1.Rows.Count; y++)
                    {
                        string sum1 = "";
                        string sum2 = "";
                        int suma = 0;
                        sum1 = Dgrid1.Rows[y].Cells[col].Value.ToString();
                        sum2 = Dgrid2.Rows[y].Cells[col].Value.ToString();
                        suma = Int32.Parse(sum1) + Int32.Parse(sum2);
                        Dgrid3.Rows[y].Cells[col].Value = suma.ToString();
                    }

                    col++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Se encontro un Caracter no valido");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void txtNm2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Suma();
            }
        }
    }
}
