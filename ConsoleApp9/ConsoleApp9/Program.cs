﻿using System;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("\t Simple calc \nChoose operation:\n 1. Add \n 2.Substract \n 3.Mult \n 4. Division \n 5. Square root");
            int choose = int.Parse(Console.ReadLine());
            
            
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter num 1: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num 2: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Add.Addition(num1,num2));
                        break;
                    case 2:
                        Console.WriteLine("Enter num 1: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num 2: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(Sub.Substraction(num1,num2));
                        break;

                    case 3:
                        Console.WriteLine("Enter num 1: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num 2: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 == 0 || num1 == 0)
                        {
                            throw new ArgumentException("ZERO MULTIPLY,  WHY'D U MULT BY 0 IT'S = 0");
                        }
                    
                        Console.WriteLine(Mult.Multy(num1,num2));
                        break;

                    case 4:
                        Console.WriteLine("Enter num 1: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter num 2: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num1 == 0 || num2 == 0)
                        {
                            throw new DivideByZeroException("ZERO DIVISION ");
                        }
                        Console.WriteLine(Division.Div(num1,num2));
                        break;

                    case 5:
                        Console.WriteLine("Enter num 1: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 == 0 || num1 <= 0)
                        {
                            throw new ArgumentException("Root can't be 0 or less then 0");
                        }
                        
                        Console.WriteLine(SquareRoot.Root(num1));

                        break;
                }

           

            

        }
    }
}
