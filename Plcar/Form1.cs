using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plcar
{
    public partial class Form1 : Form


    {

        Random random = new Random();
        int segundos = 0;
        int minutos = 0;
        int gol = 0;
        int gols_time1 = 0;
        int gols_time2 = 0;
        string pt1 = "";
        string pt2 = "";
        string resul_min = "";
        string[] Jogadores_Arsenal = {"G.Jesus","G.Martinelli","Saka"};
        string[] Jogadores_Chelsea = { "C.Palmer", "Mudryk", "N.Jackson" };


        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gool do Arsenal!!");
            int resultado = int.Parse(label3.Text);
            resultado++;
            label3.Text = resultado.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int resultado = int.Parse(label3.Text);
            resultado--;
            if (resultado < 0)
            {
                MessageBox.Show("Operação Inválida");

            }
            else
            {
                label3.Text= resultado.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gool do Chelsea!!");
            int resultado = int.Parse(label5.Text);
            resultado++;
            label5.Text = resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(label5.Text);
            resultado--;
            if (resultado < 0)
            {
                MessageBox.Show("Operação Inválida");

            }
            else
            {
                label5.Text = resultado.ToString();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minutos < 10)
            {
                resul_min = minutos.ToString();
                pt1 = "0" + resul_min + ":";

            }
            else
            {
                pt1 = minutos.ToString()+":";
            }
            if (segundos < 10)
            {
                resul_min = segundos.ToString();
                pt2 = "0" + resul_min; 

            }
            else
            {
                pt2 = segundos.ToString();
            }
            label1.Text = pt1 + pt2;
            segundos++;
            if (segundos == 60)
            {
                segundos= 0;
                minutos++;
            }
            gol = gols_time1;
            gols_time1 += Arsenal();
            if (gol < gols_time1)

            {
                label3.Text = gols_time1.ToString();
                
                int jogador_random = random.Next(0, 3);
                string jogador = Jogadores_Arsenal[jogador_random];
                if (jogador == label14.Text)
                {
                    label14.Text += " '" + minutos.ToString();
                    label14.Visible = true;

                }
                else if(jogador == label13.Text)
                {
                    label13.Text += " '" + minutos.ToString();
                    label13.Visible = true;

                }
                else
                {
                    label15.Text += " '" + minutos.ToString();
                    label15.Visible = true;
                }
                


            }
            gol = gols_time2;
            gols_time2 += Chelsea();
            if (gol < gols_time2)
            {
                label5.Text = gols_time2.ToString();
                int jogador_random = random.Next(0, 3);
                string jogador = Jogadores_Chelsea[jogador_random];
                if (jogador == label16.Text)
                {
                    label16.Text += " '" + minutos.ToString();
                    label16.Visible = true;

                }
                else if (jogador == label17.Text)
                {
                    label17.Text += " '" + minutos.ToString();
                    label17.Visible = true;

                }
                else
                {
                    label18.Text += " '" + minutos.ToString();
                    label18.Visible = true;
                }


            }
            if (label1.Text == "45:00")
            {
                timer1.Enabled = false;
                label6.Text = "2° Tempo";
                MessageBox.Show("Fim do primeiro tempo");


            }
            if (label1.Text == "90:00")
            {
                timer1.Enabled = false;
                label6.Text = "1° Tempo";
                MessageBox.Show("Fim de Jogo");
                gols_time1 = 0;
                gols_time2 = 0;
                label3.Text = "0";
                label5.Text = "0";
                segundos = 0;
                minutos = 0;
                




            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled=true;


        }
        private int Arsenal()
        {
            
            int valor =  random.Next(1, 1000);
            if (valor == 50)
            {
                return 1;
            }
            return 0;

        }
        private int Chelsea()
        {
            
            int valor = random.Next(1, 1500);
            if (valor == 50)
            {
                return 1;
            }
            return 0;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
            

        }

        private void label16_Click(object sender, EventArgs e)
        {
            

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            
        }
    }


}
