using System;
using System.Windows.Forms;
using org.matheval;

namespace Calculator
{
    public partial class Scientific : Form
    {
        public Scientific()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("^");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text.Length > 0)
            {
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                Expression expression = new Expression(textBox1.Text);
                textBox1.AppendText("=" + expression.Eval());
            }
            catch
            {
                textBox1.AppendText("=Invalid syntax");
            }
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form scientific = new Form();
            this.Hide();
            scientific.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("(");
        }

        private void buttonClosePar_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(")");
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("sin");
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("cos");
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("tan");
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator standart = new Calculator();
            this.Hide();
            standart.Show();
        }

        private void Scientific_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
