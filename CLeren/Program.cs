using System;

namespace CLeren
{
    class Program
    {
        static void Main(string[] args)
        {
            // set app vars
            string appName = "Lerning C#";
            string appVersion = "1.0.0";
            string appAuthor = "Naser Masri";
            //change color
            Console.ForegroundColor = ConsoleColor.Green;
            //app ino
            Console.WriteLine("{0}: Versioon {1} by {2}", appName, appVersion, appAuthor);
            //reset color
            Console.ResetColor();
            //user name
            Console.WriteLine("Your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hey {0}, your welcome!", input);
            while (true)
            {
                // init correct number
                //int correctNumber = 5;
                //generate a number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                //init guess var
                int guess = 0;

                Console.WriteLine("Guess a number beween 1 and 10");

                while (guess != correctNumber)
                {
                    string enter = Console.ReadLine();
                    //its a number?
                    if (!int.TryParse(enter, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("please enter a number a number");
                        Console.ResetColor();
                        continue;

                    }
                    guess = Int32.Parse(enter);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again!");
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("its correct");
                Console.ResetColor();
                //play again?
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
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

/*
using System;

namespace Number;


internal class MyClass
{
    static void Main(string[] args)
    {
        string name = "Sanna";
        Console.WriteLine(name);
    }
}

*/
