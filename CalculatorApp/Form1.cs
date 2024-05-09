namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        // Variables to store numbers
        int num1, num2;
        // Object of Calculator class
        Calculator calculator = new Calculator();
        // Delegate for arithmetic operations
        Calculate? operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get numbers
            num1 = (int)numNum1.Value;
            num2 = (int)numNum2.Value;

            // Unsubscribe from event
            calculator.Operation -= operation;

            // Perform operation
            switch (cmbOperation.Text)
            {
                case "+":
                    operation = calculator.Add;
                    break;
                case "-":
                    operation = calculator.Subtract;
                    break;
                case "*":
                    operation = calculator.Multiply;
                    break;
                case "/":
                    operation = calculator.Divide;
                    break;
                default:
                    MessageBox.Show("Please select a valid operation");
                    return;
            }

            // Subscribe to event
            calculator.Operation += operation;

            // Perform operation and display result
            try
            {
                int result = operation(num1, num2);
                calculator.InvokeOperation(num1, num2);
                lblOutput.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear numbers and output
            numNum1.Value = 0;
            numNum2.Value = 0;
            lblOutput.Text = "";
            cmbOperation.Text = "";
        }
    }
}
