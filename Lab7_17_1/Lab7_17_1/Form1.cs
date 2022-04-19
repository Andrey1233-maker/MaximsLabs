using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_17_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputDigits();
        }

        private void outputDigits()
        {
            StringBuilder digitsString = new StringBuilder("");
            for(int i = 1; i < 8; i++)
            { 
                for(int j = i + 1; j < 9; j++)
                {
                    for(int k = j + 1; k < 10; k++)
                    {
                        if(i != j && i != k && j != k)
                        {
                            digitsString.Append(i);
                            digitsString.Append(j);
                            digitsString.Append(k);
                            digitsString.Append(' ');
                        }
                    }
                }
            }

            textBox1.Text = digitsString.ToString();
        }
    }
}
