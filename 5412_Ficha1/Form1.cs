using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5412_Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            selecionaImagem(equipaA, pictureBox1);
            selecionaImagem(equipaB, pictureBox2);

        }

        private void selecionaImagem(Label equipa, PictureBox pictureBox)
        {
            if (equipa.Text == "Arouca")
            {
                pictureBox.Image = Properties.Resources.Arouca;
            }
            if (equipa.Text == "Benfica")
            {
                pictureBox.Image = Properties.Resources.Benfica;
            }
            if (equipa.Text == "Famalicao")
            {
                pictureBox.Image = Properties.Resources.Famalicao;
            }
            if (equipa.Text == "Porto")
            {
                pictureBox.Image = Properties.Resources.Porto;
            }
            if (equipa.Text == "Sporting")
            {
                pictureBox.Image = Properties.Resources.Sporting;
            }
            if (equipa.Text == "Tondela")
            {
                pictureBox.Image = Properties.Resources.Tondela;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ScoreA.Text = (int.Parse(ScoreA.Text) + 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int texto = int.Parse(ScoreA.Text);
            if (texto > 0){
                ScoreA.Text = (texto - 1).ToString();
            }

        }

        private void cliqueAqui(object sender, EventArgs e)
        {
            ScoreB.Text = (int.Parse(ScoreB.Text) + 1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
            int min = 0;
            int seg = 0;
            private void timer1_Tick(object sender, EventArgs e)
                { if (min < 90)
                {
                    if (seg < 59)
                    {
                        seg++; 
                    }
                    else if(seg == 59)
                        { 
                        seg = 0;
                        min++; 
                    }
                } labelTempo.Text = min + ":" + seg;

            if (min==45 && seg==0)
            {
                parte.Text = "2ª parte";
            }
        }

            


        private void menosB_Click(object sender, EventArgs e)
        {
            int texto = int.Parse(ScoreB.Text);
            if (texto > 0)
            {
                ScoreB.Text = (texto - 1).ToString();
            }
        }

        private void equipaA_Click(object sender, EventArgs e)
        {
           
        }
    }
}
