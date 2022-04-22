using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_17_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] A = readMatrix(textBox1);
            int[][] B = readMatrix(textBox2);
            int[][] C = matrixmMutiplication(A, B);
            printMatrix(textBox3, C);
        }

        private int[][] readMatrix(System.Windows.Forms.TextBox textBox)
        {
            string str = textBox.Text;
            string[] rowArray = str.Split('\n');
            int[][] matrix = new int[rowArray.Length][];
            for(int i = 0; i < rowArray.Length; i++)
            {
                string[] strArray = rowArray[i].Split(' ');
                matrix[i] = new int[strArray.Length];
                for(int j = 0; j < strArray.Length; j++)
                {
                    matrix[i][j] = Convert.ToInt32(strArray[j]);
                }
            }
            return matrix;
        }

        private void printMatrix(System.Windows.Forms.TextBox textBox, int[][] matrix)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    stringBuilder.Append(matrix[i][j]);
                    stringBuilder.Append(' ');
                }
                stringBuilder.Append(Environment.NewLine);
            }
            textBox.Text = stringBuilder.ToString();
        }

        private int[][] matrixmMutiplication(int[][] A, int[][] B)
        {
            int[][] newMatrix = new int[A[0].Length][];
            for(int i = 0; i < newMatrix.Length; i++)
            {
                newMatrix[i] = new int[B.Length];
                for(int j = 0; j < newMatrix[i].Length; j++)
                {
                    newMatrix[i][j] = 0;
                    for(int k = 0; k < B.Length; k++)
                    {
                        newMatrix[i][j] += A[i][k] * B[k][j];
                    }
                }
            }
            return newMatrix;
        }
    }
}
