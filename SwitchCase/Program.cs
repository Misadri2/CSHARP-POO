using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.WriteLine("Please choose a number 1 to 7:");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid number";
                    break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}
