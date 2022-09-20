using System;

namespace CLeren
{
    class Program
    {
        static void Main(string[] args)
        {
            GetApp(); //appIn
            Greating();
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
                        PrintColorMessage(ConsoleColor.Red, "Please use a number");
                        continue;
                    }
                    guess = Int32.Parse(enter);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number:(");
                    }

                }
                PrintColorMessage(ConsoleColor.Yellow, "Its Correct!");
                //play again?
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetApp()
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
        }
        static void Greating()
        {
            //user name
            Console.WriteLine("Your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hey {0}, your welcome!", input);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

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
