using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            String equation = Console.ReadLine();
            String[] parts = equation.Split(' ');

            int num1 = Convert.ToInt32(parts[0]);
            String operater = parts[1];
            int num2 = Convert.ToInt32(parts[2]);
            int answer = 0;


            if (operater == "+")
            {
                answer = num1 + num2;
            }

            if (operater == "-")
            {
                answer = num1 - num2;
            }

            if (operater == "*")
            {
                answer = num1 * num2;
            }

            if (operater == "/")
            {
                answer = num1 / num2;
            }

            Console.WriteLine("Result: " + equation + " = " + answer);

        }
    }
}
