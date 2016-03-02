using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string Greeting = ("Hello World. ");
            Console.WriteLine($"{Greeting}");

            int year = 1492;
            Console.WriteLine($"Columbus sailed the world in {year}");

            bool dogHome = true;

            Console.WriteLine($"It is {dogHome} that I have a dog at home.");

            DateTime todaysDate = new DateTime(2016, 2, 29, 14, 15, 24);

            Console.WriteLine(todaysDate);

            float cost = (5.45f);

            Console.WriteLine($"I spent ${cost} on a cheeseburger.");

            char here = ('X');

            Console.WriteLine($"{here} marks the spot.");

            string[] books = { "Odd Thomas Series ", "Icebound ", "The Firm ", "Gray Mountain", "Zero Day ", "The Escape" };

            Console.WriteLine($"Some of the books I like are:{0}, {1} By Dean Koontz, as well as: {2}, {3} By John Grisham, also: {4}, {5} By David Baldacci.");

            Console.ReadLine();
        }
    }
}
