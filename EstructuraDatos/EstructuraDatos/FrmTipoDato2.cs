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
    public partial class FrmTipoDato2 : Form
    {
        int col;
        int ren;
        int dato;
        public FrmTipoDato2()
        {
            InitializeComponent();

        }


        public void SetValores(int tipo)
        {
            dato = tipo;
        }

        private void FrmTipoDato2_Load(object sender, EventArgs e)
        {
            lbElemento.Text = "Elemento [" + col + "," + ren + "]";
            DgridDato.Rows.Add();
            DgridDato.Rows.Add();
            DgridDato.Rows.Add();
            DgridDato[col, ren].Selected = false;
            if (dato == 1)
            {
                lbTipo.Text = "INT";
            }
            else if (dato == 2)
            {
                lbTipo.Text = "Double";
            }
            else if (dato == 3)
            {
                lbTipo.Text = "Decimal";
            }
            else if (dato == 4)
            {
                lbTipo.Text = "Char";
            }
            else if (dato == 5)
            {
                lbTipo.Text = "String";
            }
            else if (dato == 6)
            {
                lbTipo.Text = "Triangulo";
                gbxAltura.Visible = true;
                lbElemento.Visible = false;
                txtNumero.Visible = false;
                pictureBox2.Visible = false;


            }
            else if (dato == 7)
            {
                lbTipo.Text = "Punto Cartesiano";
                gbxAltura.Visible = true;
            }
        }

        private void DgridDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DgridDato[col, ren].Selected = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            DgridDato[col, ren].Selected = false;
            if (dato == 6)
            {
                DgridDato[col, ren].Value = new Triangulos(Convert.ToDouble(txtAltura.Text), Convert.ToDouble(txtBase.Text)); 

            }
            else
            {
                DgridDato[col, ren].Value = txtNumero.Text;
            }
           
            col++;

            if (col > 2)
            {
                col = 0;
                ren++;
            }
            if (ren == 3)
            {
                btnCapturar.Enabled = false;

            }
            else
            {
                lbElemento.Text = "Elemento [" + col + "," + ren + "]";
                DgridDato.CurrentCell = DgridDato[1, ren];
                DgridDato[col, ren].Selected = true;
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            col = 0;
            ren = 0;
            lbElemento.Text = "Elemento [" + col + "," + ren + "]";
            DgridDato.Rows.Clear();
            DgridDato.Rows.Add();
            DgridDato.Rows.Add();
            DgridDato.Rows.Add();
            DgridDato[col, ren].Selected = false;
            btnCapturar.Enabled = true;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)

        {
            if (dato == 1)
            {
                if (!Validaciones.numeros(txtNumero.Text))
                {
                    txtNumero.Clear();
                }
            }
            if (dato == 2)
            {
                if (!Validaciones.dooble(txtNumero.Text))
                {
                    txtNumero.Clear();
                }
            }
            if (dato == 3)
            {
                if (!Validaciones.Deecimal(txtNumero.Text))
                {
                    txtNumero.Clear();
                }
            }
            if (dato == 4)
            {
                if (!Validaciones.Cha(txtNumero.Text))
                {
                    txtNumero.Clear();
                }
            }
            if (dato == 5)
            {
                if (!Validaciones.letras(txtNumero.Text))
                {
                    txtNumero.Clear();
                }
            }
        }

        private void lbAltura_Click(object sender, EventArgs e)
        {

        }
        double bas, alt;
      
        private void DgridDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bas = 0; alt = 0;
             Triangulos tri = new Triangulos();
            //Triangulos da = new Triangulos();
            lbElemntoo.Text = "Elemento["+ DgridDato.CurrentCell.ColumnIndex + "," + DgridDato.CurrentRow.Index +"]=";
            lbSelect.Text = "" + tri.Altura1 + "," + tri.Base1;
            //MessageBox.Show(DgridDato.CurrentCell.Value.ToString());
            //lbSelect.Text= 
            
            
        }
    }
    public class Triangulos {
        private double Base;
        private double Altura;
        public Triangulos()
        {
        }
        public Triangulos(double bas, double alt)
        {
            Base1 = bas;
            Altura1 = alt;
        }

        public double Base1 { get => Base; set => Base = value; }
        public double Altura1 { get => Altura; set => Altura = value; }
    }
    public class PuntoCartesiano
    {
        private int x;
        private int y;
        public PuntoCartesiano()
        { }
        public PuntoCartesiano(int x, int y)
        {
         
            this.x = x;
            this.y = y;
        }
        

    }
}
