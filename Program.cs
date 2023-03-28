using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KZK03272023_PracticeGithubOnVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int x = Calculator.Addition(1, 1);
            Console.WriteLine("1 + 1 = " + x);

            int y = Calculator.Subtraction(1, 1);
            Console.WriteLine("1 - 1 = " + y);

            int z = Calculator.Multiply(3, 2);
            Console.WriteLine("3 * 2 = " + z);

            int v = Calculator.Divide(6, 2);
            Console.WriteLine("6 / 2 = " + v);

            int b = Calculator.Modulo(7, 2);
            Console.WriteLine("7 % 2 = " + b);
            Console.ReadLine();

            //ADDED COMMENT!!!
            //ADDED COMMENT2!!
            //Add directly to master remote comment
            //Add directly to master remote comment 2
            //RYN CHANGE!!
        }
    }
}
