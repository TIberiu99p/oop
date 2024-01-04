using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Calculator calculator = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = calculator.Add(x, y);
            int sub = calculator.Subtract(x, y);
            int mult = calculator.Multiply(x, y);
            float div = calculator.Divide(x, y);
            
            Console.WriteLine($"sum of {x} + {y} = {sum}");
            Console.WriteLine($"sub of {x} - {y} = {sub}");
            Console.WriteLine($"mult of {x} * {y} = {mult}");
            Console.WriteLine($"div of {x} / {y} = {div.ToString("F2")}");
            Console.ReadLine();
            
            

        }
    }
}
