using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Završni_projekt__Loto
{
  
    
    public partial class Form1 : Form
    {
        int i = 0;
        int[] kuglice = new int[6];
        private int[] popuni_kuglice()
        {
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                kuglice[i] = random.Next(1, 37);
                if (i > 0)
                    for (int j = 0; j < i; j++) 
                    {
                        if (kuglice[i] == kuglice[j])
                        { 
                            kuglice[i] = random.Next(1, 37);
                            j = 0;
                        }
                    }
            }
            return kuglice;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //defaultno prikazuje nulu
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (i)
            {
                case 0:
                    popuni_kuglice();
                    textBox2.Text = "0";
                    textBox3.Text = "0";
                    textBox4.Text = "0";
                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox1.Text = "Izvlačenje!";
                    i++;
                    break;
                case 1:
                    textBox2.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Prvi broj!";
                    label7.Text = "Izvućen jedan broj:";
                    i++;
                    break;
                case 2:
                    textBox3.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Drugi broj!";
                    label7.Text = "Izvućena dva broja:";
                    i++;
                    break;
                case 3:
                    textBox4.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Treći broj!";
                    label7.Text = "Izvućena tri broja:";
                    i++;
                    break;
                case 4:
                    textBox5.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Četvrti broj!";
                    label7.Text = "Izvućena četiri broja:";
                    i++;
                    break;
                case 5:
                    textBox6.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Peti broj!";
                    label7.Text = "Izvućena 5 brojeva:";
                    i++;
                    break;
                case 6:
                    textBox7.Text = kuglice[i-1].ToString();
                    textBox1.Text = "Dodatni broj!";
                    label7.Text = "Izračun:";
                    i++;
                    break;
                default:
                    textBox1.Text = textBox2.Text + ',' + textBox3.Text + ',' + textBox4.Text + ',' + textBox5.Text + ',' + textBox6.Text + "+" + textBox7.Text;
                    label7.Text = "Rezultati izvlačenja:";
                    i = 0;
                    break;

            }
            
        }
    }
}
