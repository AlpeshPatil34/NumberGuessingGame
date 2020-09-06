using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //App variables
            string appName = "Guess the Number!";
            string appVersion = "0.1.0";
            string authorName = "Snoop Dogg";

            //Showcasing the app values
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{appName} Version: {appVersion} \n Made by: {authorName}");
            Console.ResetColor();

            //Ask for the user's name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            //Intro to the app
            Console.WriteLine("Hello " +(name) +", Let's play!");

            while (true)
            {

                //Start of guess game
                Random r = new Random();

                int randomNumber = r.Next(1, 100);

                bool count = false;
                Console.WriteLine("Let's get started! \n");

                do
                {
                    Console.WriteLine("\n Please enter a number: ");
                    string s1 = Console.ReadLine();
                    int userInput = Convert.ToInt32(s1);
                    if (userInput > randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Too High!");
                        Console.ResetColor();
                    }
                    else if (userInput < randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Too Low!");
                        Console.ResetColor();
                    }
                    else if (userInput == randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Just Right!");
                        Console.ResetColor();
                        count = true;
                    }

                } while (count == false);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You Win! \n Thank you for playing! \n \n ");

                //So that the user can play again
                Console.WriteLine("Do you wish to play again? \n Press Y for yes and N for no.");
                string cont = Console.ReadLine().ToUpper();

                if (cont == "Y")
                {
                    continue;
                }
                else if(cont == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

    }
}
