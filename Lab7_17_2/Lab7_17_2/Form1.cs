using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_17_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] inputArray = inputString();
            outputResult(inputArray);
        }

        private int[] inputString()
        {
            string inputString = textBox1.Text;
            string[] digitsStr = inputString.Split(' ');
            int[] result = new int[digitsStr.Length];
            for(int i = 0; i < digitsStr.Length; i++)
            {
                result[i] = int.Parse(digitsStr[i]);
            }
            return result;
        }

        private void outputResult(int[] a)
        {
            int currentE = a[a.Length - 1];
            for(int i = 0; i < a.Length; i++)
            {
                int t = currentE;
                currentE = a[i];
                a[i] = t;
            }
            StringBuilder result = new StringBuilder(" ");
            for(int i = 0; i < a.Length; i++)
            {
                result.Append(a[i]);
                result.Append(" ");
            }
            textBox2.Text =  result.ToString(); 
        }
    }
}
