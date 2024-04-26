using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    // Delegate for arithmetic operations
    public delegate void Arithmetic(int num1, int num2);
    class Calculator
    {
        // Event to modify operation performed
        public event Arithmetic Operation;

        // Methods for arithmetic operations
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            Operation?.Invoke(num1, num2);
            return result;
        }

        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Operation?.Invoke(num1, num2);
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Operation?.Invoke(num1, num2);
            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Operation?.Invoke(num1, num2);
            return result;
        }
    }
}
