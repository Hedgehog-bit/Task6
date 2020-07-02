using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(1, 7);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                textBox1.Text += mas[i].ToString() + " ";
            }
            textBox1.Text += Environment.NewLine;
            for (int i = 0; i < n; i++)
            {
                sum += mas[i];
            }
            if ((sum > 9) && (sum < 100))
            {
                textBox1.Text += "Сумма является двузначным числом";
            }
            else textBox1.Text += "Сумма НЕ является двузначным числом";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int column = int.Parse(textBox5.Text);
            int line = int.Parse(textBox6.Text);
            int[,] dmas = new int[column, line];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    dmas[i, j] = rand.Next(1, 7);
                }
            }
            int sum = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    sum += dmas[i, j];
                }
            }
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    textBox4.Text += dmas[i, j].ToString() + " "; 
                }
                textBox4.Text += Environment.NewLine;
            }
            if ((sum > 9) && (sum < 100))
            {
                textBox4.Text += "Сумма является двузначным числом";
            }
            else textBox4.Text += "Сумма НЕ является двузначным числом";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n2 = int.Parse(textBox3.Text);
            int[] mas2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                mas2[i] = rand.Next(1, 7);
            }
            for (int i = 0; i < n2; i++)
            {
                textBox7.Text += mas2[i].ToString() + " ";
            }
            textBox7.Text += Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < n2; i++)
            {
                if (mas2[i] > mas2[i - 1])
                {
                    counter++;
                }
            }
            textBox7.Text += "Кол-во элементов, значения которых больше значения предыдущего элемента = " + counter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int column3 = int.Parse(textBox9.Text);
            int line3 = int.Parse(textBox8.Text);
            int[,] dmas3 = new int[column3, line3];
            int counter = 0;
            for (int i = 0; i < column3; i++)
            {
                for (int j = 0; j < line3; j++)
                {
                    dmas3[i, j] = rand.Next(-5, 7);
                }
            }
            for (int i = 0; i < column3; i++)
            {
                for (int j = 0; j < line3; j++)
                {
                    textBox10.Text += dmas3[i, j].ToString() + " ";
                }
                textBox10.Text += Environment.NewLine;
            }
            for (int i = 0; i < column3; i++)
            {
                for (int j = 0; j < line3; j++)
                {
                    if (dmas3[i, j] < 0)
                    {
                        counter = 0;
                        for (int a = 0; a < column3; a++)
                        {
                            if (dmas3[a, j] < 0)
                            {
                                counter++;
                            }
                            if (counter == column3)
                            {
                                textBox10.Text += "Столбец состоит из отрицательных значений";
                            }
                        }
                    }
                    if (counter == column3)
                        break;
                }
                if (counter == column3)
                    break;
                else
                {
                    textBox10.Text += "Нет столбца с отрицательными значениями";
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int column4 = int.Parse(textBox11.Text);
            int[][] dmas4 = new int[column4][];
            for (int i = 0; i < column4; ++i)
            {
                dmas4[i] = new int[column4];
                for (int j = 0; j < column4; ++j)
                {
                    dmas4[i][j] = rand.Next(-5, 7);
                }
            }
            for (int i = 0; i < column4; i++)
            {
                for (int j = 0; j < column4; j++)
                {
                    textBox12.Text += dmas4[i][j].ToString() + " ";
                }
                textBox12.Text += Environment.NewLine;
            }
            int[] array = new int[column4];
            for (int i = 0; i < column4; i++)
            {
                array[i] = 1;
            }
            for (int i = 0; i < column4; ++i)
            {
                for (int j = 0; j < column4; ++j)
                {
                    array[i] *= dmas4[j][i];
                }
            }
            int min = array[0];
            for (int i = 1; i < column4; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            textBox12.Text += "Минимальный элемент: " + min;
        }
    }
}
