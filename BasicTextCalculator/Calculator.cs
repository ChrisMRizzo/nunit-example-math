using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTextCalculator
{
    public class Calculator
    {
        public bool Running = true;

        public void Run()
        {
            while (Running)
            {
                GetFormula();
            }
        }

        public void GetFormula()
        {
            Console.WriteLine("Please enter a simple math equation:");
            string input = Console.ReadLine();
            ParseAndCalculateInput(input);
        }

        public void ParseAndCalculateInput(string input)
        {
            input = input.Replace(" ", string.Empty);

            if (input == "exit")
            {
                Running = false;
                return;
            }

            var split = input.Split(new Char[] { '+', '-', '*', '/' });

            decimal a = Convert.ToDecimal(split[0]);
            decimal b = Convert.ToDecimal(split[1]);

            int symbolPlace = input.IndexOfAny(new Char[] { '+', '-', '*', '/' });
            var symbol = input[symbolPlace];

            decimal result;

            switch (symbol)
            {
                case '+':
                    result = AddNumbers(a, b);
                    break;
                case '-':
                    result = SubtractNumbers(a, b);
                    break;
                case '*':
                    result = MultiplyNumbers(a, b);
                    break;
                case '/':
                    result = DivideNumbers(a, b);
                    break;
                default:
                    throw new InvalidOperationException("Unknown operation");
            }

            Console.WriteLine("The answer is: " + result);
        }

        public decimal AddNumbers(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal SubtractNumbers(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal MultiplyNumbers(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal DivideNumbers(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
