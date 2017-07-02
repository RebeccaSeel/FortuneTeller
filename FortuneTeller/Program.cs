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
            int numSiblings;
            int yearRetire;
            string vacHome;
            decimal bankAccount;
            string transport;
            

            //have user enter required data           
            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();
            Console.WriteLine("");

            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();
            Console.WriteLine("");

            Console.WriteLine("What is your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("What is your birth month in numeric form? ");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //allow user to ask for “Help” to get a list of the ROYGBIV colors
            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" to get a list of colors. ");
            favColor = Console.ReadLine();
            favColor = favColor.ToLower();
            Console.WriteLine("");
            if (favColor.Equals("help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("");
                Console.WriteLine("So, what is your favorite ROYBGIV color? ");
                favColor = Console.ReadLine();
                favColor = favColor.ToLower();
                Console.WriteLine("");
            }
            
            Console.WriteLine("How many siblings do you have? ");
            numSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.

            if (age % 2 != 0)
            {
                yearRetire = 15;
            }
            else
            {
                yearRetire = 10;
            }

            //If the user’s number of siblings is 0, then they will have a vacation home in ____ (location), 
            //or 1 then they will have a vacation home in ____ (location), 
            //or 2 then they will have a vacation home in ____ (location), 
            //or 3 then they will have a vacation home in ____ (location), 
            //or more than 3 then they will have a vacation home in ____ (location). 
            //If the user enters anything other than a number less than or equal to 0, they should get a bad vacation home!
            
            if (numSiblings == 0)
            {
                Convert.ToString(vacHome = "Paris");
            }
            else if (numSiblings == 1)
            {
                Convert.ToString(vacHome = "Melbourne");
            }
            else if (numSiblings == 2)
            {
                Convert.ToString(vacHome = "California");
            }
            else if (numSiblings == 3)
            {
                Convert.ToString(vacHome = "Quebec");
            }
            else if (numSiblings >= 4)
            {
                Convert.ToString(vacHome = "the Amazon");
            }
            else 
            {
                Convert.ToString(vacHome = "North Korea");
            }

            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation 
            //(i.e. car, boat, plane, etc.)

            transport = null;
            switch (favColor)
            {
                case "red":
                    transport = "an RV";
                    break;
                case "orange":
                    transport = "a jet";
                    break;
                case "yellow":
                    transport = "a motorcycle";
                    break;
                case "green":
                    transport = "a bicycle";
                    break;
                case "blue":
                    transport = "a taxi cab";
                    break;
                case "indigo":
                    transport = "a boat";
                    break;
                case "violet":
                    transport = "a helicopter";
                    break;
            }

            //If the user’s birth month is 1-4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9 - 12, then they will have $____ in the bank.
            //If the user enters something other than 01 - 12 as their birth month, they will have $0.00 in the bank.

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = 975.86m;
                string formatted = bankAccount.ToString("#,##0.00");
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = 8521.90m;
                string formatted = bankAccount.ToString("#,##0.00");
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = 13469.27m;
                string formatted = bankAccount.ToString("#,##0.00");
            }
            else
            {
                bankAccount = 0.00m;
                string formatted = bankAccount.ToString("#,##0.00");
            }

            //Final Output to User [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, 
            //a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.
            {
                Console.WriteLine(firstName + " " + lastName + " will retire in " + yearRetire + " years with $" + bankAccount + " in the bank,");
                Console.Write("a vacation home in " + vacHome + " and " + transport + ".");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            //Extra: Give the user the ability to quit the program at any point where the program is looking for user input, 
            //by typing “Quit” (should not be case sensitive). The program should print “Nobody likes a quitter...” before ending
        }
    }
}
