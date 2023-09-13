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
                long n = Convert.ToInt64(textBox1.Text);
                long d = Convert.ToInt64(textBox2.Text);
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!");
                }
                else if (d < 1 || d > long.MaxValue || n < 1 || n > long.MaxValue)
                {
                    MessageBox.Show("Недопустимое число! Введите числа >= 1!");
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
                long n = Convert.ToInt64(textBox3.Text);
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
                    foreach (long i in result)
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
                long n = Convert.ToInt64(textBox4.Text);
                if (n < 0)
                {
                    MessageBox.Show("Введите положительное число!");
                }
                else
                if (IsPrime(n))
                    MessageBox.Show("Является простым числом");
                else
                    MessageBox.Show("Не является простым числом");
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

                long n= Convert.ToInt64(textBox5.Text);
                long m=Convert.ToInt64(textBox6.Text);
                if (n > m)
                {
                    MessageBox.Show("Число нижней границы доолжно быть < числа верхней границы");
                }
                else if (n < 0)
                {
                    MessageBox.Show("Границы должны быть положительными");
                }
                else
                {
                    List<long> result = PrimeInRange(n, m);
                    foreach (long i in result)
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
                List<long> primes, factors;
                long n = Convert.ToInt64(textBox9.Text);
                if (n <= 0)
                {
                    MessageBox.Show("Данное число невозможно разделить на простые множители. Пожалуйста, введите положительное число");
                }
                else
                {
                    (primes, factors) = Factorization(n);
                    foreach (long i in primes)
                    {
                        textBox10.AppendText(i.ToString() + " ");
                    }
                    foreach (long i in factors)
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
                long start = Convert.ToInt64(textBox7.Text);
                long finish = Convert.ToInt64(textBox8.Text);
                List<long> result;
                if (start > finish)
                {
                    MessageBox.Show("Нижняя граница должна быть < верхней границы");
                }
                else if (start <= 0)
                {
                    MessageBox.Show("Границы должны быть положительными");
                }
                else
                {
                    result = GetNumsWith3Divisors(start, finish);
                    foreach (long i in result)
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