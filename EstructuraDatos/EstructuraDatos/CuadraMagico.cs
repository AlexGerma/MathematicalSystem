using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EstructuraDatos
{
    public partial class CuadraMagico : Form
    {
        public bool Flag = false;
        private int pos = 0;
        public CuadraMagico()
        {
            InitializeComponent();
        }
        private void Generador(int colm)
        {
            try
            {
                Dgrid1.Columns.Clear();

                for (int i = 0; i < colm; i++)
                {
                    Dgrid1.Columns.Add("", "Columna " + i);

                }
                for (int i = 0; i < colm; i++)
                {
                    Dgrid1.Rows.Add("");
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void FormNew()
        {
            try
            {
                string Algo = Interaction.InputBox("Cuantas Columnas y Rows deseas", "Generador", "");
                int Res = Int32.Parse(Algo);
                Generador(Res);
            }
            catch (Exception)
            {

                MessageBox.Show("Solo numero puedes ingresar");
                FormNew();
            }
            
        }
        private void CuadraMagico_Load(object sender, EventArgs e)
        {
            FormNew();  
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Dgrid1.ClearSelection();
            Dgrid1.Rows[2].Cells[1].Selected = true;
        }
        private void SumaRow()
        {
            try
            {
                int Row = 0;
                for (int i = 0; i < Dgrid1.RowCount; i++)
                {
                    int suma = 0;
                    for (int y = 0; y < Dgrid1.ColumnCount; y++)
                    {
                        string sum1 = "";
                        sum1 = Dgrid1.Rows[Row].Cells[y].Value.ToString();
                        if (sum1 == "")
                        {

                        }
                        else
                        {
                            suma = Int32.Parse(sum1) + suma;
                        }

                    }
                    MessageBox.Show(suma + "Fila "+ Row);
                    this.Dgrid1.Rows[Row].HeaderCell.Value = Convert.ToString(suma);
                    Row++;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Se encontro un String");
                
            }
            
        }

        private void SumaColumn()
        {
            try
            {
                int col = 0;
                for (int i = 0; i < Dgrid1.ColumnCount; i++)
                {
                    int suma = 0;
                    for (int y = 0; y < Dgrid1.RowCount; y++)
                    {
                        string sum1 = "";
                        sum1 = Dgrid1.Rows[y].Cells[col].Value.ToString();
                        if (sum1 == "")
                        {

                        }
                        else
                        {
                            suma = Int32.Parse(sum1) + suma;
                        }

                    }
                    MessageBox.Show(suma + " Columna "+col);
                    this.Dgrid1.Columns[col].HeaderText = Convert.ToString(suma);
                    col++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se encontro un String");

            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SumaRow();
            SumaColumn();
            DiagonalUno();
            DiagonalDos();
        }
        int sum;
        private void DiagonalUno()
        {
            string Suma = "";
            sum = 0;
            int col = 0;
            for (int i = 0; i < Dgrid1.RowCount; i++)
            {
                Suma = Dgrid1.Rows[i].Cells[col].Value.ToString();
                col++;
                sum = sum + Int32.Parse(Suma);
            }
            lbDiagonal.Text = sum.ToString();
            
        }
        private void DiagonalDos()
        {
            sum = 0;   
            string Suma = "";

            int col = Dgrid1.RowCount;
            for (int i = 0; i < Dgrid1.RowCount; i++)
            {
                Suma = Dgrid1.Rows[i].Cells[col].Value.ToString();
                col = col - 1;
                sum = sum + Int32.Parse(Suma);
            }
            lbDialogo1.Text = sum.ToString();
        }
        

        private void Dgrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = Dgrid1.CurrentRow.Cells[e.RowIndex].RowIndex;
        }

        

        private void Dgrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Valor = "";
            if (Dgrid1.CurrentRow.Cells[pos].Value is null)
            {

            }
            else
            {
                Valor = Dgrid1.CurrentRow.Cells[pos].Value.ToString();
                if (Validaciones.numeros(Valor))
                {


                }
                else
                {
                    if (Valor == "")
                    {

                    }
                    else
                    {
                        MessageBox.Show("Eaaa no puedes poner String" + pos);
                        Dgrid1.CurrentRow.Cells[pos].Value = "";

                        Flag = true;

                    }
                }
            }
            
            
        }

        private void Dgrid1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (Flag == true)
            {
                Dgrid1.ClearSelection();
                Dgrid1.Rows[2].Cells[2].Selected = true;
            }
            
        }
    }
}
