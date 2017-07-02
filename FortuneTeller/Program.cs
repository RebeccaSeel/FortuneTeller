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

            //determine retirement year using remainder calculation for even/odd
            if (age % 2 != 0)
            {
                yearRetire = 15;
            }
            else
            {
                yearRetire = 10;
            }

            //determine vacation home by converting number of siblings to string variable for home location
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

            //set switch statement to identify mode of transportation based on user's favorite color
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

            //set if else statements to determine bank account value based on birth month
            //tried various options to insert comma in dollar amount but wasn't able to get it to work
            //read about "C" currency format specifier but it only worked for the decimal issue as all of my
            //bankAccount values include cents and two end in 0s
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = 975.86m;
                String.Format("{0:C2}", bankAccount);
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = 8521.90m;
                String.Format("{0:C2}", bankAccount);
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = 13469.27m;
                String.Format("{0:C2}", bankAccount);
            }
            else
            {
                bankAccount = 0.00m;
                String.Format("{0:C2}", bankAccount);
            }

            //Final oututput to user
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
