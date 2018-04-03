using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = 10;
            int numSandwiches = 5;
            double dinnerCost = 50.00;
            string carColor = "green";
            string carMake = "tesla";
            string carModel = "model S";

            DateTime today = DateTime.Today;

            char firstLetter = 'c';

            // Number of stars = 1,000,000,000,000,000,000,000,000.
            double stars = 1e24;

            Console.WriteLine($"There are {numDogs} dogs in the park");
            Console.WriteLine($"I can eat {numSandwiches} sandwiches when I am hungry");
            Console.WriteLine($"It costs {dinnerCost:C2} to buy a nice dinner");
            Console.WriteLine($"My dream car would be the color {carColor}");
            Console.WriteLine($"My dream car would be a {carMake}");
            Console.WriteLine($"The car's model would be a {carModel}");
            Console.WriteLine($"Today is {today}");
            Console.WriteLine($"The first letter of my name is {firstLetter}");
            Console.WriteLine($"There are {stars} stars in the sky");
            Console.ReadLine();
        }
    }
}
