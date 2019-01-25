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
            double c = 0;

            do
            {
                Console.WriteLine("1. Addition 2.Subtraction 3.Maltiplicatin 4.Division");
                Console.Write("Enter your choice 1, 2, 3, 4 or 5 for exit: ");
                inputchoice = double.Parse(Console.ReadLine());


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
                        Addition(a, b, c);
                        break;
                    case 2:
                        Subtraction(a, b, c);
                        break;
                    case 3:
                        Multiblcation(a, b);
                        break;
                    case 4:
                        Division(a, b);
                        break;
                    case 5:
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Not valid number");
                        break;
                }

            } while (inputchoice > 0 && inputchoice < 5);

        }


        public static void Addition(double a, double b, double c)
        {
            double result = a + b;
            Console.WriteLine("Addition : a + b =" + result);

            Console.Write("Would you like to continue addition with the result? y = yes : ");
            string yesNo = Console.ReadLine();

            while (yesNo.Equals("y"))
            {


                Console.WriteLine("+");
                c = double.Parse(Console.ReadLine());

                result = result + c;
                Console.WriteLine(result);

                Console.Write("Would you like to continue addition with the result? y = yes : ");
                yesNo = Console.ReadLine();
            }



        }// end of Add

        public static void Subtraction(double a, double b, double c)
        {
            double result = a - b;
            Console.WriteLine("Subtraction : a - b =" + result);
            Console.Write("Would you like to continue subtraction with the result? y = yes : ");
            string yesNo = Console.ReadLine();

            while (yesNo.Equals("y"))
            {


                Console.WriteLine("-");
                c = double.Parse(Console.ReadLine());

                result = result - c;
                Console.WriteLine(result);

                Console.Write("Would you like to continue addition with the result? y = yes : ");
                yesNo = Console.ReadLine();
            }
        }//end of Sub-

        public static void Multiblcation(double a, double b)
        {
            double result = a * b;
            Console.WriteLine("Multiblcation : a * b =" + result);

        }
        public static void Division(double a, double b)
        {
            double result = a / b;
            Console.WriteLine("Division : a / b =" + result);

        } //end of main
    }//end of class
}//end of namespace
