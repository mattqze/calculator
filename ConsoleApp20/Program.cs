using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] input2 = input.Split(' ');
            double number1 = 0;
            double number2 = 0;
            string bfrparopp = null;
            try
            {
                number1 = int.Parse(input2[0]);
                bfrparopp = input2[1];
                number2 = int.Parse(input2[2]);
            }
            catch(Exception ex)
            {

            }
            if(bfrparopp == "+")
            {
                Console.WriteLine(number1 + number2 +"\n");
                Main(args);
            }
            if (bfrparopp == "-")
            {
                Console.WriteLine(number1 - number2 + "\n");
                Main(args);
            }
            if (bfrparopp == "x")
            {
                Console.WriteLine(number1 * number2 + "\n");
                Main(args);
            }
            if (bfrparopp == "/")
            {
                Console.WriteLine(number1 / number2 + "\n");
                Main(args);
            }
            if (bfrparopp == "%of")
            {
                Console.WriteLine(number1 /100* number2 + "\n");
                Main(args);
            }
            if (input2[0] == "sqrt")
            {
                Console.WriteLine(Math.Sqrt(Convert.ToDouble(input2[1])) + "\n");
                Main(args);
            }
        }
    }
}
