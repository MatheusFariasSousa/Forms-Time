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
        int segundos = 0;
        int minutos = 0;
        int gols_time1 = 0;
        int gols_time2 = 0;
        string pt1 = "";
        string pt2 = "";
            
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
                string resul_min = minutos.ToString();
                pt1 = "0" + resul_min + ":";

            }
            else
            {
                pt1 = minutos.ToString();
            }
            if (segundos < 10)
            {
                string resul_min = segundos.ToString();
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
            gols_time1 += Arsenal();
            gols_time2 += Chelsea();
            label3.Text = gols_time1.ToString();
            label5.Text = gols_time2.ToString();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled=true;


        }
        private int Arsenal()
        {
            Random random = new Random();
            int valor =  random.Next(1, 100);
            if (valor == 50)
            {
                return 1;
            }
            return 0;

        }
        private int Chelsea()
        {
            Random random = new Random();
            int valor = random.Next(1, 150);
            if (valor == 100)
            {
                return 1;
            }
            return 0;

        }
 
        


    }


}
