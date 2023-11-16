using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            MtoK();

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
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback on your C# Programming Task

Here are some areas of improvement for your code:

Code Structure: Your code is a series of Console.WriteLine() and Console.ReadLine() statements. It's hard to understand the flow of your program without any control structures (like loops or conditionals).

Variable Usage: You're not storing any of the input you're getting from the user with Console.ReadLine(). If you need to use this input later in your program, you should assign it to a variable.

Code Commenting: There are no comments in your code. Comments are crucial for understanding the purpose of your code, especially when other people are reading it. Try to add comments that explain what each part of your code is doing.

Error Handling: The line Console.WriteLine("Error with code. Cannot Continue."); suggests there's an error, but it's unclear what the error is. If this is an actual error message, you should use proper error handling techniques, such as try/catch blocks.

Console.Beep(): You've used Console.Beep(1000, 5000); in your code. While this is a valid C# method, it's not clear why you're using it in this context. Be sure to comment your code to clarify its purpose.

Task Completion: It's hard to determine if you've completed the tasks as they're not clearly marked in your code. Remember to mark tasks with numbered comments.

Here's an example of how you could improve your code:

// Task 1: Get user's name
Console.WriteLine("What's your name");
string name = Console.ReadLine();

// Task 2: Ask user not to speak into the mic
Console.WriteLine("Don't speak into this mic and I'll buy you whatever you want.");
string response = Console.ReadLine();

// Check if user spoke into the mic
if(response != "")
{
    Console.WriteLine("You're not meant to speak. Would you like to try that again?");
    response = Console.ReadLine();
}
Remember, these are suggestions for improvement and it's okay to make mistakes when you're learning. Keep practicing and you'll get better!


===============================================================================
*/