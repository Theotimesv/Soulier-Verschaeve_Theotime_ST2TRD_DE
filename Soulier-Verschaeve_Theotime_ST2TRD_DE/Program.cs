using System;

namespace Soulier_Verschaeve_Theotime_ST2TRD_DE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool program_is_running = true;

            Console.WriteLine("Welcome in the program.");
            while (program_is_running)
            {
                
                Console.WriteLine("Please enter a number to chose a menu:");
                Console.WriteLine("Quit the program: 0");
                Console.WriteLine("Exercise1: 1");
                Console.WriteLine("Exercise1: 2");
                Console.WriteLine("Exercise1: 3");
                Console.WriteLine("Exercise1: 4");

                
                bool correctAnswerFormat = int.TryParse(Console.ReadLine(), out var menu);

                while (!correctAnswerFormat)
                {
                    Console.WriteLine("Your choice has a wrong format.");
                    Console.WriteLine("Please enter a number to chose a menu:");
                    Console.WriteLine("Exercise1: 1");
                    Console.WriteLine("Exercise1: 2");
                    Console.WriteLine("Exercise1: 3");
                    Console.WriteLine("Exercise1: 4");
                    correctAnswerFormat = int.TryParse(Console.ReadLine(), out menu);
                }

                if (menu == 0)
                {
                    Console.WriteLine("You left the program.");
                    program_is_running = false;
                }
                else if (menu == 1)
                {
                    Console.WriteLine("Exercise 1");
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Exercise 2");
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Exercise 3");
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Exercise 4");
                }
            }
        }
    }
}