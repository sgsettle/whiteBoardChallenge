using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Declare and initialize variables. One of type int, one of type string, and one of type DateTime.
            2. Create a method that subtracts two numbers and returns the value.
            3. Create a method that takes two strings from the user and outputs a string.
            4. Write a switch case that asks the user if they are wearing clothes.
            5. Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;
            6. Write an if, else if, else that asks the user how much money they make a year. Check ranges between 1,000-10,000,  11,000-50,000, and 51,000-100,000. Output to the test runner based on each salary range. Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking. */

            // 1
            int age = 28;
            string name = "slayde";
            DateTime today = DateTime.Today;

            // 2
            int numOne = 5;
            int numTwo = 10;

            int subtract = numTwo - numOne;
            Console.WriteLine(subtract);

            // 3
            string firstName = "Slayde";
            string lastName = "Settle";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);

            // 4
            Console.WriteLine("Are you wearing any clothes?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "yes":
                    Console.WriteLine("You are wearing clothes.");
                    break;
                case "no":
                    Console.WriteLine("You are not wearing clothes.");
                    break;
            }

            // 5
            bool happy = true;

            if(happy)
            {
                Console.WriteLine("You are happy!");
            }
            else
            {
                Console.WriteLine("I'm sorry you are sad.");
            }

            // 6
            Console.WriteLine("How much money do you make in a year?");
            string moneyInput = Console.ReadLine();
            int money = Convert.ToInt32(moneyInput);

            if (money > 1000 && money < 10000)
            {
                Console.WriteLine("That's not enough money");
            }
            else if (money > 11000 && money < 50000)
            {
                Console.WriteLine("That's about average");
            }
            else if (money > 51000 && money < 100000)
            {
                Console.WriteLine("Wow. You make good money");
            }
            else
            {
                Console.WriteLine("I'm sorry you either didn't input your salary or it is out of our range");
            }

            Console.ReadLine();

        }
    }
}
