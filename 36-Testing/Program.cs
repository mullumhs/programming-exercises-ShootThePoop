using System;
using System.Collections.Generic;
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


            Exit();


        }


            // Wait for input before ending


            private static void Name()
            {
                Console.Write("What is your first name? ");
                string first = Console.ReadLine();

                Console.Write("What is your last name? ");
                string last = Console.ReadLine();
                Console.WriteLine($"Hello {first} {last}");
            }

            private static void Exit()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to exit...");
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

                Console.Clear();
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
        
    }
}