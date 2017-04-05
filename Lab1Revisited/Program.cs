using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Generator!");
            List<float> lengths = new List<float>();
            List<float> widths = new List<float>();
            List<float> areas = new List<float>();
            int timesRun = 0;
            bool run = true;
            while (run == true)
            {
                timesRun++;
                Console.WriteLine("Please enter a room length in feet.");
                float length;
                try
                {
                    length = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please input a room length in feet.");
                    length = -1;
                }
                lengths.Add(length);
                Console.WriteLine("Please enter a room width in feet.");
                float width;
                try
                {
                    width = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please input a room width in feet.");
                    width = -1;
                }
                widths.Add(width);
                float area = length * width;
                areas.Add(area);
                Console.WriteLine("The area of this room is " + area + " square feet.");
                run = Continue();
            }
            Console.WriteLine("Would you like to print all room information? (y/n)");
            string printIt;
            try
            {
                printIt = Console.ReadLine().ToLower();
            }
            catch
            {
                Console.WriteLine("Did not understand input. Would you like to print all room information? (y/n)");
                printIt = "n";
            }
            if (printIt == "y")
            {
                for (int i = 0; i < timesRun; i++)
                {
                    Console.WriteLine("Room " + (i + 1) + " Length: " + lengths[i] + " Width: " + widths[i] + " Area: " + areas[i]);
                }
            }
            else
            {
                Console.WriteLine("Thank you for using the Grand Circus Room Generator!");
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Would you like to calculate another room? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            if (input == "n")
            {
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }
            return run;
        }
    }
}
