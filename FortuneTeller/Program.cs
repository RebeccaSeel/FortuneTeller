using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the values for the problem
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favColor;
            string numSiblings;
            string yearRetire;
            string vacHome;
            double bankAccount;
            string transport;

            //have user enter required data           
            Console.WriteLine("What is your first name? ");
            firstName = (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("What is your last name? ");
            lastName = (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("What is your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("What is your birth month in numeric form? ");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" to get a list of colors. ");
            favColor = (Console.ReadLine());
            Console.WriteLine("");
            if (favColor.Equals("Help"))
            {
                Console.WriteLine("ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("");
                Console.WriteLine("What is your favorite ROYBGIV color? ");
                Console.ReadLine();
                Console.WriteLine("");
            }

            Console.WriteLine("How many siblings to you have? ");
            numSiblings = (Console.ReadLine());
            Console.WriteLine("");

            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.

            if (age % 2 == 0)
            {
                yearRetire = "10";
            }
            else
            {
                yearRetire = "15";
            }

            //If the user’s number of siblings is 0, then they will have a vacation home in ____ (location), 
            //or 1 then they will have a vacation home in ____ (location), 
            //or 2 then they will have a vacation home in ____ (location), 
            //or 3 then they will have a vacation home in ____ (location), 
            //or more than 3 then they will have a vacation home in ____ (location). 
            //If the user enters anything other than a number less than or equal to 0, they should get a bad vacation home!

            if (numSiblings = 0)
            {
                vacHome = "Paris";
            }
            else if (numSiblings = 1)
            {
                vacHome = "Melbourne";
            }
            else if (numSiblings = 2)
            {
                vacHome = "California";
            }
            else if (numSiblings = 3)
            {
                vacHome = "Quebec";
            }
            else if (numSiblings >= 4)
            {
                vacHome = "the Amazon";
            }
            else (numSiblings < 0);
            {
                vacHome = "North Korea";
            }

            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation 
            //(i.e. car, boat, plane, etc.)

            switch (favColor)
            {
                case "red": transport = "RV";
                    break;
                case "orange": transport = "jet";
                    break;
                case "yellow": transport = "motorcycle";
                    break;
                case "green": transport = "bicycle";
                    break;
                case "blue": transport = "taxi cab";
                    break;
                case "indigo": transport = "boat";
                    break;
                case "violet": transport = "helicopter";
                    break;
            }

            //If the user’s birth month is 1-4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9 - 12, then they will have $____ in the bank.
            //If the user enters something other than 01 - 12 as their birth month, they will have $0.00 in the bank.

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = 100;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = 1000;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = 10000;
            }
            else
            {
                bankAccount = 0;
            }

            //Final Output to User [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, 
            //a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.
            {
                Console.WriteLine(firstName + lastName + " will retire in " + yearRetire + " years with $ " + bankAccount + " in the bank,\n a vacation home in " + vacHome + " and a " + transport + ".");
            }

            //Extra: Give the user the ability to quit the program at any point where the program is looking for user input, 
            //by typing “Quit” (should not be case sensitive). The program should print “Nobody likes a quitter...” before ending
        }
    }
}
