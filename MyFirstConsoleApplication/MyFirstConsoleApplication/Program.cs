using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            RunExample();

        }

       

        private static void GetUserNameAndLocation()
        {
            
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
            double width;
            Console.Write("\nEnter a width: ");
            string widthString = Console.ReadLine();
            width = double.Parse(widthString);


            double height;
            Console.Write("Enter a height: ");
            string heightString = Console.ReadLine();
            height = double.Parse(heightString);


            var woodLength = 2 * (width + height) * 3.25;
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            var glassArea = 2 * (width * height);
            Console.WriteLine($"The area of the glass is {glassArea} square meters");
            Console.ReadLine();




            while (!double.TryParse(widthString, out width) && (!double.TryParse(heightString, out height)))
            {
                Console.Write("Enter a valid width: ");
                widthString = Console.ReadLine();
                Console.WriteLine("Enter a valid height: ");
                heightString = Console.ReadLine();
            }


        }



        }
}
