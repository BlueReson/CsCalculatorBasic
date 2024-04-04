namespace CsCalculatorBasic
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void bPlus_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double sum = val1 + val2;

            textBox3.Text = sum.ToString();
        }


        private void bMinus_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double min = val1 - val2;

            textBox3.Text = min.ToString();
        }

        private void bDiff_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double division = val1 / val2;

            textBox3.Text = division.ToString();
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double prod= val1 * val2;

            textBox3.Text = prod.ToString();
        }

        private void bPercent_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double perc = (val1 / val2)*100;

            textBox3.Text = perc.ToString();
        }

        
    }
}
