using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample;

namespace UnitTestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            var sum = calc.Add(5, 8);
            var dif = calc.Subtract(7, 2);
            var mul = calc.Multiply(5, 0);
            //var div = calc.Divide(6, 3);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + dif);
            Console.WriteLine("Multiply: " + mul);
            //Console.WriteLine("Division: " + div);

            Console.ReadKey();
        }
    }
}
