/*
 * Anthony Parsch
 * January 12, 2018
 * Assignment 1.1: Welcome to C#
 * 
 * Extra Features:
 * If the program is opened with arguments, the first argument will be treated as the user's name
 */

using System;

namespace Assignment_1._1
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            // Get the name from the user, as either an argument or during the program running
            if (args.Length >= 1) name = args[0];
            else
            {
                Console.Out.Write("Please enter your name: ");
                name = Console.In.ReadLine();
                Console.Out.WriteLine();
            }

            // Display the given name
            Console.Out.WriteLine("Hello " + name + "! Welcome to C#!!");
            Console.Out.WriteLine("Press enter to finish program");
            Console.In.Read();
        }
    }
}
