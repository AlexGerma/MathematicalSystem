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
    public partial class FrmBinario : Form
    {
        private int[] valores;
        public FrmBinario()
        {
            InitializeComponent();
        }

        private void btnRambom_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            valores = new int[int.Parse(txtNum1.Text)];
            for (int i = 0; i < Convert.ToInt32(txtNum1.Text); i++)
            {
                valores[i] = r.Next(0, Convert.ToInt32(txtNum2.Text));
                //DgridNumeros.Rows.Add(r.Next(0, Convert.ToInt32(txtNum2.Text)).ToString());


            }
            
            Array.Sort(valores);

            DgridNumeros.DataSource = valores.Select(x => new { Elementos = x }).ToList();
            setRowNumber(DgridNumeros);
        }

        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtBuscar.Clear();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.TextLength == 1)
            {
                if (txtNum1.Text == "0")
                {
                    txtNum1.Clear();
                }
               
            }
            if (!Validaciones.numeros(txtNum1.Text))
            {
                txtNum1.Clear();
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (txtNum2.TextLength == 1)
            {
                if (txtNum2.Text == "0")
                {
                    txtNum2.Clear();
                }

            }
            if (!Validaciones.numeros(txtNum2.Text))
            {
                txtNum2.Clear();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength == 1)
            {
                if (txtBuscar.Text == "0")
                {
                    txtBuscar.Clear();
                }

            }
            if (!Validaciones.numeros(txtBuscar.Text))
            {
                txtBuscar.Clear();
            }
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        private void DgridNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static object Busqueda(int[]num,int key)
        {
            try
            {
                int minimo = 0;
                int maximo = num.Length - 1;
                while (minimo <= maximo)
                {
                    int mitad = (minimo + maximo) / 2;
                    if (key == num[mitad])
                    {
                        ++mitad;
                        return "Esta en la posicion" + mitad;
                    }
                    else if (key < num[mitad])
                    {
                        maximo = mitad - 1;
                    }
                    else
                    {
                        minimo = mitad + 1;
                    }
                }
                
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return "no esta";
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbError.Text = Convert.ToString(Busqueda(valores,Int32.Parse( txtBuscar.Text)));
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }
    }
}
