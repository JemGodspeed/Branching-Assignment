using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {     // Print the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // Prompt user for package for widht,height and length
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

   
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

            // Calculate the shipping quote
            int dimensionProduct = width * height * length; // Multiply dimensions
            double quote = (dimensionProduct * weight) / 100.0; // Calculate quote

           
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
 }

