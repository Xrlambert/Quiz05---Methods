using System.Net.Http.Headers;

namespace Quiz05___Methods
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Task.Delay(500).Wait();
            Form3.flash();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            rand.Next();
            outputLabel.Text = rand.Next(1, 11).ToString();
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber();
        }

        public long productNumber()
        {
            long product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product = product * i;
            }
            outputLabel.Text = product.ToString();
            return product;
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) && double.TryParse(bTextBox.Text, out double b))
            {
                Pythagorean(a, b);
            }
            else
            {
                outputLabel.Text = "Invalid input.";
            }
        }

        public double Pythagorean(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            outputLabel.Text = c.ToString();
            return c;
        }
    }
}
