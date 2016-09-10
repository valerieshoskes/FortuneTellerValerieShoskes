using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerValerieShoskes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fortune Teller App!");
            Console.WriteLine("Quit at any time by typing \"Quit\".");
            Console.Write("\n\n\n");
            Console.WriteLine("Time to get your fortune told..");
            Console.Write("\n\n\n");
            Console.WriteLine("What is your first name?");
            string input = Console.ReadLine();
            QuitCheck(input);
            string firstName = input;
            Console.WriteLine("What is your last name?");
            input = Console.ReadLine();
            QuitCheck(input);
            string lastName = input;
            int retireAge;
            string transpotation;
            string vacationHome;
            float moneyInTheBank;
            Console.WriteLine("Please enter your age");
            input = Console.ReadLine();
            QuitCheck(input);
            int age = int.Parse(input);
            if (age%2 == 0)
            {
                retireAge = 50;
            }
            else
            {
                retireAge = 35;
            }
            Console.WriteLine("Please Enter your birth month as an integer from 1 - 12.");
            input = Console.ReadLine();
            QuitCheck(input);
            int month = int.Parse(input);
            if (month < 1 || month > 12)
            {
                moneyInTheBank = 0.00F;

            }
            else if (month <= 4 )
            {
                moneyInTheBank = 200000.00F;
            }
            else if (month <= 8)
            {
                moneyInTheBank = 10000.00F;
            }
            else
            {
                moneyInTheBank = 50000.00F;
            }
            Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" for help.");
            input = Console.ReadLine();
            QuitCheck(input);
            while (input.ToLower().Replace("\"", "") == "help")
            {
                Console.WriteLine("R is for Red");
                Console.WriteLine("O is for Orange");
                Console.WriteLine("Y is for Yellow");
                Console.WriteLine("G is for Green");
                Console.WriteLine("B is for Blue");
                Console.WriteLine("I is for Indigo");
                Console.WriteLine("V is for Violet");
                Console.WriteLine("What is your favorite ROYGBIV color? Type \"Help\" for help.");
                input = Console.ReadLine();
                QuitCheck(input);
            }
            input = input.ToLower();
            switch (input)
            {
                case "red":
                    transpotation = "sports car";
                    break;
                case "orange":
                    transpotation = "taxi";
                    break;
                case "yellow":
                    transpotation = "bicycle";
                    break;
                case "green":
                    transpotation = "normal car";
                    break;
                case "blue":
                    transpotation = "boat";
                    break;
                case "indigo":
                    transpotation = "very efficient car, you hipster";
                    break;
                case "violet":
                    transpotation = "motorcycle";
                    break;
                default:
                    transpotation = "pair of running shoes";
                    break;
            }
            Console.WriteLine("How many siblings do you have?");
            input = Console.ReadLine();
            QuitCheck(input);
            int siblings = int.Parse(input);
            if (siblings < 0)
            {
                vacationHome = "a very small and sad hole";
            }
            else if (siblings == 0)
            {
                vacationHome = "the tropics";
            }
            else if (siblings == 1)
            {
                vacationHome = "a city penthouse";
            }
            else if (siblings == 2)
            {
                vacationHome = "the Alps";
            }
            else if (siblings == 3)
            {
                vacationHome = "a nice suburb";
            }
            else
            {
                vacationHome = "a cultural metropolis";
            }
            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4}, and a {5}", firstName, lastName, retireAge, moneyInTheBank, vacationHome, transpotation);
            Console.ReadKey();
        }
        public static void QuitCheck(string quitInput)
        {
            if (quitInput.ToLower().Replace("\"", "") == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
