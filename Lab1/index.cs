using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.WriteLine("Choose a task:");
                Console.WriteLine("1 - Task 1 - OneDimensionalArray");
                Console.WriteLine("2 - Task 2 - Vector Operations");
                Console.WriteLine("0 - Exit");

                choice = Console.ReadLine(); 

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n\nRunning Task 1 - OneDimensionalArray\n");
                        ArrayOperationsExample.Task1(); 
                        break;

                    case "2":
                        Console.WriteLine("\n\nRunning Task 2 - Vector Operations\n");
                        ProgramClient.Task2();
                        break;

                    case "0":
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2 or 0 to exit.");
                        break;
                }

            } while (choice != "0"); 

            Console.WriteLine("\nProgram execution completed.");
        }
    }
}


