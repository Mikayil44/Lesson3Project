using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            box.Clear();
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (box.Text.Length > 0)
            {
                box.Text = box.Text.Substring(0, box.Text.Length - 1);
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            box.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            box.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            box.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            box.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            box.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            box.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            box.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            box.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            box.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            box.Text += "0";
        }

        private void dota_Click(object sender, EventArgs e)
        {
            box.Text += ",";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            box.Text += "+";
        }

        private void diff_Click(object sender, EventArgs e)
        {
            box.Text += "-";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            box.Text += "x";
        }

        private void div_Click(object sender, EventArgs e)
        {
            box.Text += "/";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double result = double.Parse(box.Text);
            result = (double)System.Math.Sqrt(result);
            box.Text = result.ToString();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string expression = box.Text.Replace("x", "*").Replace(",", ".");
            var result = new System.Data.DataTable().Compute(expression, null);
            box.Text = result.ToString();
        }
}
    }
