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
                if (IsDivisor(d, n))
                    MessageBox.Show("�������");
                else
                    MessageBox.Show("�� �������");
            }
            catch (Exception)
            {
                MessageBox.Show("������");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int n=Convert.ToInt32(textBox3.Text);
                List<int> result = AllDivisors(n);
                result.Sort();
                foreach (int i in result)
                {
                    richTextBox1.AppendText(i.ToString() + " ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("������");
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
                MessageBox.Show("������");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();
                int n= Convert.ToInt32(textBox5.Text);
                int m=Convert.ToInt32(textBox6.Text);
                List<int> result= PrimeInRange(n,m);
                foreach(int i in result)
                {
                   richTextBox2.AppendText(i.ToString()+" ");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("������");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> primes,factors;
                int n=Convert.ToInt32(textBox9.Text);
               
            }
            catch (Exception)
            {
                MessageBox.Show("������");
            }
        }
    }

}