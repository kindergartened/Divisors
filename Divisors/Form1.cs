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
                    MessageBox.Show("� ���� ����������� ����� ���������!");
                }
                else if (d == 0)
                {
                    MessageBox.Show("�� ���� ������ ������!");
                }
                else
                {
                    if (IsDivisor(d, n))
                        MessageBox.Show($"����� {d} �������� ��������� ����� {n}");
                    else
                        MessageBox.Show($"����� {d} �� �������� ��������� ����� {n}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("����������, ������� �����!");
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
                    richTextBox1.Text = "��������� ���� �������� ��� �����";
                }
                else if (n < 0)
                {
                    MessageBox.Show("������� ������������� �����!");
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
                MessageBox.Show("����������, ������� �����!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox4.Text);
                if (IsPrime(n))
                    MessageBox.Show("����� �������");
                else
                    MessageBox.Show("����� �� �������� �������");
            }
            catch (Exception)
            {
                MessageBox.Show("����������, ������� �����!");
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
                    MessageBox.Show("����� ������ ������� ������ ���� < ����� ������� �������");
                }
                else if (n < 0)
                {
                    MessageBox.Show("������� ������ ���� ��������������");
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
                MessageBox.Show("����������, ������� �����!");
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
                    MessageBox.Show("������ ����� ���������� ������� �� ��������� ������� �����. ����������, ������� ������������� �����");
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
                MessageBox.Show("����������, ������� �����!");
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
                    MessageBox.Show("����� ������ ������� ������ ���� < ����� ������� �������");
                }
                else if (start <= 0)
                {
                    MessageBox.Show("������� ������ ���� �������������� �������");
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
                MessageBox.Show("����������, ������� �����!");
            }
        }
    }

}