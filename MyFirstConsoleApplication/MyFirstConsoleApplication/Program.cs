using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
/*First application for CIT365 WEEK01
  Author: Yllen Fernandez
  Instructor: Brother Ferguson
 */


namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        { 
            //Main method call excecutes other methods within the app
            GetUserNameAndLocation();
            ChristmasCountdown();
            RunExample();

        }

       

        private static void GetUserNameAndLocation()
        {
            //Method that creates a new Person and stores their location + name and displays them
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}! Where are you from?");
            var location = Console.ReadLine();
            Console.WriteLine($"I have never been to {location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();

            var person = new Person()
            {
                Name = name,
                Location = location
            };


        }


        private static void ChristmasCountdown()
        {
            //Method calculates current time and time until Christmas, it also stores and displays data from user
            var currentDate = DateTime.Now.ToString("d");
            Console.WriteLine($"\nToday's date is: {currentDate}");
            //Console.ReadLine();

            var chritsmasDay = new DateTime(DateTime.Now.Year, 12, 25);
            var daysUntilChristmas = (chritsmasDay - DateTime.Now);
            Console.WriteLine($"There are {daysUntilChristmas.Days + 1} days until Christmas!");
            //Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            

        }


        public static void RunExample()
        {
            // Method prompts user to enter different values to be calculated and displayed as pieces of relevant info for a business
            double width;
            Console.Write("\nEnter a width: ");
            string widthString = Console.ReadLine();

            // Input validation for width
            while (!double.TryParse(widthString, out width))
            {
                Console.Write("Enter a valid width: ");
                widthString = Console.ReadLine();
            }

            double height;
            Console.Write("Enter a height: ");
            string heightString = Console.ReadLine();

            // Input validation for height
            while (!double.TryParse(heightString, out height))
            {
                Console.Write("Enter a valid height: ");
                heightString = Console.ReadLine();
            }

            // Perform calculations and display results
            var woodLength = 2 * (width + height) * 3.25;
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            var glassArea = 2 * (width * height);
            Console.WriteLine($"The area of the glass is {glassArea} square meters");
            Console.ReadLine();
        }



    }
}
