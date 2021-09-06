using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a year to check if it's a leap lear");
            string stringInput = Console.ReadLine().Trim();
            int input = Convert.ToInt32(stringInput);
            /*try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Please enter a number");
                Main(new string[0]);
            }
            */
            if(isLeapYear(input)==true)
            {
                Console.WriteLine("yay");
            }
            else if(isLeapYear(input)==false)
            {
                Console.WriteLine("nay");
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
