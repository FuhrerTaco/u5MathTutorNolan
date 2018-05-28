/**
 * Written by Nolan Meehan 
 * Asks the user for the answer of a simple math problem rounds to the nearest tenth.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u5MathTutorNolan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            char[] operators = { '*', '+', '-', '/' };
            int num1 = r.Next(1, 11);
            int num2 = r.Next(1, 11);
            double answer = 0;
            char oper = '/';//operators[r.Next(operators.Length)];
            switch (oper)
            {
                case '*':
                    answer = num1 * num2;
                    break;
                case '/':
                    answer = (double)num1 / num2;
                    break;
                case '-':
                    answer = num1 - num2;
                    break;
                case '+':
                    answer = num2 + num1;
                    break;
            }
            answer = Math.Round(answer, 1);
            Console.WriteLine(String.Format("What's {0} {1} {2}?",num1,oper,num2));
            if (Math.Round(double.Parse(Console.ReadLine()), 1) == answer) Console.WriteLine("Correct!");
            else Console.WriteLine("Nope! Answer is " + answer);
            Console.ReadLine();
        }
    }
}
