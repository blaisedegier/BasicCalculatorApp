namespace CalculatorApp
{
    // Delegate for arithmetic operations
    public delegate int Calculate(int num1, int num2);

    // Class for calculator
    class Calculator
    {
        // Event to modify operation performed
        public event Calculate? Operation;
        // Method to invoke the Operation event
        public void InvokeOperation(int num1, int num2) => Operation?.Invoke(num1, num2);

        // Methods for arithmetic operations
        // Add method
        public int Add(int num1, int num2) => num1 + num2;

        // Subtract method
        public int Subtract(int num1, int num2) => num1 - num2;

        // Multiply method
        public int Multiply(int num1, int num2) => num1 * num2;

        // Divide method
        public int Divide(int num1, int num2) => num1 / num2;
    }
}
