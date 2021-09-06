using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringInput = "";
            if(args.Length == 0)
            {
                System.Console.WriteLine("...Enter a year to check if it's a leap lear: ");
                stringInput = Console.ReadLine().Trim();
            }
            else
            {
                stringInput = args[0];
            }

            int input = convertInputToInt(stringInput);

            if(input==0)
            {
                Main(new string[0]);
                return;
            }
            else if(input<=1582)
            {
                System.Console.WriteLine("Please Enter a number equal to or above 1582!\n");
                Main(new string[0]);
                return;
            }
            
            if(isLeapYear(input)==true)
            {
                Console.WriteLine("yay");
            }
            else if(isLeapYear(input)==false)
            {
                Console.WriteLine("nay");
            }

        }

        public static int convertInputToInt(string stringInput)
        {
            try
            {
                int input = Convert.ToInt32(stringInput);
                return input;
            }
            catch
            {
                 Console.WriteLine("Please enter a number\n");
                 return 0;
                 
            }
        }

        public static bool isLeapYear(int year)
        {
            if(year%400==0)
            {
                return true;
            }
            else if(year%100==0)
            {
                return false;
            }
            else if(year%4==0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }
}
