using static Lib.Class1;

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
                int n = Convert.ToInt32(textBox1);
                int d = Convert.ToInt32(textBox2);
                if (IsDivisor(d, n))
                    MessageBox.Show("делится");
                else
                    MessageBox.Show("не делится");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n=Convert.ToInt32(textBox3);
                string result = Convert.ToString(AllDivisors(n));
                richTextBox1.Text=result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox4);
                if (IsPrime(n))
                    MessageBox.Show("Число простое");
                else
                    MessageBox.Show("Число не является простым");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int n= Convert.ToInt32(textBox5);
                int m=Convert.ToInt32(textBox6);
                string result= Convert.ToString(PrimeInRange(n,m));
                richTextBox2.Text=result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }

}