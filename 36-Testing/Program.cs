using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _36_Testing
{
    internal class Program
    {
        // USE THIS FILE FOR TESTING AND EXPERIMENTATION

        static void Main(string[] args)
        {
            // Write your code here



            Console.WriteLine("The Everything");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Calculator");
            Console.WriteLine("3. Miles to Kilometers or Kilometers to Miles");
            Console.WriteLine("4. Fahrenheit to Celcius or Celcuis to Fahrenheit");
            string menu1 = Console.ReadLine();


            if (menu1 == "1")
            {
                Name();
            }

            else if (menu1 == "2")
            {
                Calculator();
            }

            else if (menu1 == "3")
            {
                MtoK();
            }

            else if(menu1 == "4")
            {
                FtoC();
            }

            else
            {
                Console.WriteLine("Invalid.");
            }

            

            while (true)
            {
                Repeat();
            }

            Schnitty();
            



        }

        private static void Repeat()
        {
            Console.ReadLine();
            Console.WriteLine("Would you like to repeat the program?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string repeat = Console.ReadLine();

            if (repeat == "1")
            {
                Console.Clear();
                Console.WriteLine("The Everything");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Miles to Kilometers or Kilometers to Miles");
                Console.WriteLine("4. Fahrenheit to Celcius or Celcuis to Fahrenheit");
                string menu1 = Console.ReadLine();


                if (menu1 == "1")
                {
                    Name();
                }

                else if (menu1 == "2")
                {
                    Calculator();
                }

                else if (menu1 == "3")
                {
                    MtoK();
                }

                else if (menu1 == "4")
                {
                    FtoC();
                }

                else
                {
                    Console.WriteLine("Invalid.");
                }


            }
            else if (repeat == "2")
            {
                Exit();
            }
            

        }

        private static void Schnitty()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("sigmas dont eat schnitzel");
        }




        private static void Name()

            {
                Console.Write("What is your first name? ");
                string first = Console.ReadLine();

                Console.Write("What is your last name? ");
                string last = Console.ReadLine();
                Console.WriteLine($"Hello {first} {last}.");
            }

            private static void Exit()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            private static void Calculator()
            {
                Console.Write("Please enter a number for X: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter a number for Y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{x} plus {y} = {x + y}");
                Console.WriteLine($"{x} multiplied by {y} = {x * y}");
                Console.WriteLine($"{x} divided by {y} = {x / y}");
                Console.WriteLine($"{x} minus {y} = {x - y}");
                Console.WriteLine($"The difference between {x} and {y} is {x - y}");
            }

            private static void MtoK()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Kilometres to Miles");
                Console.WriteLine("2. Miles to Kilometres");
                string choicemtok = Console.ReadLine();





                if (choicemtok == "1")
                {
                    Console.Write("How many kilometres? ");
                    double km = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{km} kilometers to miles = {km * 0.621371}");
                }

                else if (choicemtok == "2")
                {
                    Console.Write("How many miles? ");
                    double miles = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{miles} miles to kilometers = {miles * 1.60934}");
                }

                
            }
            
            private static void FtoC()
            {
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                string FtoCchoice = Console.ReadLine();




                if (FtoCchoice == "1")
                {
                    Console.Write("How many fahrenheit? ");
                    double fr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{fr} fahrenheit to celsius = {(fr - 32) * 5 / 9}");
                }

                else if (FtoCchoice == "2")
                {
                    Console.Write("How many celsius? ");
                    double cel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{cel} celsius to fahrenheit = {(cel * 9 / 5) + 32}");
                }

                else
                {
                    Console.WriteLine($"{FtoCchoice} is not a valid answer.");
                }

            {
                
            
            }
            }
        
    }
}