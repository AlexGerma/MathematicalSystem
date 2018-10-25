using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace EstructuraDatos
{
    public partial class FrmMemorama : Form
    {
        int minutos = 0;
        int tiempo = 0;
        List<PictureBox> lista = new List<PictureBox>();
        int[] cartas = { 0, 0, 1,1,2,2,3,3,4,4,5,5,6,6,7,7 };
        private bool estado = false;
        private int indiceTmp = 0;
        private PictureBox pcbTmp = null;
        private string name;
        private int contador;
        private int intentos;
        public FrmMemorama()
        {
            InitializeComponent(); lista.Add(pcb0); lista.Add(pcb1);   lista.Add(pcb2);  lista.Add(pcb3); lista.Add(pcb4); lista.Add(pcb5);  lista.Add(pcb6);  lista.Add(pcb7); lista.Add(pcb8);  lista.Add(pcb9);
            lista.Add(pcb10);  lista.Add(pcb11);
           lista.Add(pcb12); lista.Add(pcb13);
          lista.Add(pcb14);  lista.Add(pcb15);
            
        }
        public void SetValores(String Nom)
        {
            this.name = Nom;
        }
        private void flip(PictureBox pcb, int i)
        {
           // MessageBox.Show(cartas[i].ToString());
              switch (cartas[i])
            {
                case 0:
                    pcb.Image = EstructuraDatos.Properties.Resources._01;
                    break;

                case 1:
                    pcb.Image = EstructuraDatos.Properties.Resources._02;
                    break;
                case 2:
                    pcb.Image = EstructuraDatos.Properties.Resources._03;
                    break;
                case 3:
                    pcb.Image = EstructuraDatos.Properties.Resources._04;
                    break;
                case 4:
                    pcb.Image = EstructuraDatos.Properties.Resources._05;
                    break;
                case 5:
                    pcb.Image = EstructuraDatos.Properties.Resources._06;
                    break;
                case 6:
                    pcb.Image = EstructuraDatos.Properties.Resources._07;
                    break;
                case 7:
                    pcb.Image = EstructuraDatos.Properties.Resources._08;
                    break;
                       
            }
            pcb.Update();
            if (!estado)
            {
                estado = true;
                indiceTmp = i;
                pcbTmp = pcb;
                pcbTmp.Enabled = false;
              
            }
            else
            {
                if (cartas[i] == cartas[indiceTmp])
                {
                   // MessageBox.Show("Part" );
                    pcb.Enabled = false;
                    pcb.Visible = false;
                    pcbTmp.Enabled = false;
                    pcbTmp.Visible = false;
                    contador = contador + 1;
                    if (contador ==8)
                    {
                        if (intentos == 0)
                        {
                            MessageBox.Show("Hijo(a) mío, la felicidad está hecha de pequeñas cosas, un pequeño yate, una pequeña mansión, una pequeña fortuna <GANASTE AL PRIMER INTENTO>", "Felicidades");
                        }
                        else if (intentos > 0 && intentos <= 10)
                        {
                            MessageBox.Show("Si las palabras tiene poder, imagínate el poder que tiene una acción.", "demaciados intentos MAS DE 10 intentos");
                        }
                        else
                        {
                            MessageBox.Show("Muy mal","Pesimooo Demaciadoos Intentos");
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("Era mentiraa");
                    Thread.Sleep(1000);
                    pcb.Image = EstructuraDatos.Properties.Resources.reverso;
                    pcbTmp.Image =  EstructuraDatos.Properties.Resources.reverso;
                    pcbTmp.Enabled = true;
                    intentos = intentos + 1;
                }
                estado = false;
            }
                
            
        }
        private void reset()
        {
            
            foreach (PictureBox pn in lista)
            {
                pn.Image = EstructuraDatos.Properties.Resources.reverso;
                pn.Visible = true;
                pn.Enabled = true;
            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            reset();
            FrmMemorama_Load(sender, e);
            
        }

        private void FrmMemorama_Load(object sender, EventArgs e)
        {
            cartas = cartas.OrderBy(s=>Guid.NewGuid()).ToArray();

            lbName.Text = name;
        }

        private void pcb0_Click(object sender, EventArgs e)
        {
            flip(pcb0,0);
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            flip(pcb1, 1);

        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            flip(pcb2, 2);

        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            flip(pcb3, 3);

        }

        private void pcb4_Click(object sender, EventArgs e)
        {
            flip(pcb4, 4);

        }

        private void pcb5_Click(object sender, EventArgs e)
        {
            flip(pcb5, 5);

        }

        private void pcb6_Click(object sender, EventArgs e)
        {
            flip(pcb6, 6);

        }

        private void pcb7_Click(object sender, EventArgs e)
        {
            flip(pcb7, 7);

        }

        private void pcb8_Click(object sender, EventArgs e)
        {
            flip(pcb8, 8);

        }

        private void pcb9_Click(object sender, EventArgs e)
        {
            flip(pcb9, 9);

        }

        private void pcb10_Click(object sender, EventArgs e)
        {
            flip(pcb10, 10);

        }

        private void pcb11_Click(object sender, EventArgs e)
        {
            flip(pcb11, 11);

        }

        private void pcb12_Click(object sender, EventArgs e)
        {
            flip(pcb12, 12);

        }

        private void pcb13_Click(object sender, EventArgs e)
        {
            flip(pcb13, 13);

        }

        private void pcb14_Click(object sender, EventArgs e)
        {
            flip(pcb14, 14);

        }

        private void pcb15_Click(object sender, EventArgs e)
        {
            flip(pcb15, 15);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lbTimer.Text = tiempo.ToString();
            if (tiempo.ToString() == "60")
            {
                minutos++;
                lbTimer.Text = minutos + ";" + tiempo.ToString();
                tiempo = 0;
            }
            else
            {
                lbTimer.Text = minutos + ";" + tiempo.ToString();
            }
           
        }
    }
}
