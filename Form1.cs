namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        float no1, no2;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToSingle(this.textBox1.Text);
            double ans = 0.00;
            if (op =="+")
            {
                ans = no1 + no2;

            }
            else if (op =="-")
            {
                ans = no1 - no2;
            }
            else if(op =="*")
            {
                ans = no1 * no2;
            }
            else if (op=="/")
            {
                ans = no1 / no2;    
            }
            this.textBox1.Text = ans.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(this.textBox1.Text);
            op = "+";
            this.textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(this.textBox1.Text);
            op = "-";
            this.textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(this.textBox1.Text);
            op = "*";
            this.textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(this.textBox1.Text);
            op = "/";
            this.textBox1.Clear();
        }
    }
}