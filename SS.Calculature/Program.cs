using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Calculature
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputchoice = 0;
            double a = 0, b = 0;
            do
            {
                Console.WriteLine("1. Addition 2.Subtraction 3.Maltiplicatin 4.Division");
                Console.WriteLine("Enter your choice 1, 2, 3, 4 : ");
                inputchoice = double.Parse(Console.ReadLine());
                Program p = new Program();

                if (inputchoice > 0 && inputchoice < 5)
                {
                    Console.WriteLine("Enter the first number: ");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the 2nd number: ");
                    b = double.Parse(Console.ReadLine());
                }
                switch (inputchoice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            } while (inputchoice > 0 && inputchoice < 5);
        }//end of main
    }//end of class
}//end of namespace
