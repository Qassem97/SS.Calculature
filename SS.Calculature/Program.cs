﻿using System;
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
                        p.Addition(a, b);
                        break;
                    case 2:
                        p.Subtraction(a, b);
                        break;
                    case 3:
                        p.Multiblcation(a, b);
                        break;
                    case 4:
                        p.Division(a, b);
                        break;

                }

            } while (inputchoice > 0 && inputchoice < 5);

        } public void Addition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Addition : a + b =" + result);
        }
        public void Subtraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Subtraction : a - b =" + result);
        }
        public void Multiblcation(double a, double b)
        {
            double result = a * b;
            Console.WriteLine("Multiblcation : a * b =" + result);

        } public void Division(double a, double b)
        {
            double result = a / b;
            Console.WriteLine("Division : a / b =" + result);
        }//end of main
    }//end of class
}//end of namespace
