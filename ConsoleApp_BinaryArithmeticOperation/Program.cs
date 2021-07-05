using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_BinaryArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Arithmetic Operation");
        start: string s = ReadLine();
            string[] nshan = s.Split('-', '+', '*', '/');
            int a = int.Parse(nshan[0]);
            int b = int.Parse(nshan[1]);

            int x = nshan[0].Length;
            switch (s[x])
            {
                case '+':
                    WriteLine(a + b);
                    break;
                case '-':
                    WriteLine(a - b);
                    break;
                case '*':
                    WriteLine(a * b);
                    break;
                case '/':
                    if (b != 0)
                    {
                        WriteLine(a / b);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero");
                    }
                    break;
            }
            Console.WriteLine(new string('-', 10));
            goto start;
        }
    }
}
