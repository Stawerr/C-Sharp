using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _5412_Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            selecionaImagem(equipaA, pictureBox1);
            selecionaImagem(equipaB, pictureBox2);
            
                maisA.Enabled = false;
                maisB.Enabled = false;
                menosA.Enabled = false;
                menosB.Enabled = false;
           

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

        private void cliqueAqui(object sender, EventArgs e)
        {
            ScoreB.Text = (int.Parse(ScoreB.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int texto = int.Parse(ScoreA.Text);
            if (texto > 0){
                ScoreA.Text = (texto - 1).ToString();
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

            int min = 0;
            int seg = 0;
        private void inicio_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            inicio.Visible = false;
            maisA.Enabled = true;
            maisB.Enabled = true;
            menosA.Enabled = true;
            menosB.Enabled = true;
            if (min==90 && seg == 0)
            {
                min = 0;
                seg = 0;
                maisA.Enabled = true;
                maisB.Enabled = true;
                menosA.Enabled = true;
                menosB.Enabled = true;
                equipaA.Enabled = true;
                equipaB.Enabled = true;
                ScoreA.Text = "0";
                ScoreB.Text = "0";
            }
        }

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
                inicio.Text = "Começar 2ª parte";
            }

            if (min == 45 && seg == 00)
            {
                timer1.Stop();
                inicio.Visible = true;
            }
            if (min == 90 && seg == 00)
            {
                inicio.Visible = true;
                maisA.Enabled = false;
                maisB.Enabled = false;
                menosA.Enabled = false;
                menosB.Enabled = false;
                equipaA.Enabled = false;
                equipaB.Enabled = false;
                timer1.Stop();
            }
        }
        string texto;
        string[] linha;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.DefaultExt = "txt";
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            {
                texto = File.ReadAllText(filePath, Encoding.UTF8);
                linha = texto.Split(';');
                equipaA.Text = linha[0];
                ScoreA.Text = linha[1];
                equipaB.Text = linha[2];
                ScoreB.Text = linha[3];
                min = 0;
                seg = 0;
                selecionaImagem(equipaA, pictureBox1);
                selecionaImagem(equipaB, pictureBox2);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                texto = equipaA.Text + ";" + ScoreA.Text + ";" + equipaB.Text + ";" + ScoreB.Text;
                File.WriteAllText(saveFileDialog1.FileName, texto);
            }
            
        }
    }
}
