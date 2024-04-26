using System.Text;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        StringBuilder output = new StringBuilder();
        int num1;
        int num2;
        Arithmetic? operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            output.Append("0");
            txtOutput.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            output.Append("1");
            txtOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            output.Append("2");
            txtOutput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            output.Append("3");
            txtOutput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            output.Append("4");
            txtOutput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            output.Append("5");
            txtOutput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            output.Append("6");
            txtOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            output.Append("7");
            txtOutput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            output.Append("8");
            txtOutput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            output.Append("9");
            txtOutput.Text += "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int.TryParse(output.ToString(), out num1);
            output.Clear();
            operation = calculator.Add;
            txtOutput.Text += " + ";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int.TryParse(output.ToString(), out num1);
            output.Clear();
            operation = calculator.Subtract;
            txtOutput.Text += " - ";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int.TryParse(output.ToString(), out num1);
            output.Clear();
            operation = calculator.Multiply;
            txtOutput.Text += " X ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int.TryParse(output.ToString(), out num1);
            output.Clear();
            operation = calculator.Divide;
            txtOutput.Text += " ÷ ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
                int.TryParse(output.ToString(), out num2);
                int result = operation(num1, num2);
                txtOutput.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            output.Clear();
            operation = null;
            txtOutput.Text = "";
        }
    }
}
