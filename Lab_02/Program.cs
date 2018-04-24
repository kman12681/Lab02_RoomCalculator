using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program will calculate the area, perimeter, and volume\nof various rectangular classrooms.\n");
            Console.WriteLine("----------------------------------");

            while (true)
            {

                Console.Write("\nEnter the Length (in feet): ");
                double userLength = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter the Width (in feet): ");
                double userWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter the Height (in feet): ");
                double userHeight = Convert.ToDouble(Console.ReadLine());

                double area = userLength * userWidth;
                double perimeter = (2 * userLength) + (2 * userWidth);
                double volume = userLength * userWidth * userHeight;

                Console.WriteLine($"\nArea: {area} ft. squared.\n\nPerimeter: {perimeter} ft.\n\nVolume: {volume} cubic ft.\n");

                string response = DoAgain();
                if (response == "N")
                    break;
            }
        }

        static string DoAgain()

        {
            while (true) // will run program again if user enters "Y" (or "y"), will exit if "N" (or "n")

            {

                Console.Write("Do you want to try again? (Y or N) ");
                string input = Console.ReadLine().ToUpper();

                if (input == "Y" || input == "N")
                    return input;

                else

                {
                    Console.WriteLine();
                    Console.WriteLine("Not a valid entry.");
                    Console.WriteLine();
                }

            }
        }
    }
}
