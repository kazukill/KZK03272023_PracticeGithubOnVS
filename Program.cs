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
            Console.WriteLine(x);

            int y = Calculator.Subtraction(1, 1);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
