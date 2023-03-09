using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = {"Rock", "Paper", "Scissors"};

            Console.WriteLine("1v1 in Rock-Paper-Scissors! Type 'quit' to exit.");

            while (true)
            {
                Console.WriteLine("\npick 1(Rock, Paper, Scissors):");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "quit")
                {
                    break;
                }

                if (Array.IndexOf(options, userChoice) == -1)
                {
                    Console.WriteLine("you stupid? Try again.");
                    continue;
                }

                Random rnd = new Random();
                string computerChoice = options[rnd.Next(0, options.Length)];

                Console.WriteLine($"You chose {userChoice}. Computer chose {computerChoice}.");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (userChoice == "rock" && computerChoice == "scissors" ||
                         userChoice == "paper" && computerChoice == "rock" ||
                         userChoice == "scissors" && computerChoice == "paper")
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}