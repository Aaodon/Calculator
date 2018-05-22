using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Codded by Aaodon©
            // Data Type Variable Name = Value;

            Console.Write("Enter the firt number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number : ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 1 + Number 2 + Number 3 + Number 4 = " + (number1 + number2 + number3 + number4));
            Console.WriteLine("Number 1 - Number 2 - Number 3 - Number 4 = " + (number1 - number2 - number3 - number4));
            Console.WriteLine("Number 1 * Number 2 * Number 3 * Number 4 = " + (number1 * number2 * number3 * number4));
            Console.WriteLine("Number 2 / Number 2 / Number 3 / Number 4 = " + (number1 / number2 / number3 / number4));

            Console.Read();
        }
    }
}
