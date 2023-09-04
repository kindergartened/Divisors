using static Lib.Class1;
using System.Collections.Generic;

namespace Divisors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int d = Convert.ToInt32(textBox2.Text);
                if (n == 0)
                {
                    MessageBox.Show("У нуля бесконечное число делителей!");
                }
                else if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!");
                }
                else
                {
                    if (IsDivisor(d, n))
                        MessageBox.Show($"Число {d} является делителем числа {n}");
                    else
                        MessageBox.Show($"Число {d} не является делителем числа {n}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int n = Convert.ToInt32(textBox3.Text);
                if (n == 0)
                {
                    richTextBox1.Text = "Делителем нуля являются все числа";
                }
                else if (n < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                }
                else
                {
                    List<long> result = AllDivisors(n);
                    result.Sort();
                    foreach (int i in result)
                    {
                        richTextBox1.AppendText(i.ToString() + " ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox4.Text);
                if (IsPrime(n))
                    MessageBox.Show("Число простое");
                else
                    MessageBox.Show("Число не является простым");
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();
                int n = Convert.ToInt32(textBox5.Text);
                int m = Convert.ToInt32(textBox6.Text);
                if (n > m)
                {
                    MessageBox.Show("Число нижней границы должно быть < числа верхней границы");
                }
                else if (n < 0)
                {
                    MessageBox.Show("Границы должны быть положительными");
                }
                else
                {
                    List<int> result = PrimeInRange(n, m);
                    foreach (int i in result)
                    {
                        richTextBox2.AppendText(i.ToString() + " ");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox10.Clear();
                textBox11.Clear();
                List<int> primes, factors;
                int n = Convert.ToInt32(textBox9.Text);
                if (n <= 0)
                {
                    MessageBox.Show("Данное число невозможно разбить на множители простых чисел. Пожалуйста, введите положительное число");
                }
                else
                {
                    (primes, factors) = Factorization(n);
                    foreach (int i in primes)
                    {
                        textBox10.AppendText(i.ToString() + " ");
                    }
                    foreach (int i in factors)
                    {
                        textBox11.AppendText(i.ToString() + " ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox3.Clear();
                int start = Convert.ToInt32(textBox7.Text);
                int finish = Convert.ToInt32(textBox8.Text);
                List<int> result;
                if (start > finish)
                {
                    MessageBox.Show("Число нижней границы должно быть < числа верхней границы");
                }
                else if (start <= 0)
                {
                    MessageBox.Show("Границы должны быть положительными числами");
                }
                else
                {
                    result = GetNumsWith3Divisors(start, finish);
                    foreach (int i in result)
                    {
                        richTextBox3.AppendText(i.ToString() + " ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }
    }

}