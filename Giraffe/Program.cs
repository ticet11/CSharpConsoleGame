using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Console.WriteLine("Welcome to Kozub's game room!");
            while (playing == true)
            {
                Console.WriteLine("\nWe've got several very exciting games to choose from.\nWhich would you like to try?");
                Console.WriteLine("\nbigger number(1)\ncalculator(2)\nmad libs(3)\nget day(4)\nguess word(5)\nexponenter(6)\nbiggest book(7)");
                string chosenGame = Console.ReadLine().ToLower().Trim();
                if (chosenGame == "bigger number" || chosenGame == "1")
                {
                    BiggerNumber();
                }
                else if (chosenGame == "calculator" || chosenGame == "2")
                {
                    Calculator();
                }
                else if (chosenGame == "mad libs" || chosenGame == "3")
                {
                    MadLib();
                }
                else if (chosenGame == "get day" || chosenGame == "4")
                {
                    GetDay();
                }
                else if (chosenGame == "guess word" || chosenGame == "5")
                {
                    GuessWord();
                }
                else if (chosenGame == "exponenter" || chosenGame == "6")
                {
                    Exponenter();
                }
                else if (chosenGame == "book maker" || chosenGame == "7")
                {
                    BiggestBook();
                }
                Console.WriteLine("\nAre you having fun?");
                if (Console.ReadLine() == "no")
                {
                    playing = false;
                }
            }
            Console.WriteLine("Okay, bye!");
            Console.ReadLine();
        }

        static void BiggerNumber()
        {
            int num1, num2;
            Console.WriteLine("Wow, heck! This is bigger number!\nYou give me 2 numbers and I'll tell you which is bigger!");

            Console.Write("\n1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 || num2 > num1)
            {
                Console.WriteLine(Math.Max(num1, num2) + " is bigger than " + Math.Min(num1, num2) + ".");
            }
            else
            {
                Console.WriteLine("Those are the same number, you trickster!");
            }

        }

        static void Calculator()
        {
            Console.WriteLine("Welcome to this very cool, but very basic, calculator!");
            Console.WriteLine("What operation would you like to attempt?");
            string operation = Console.ReadLine();
            Console.WriteLine("What's your first number?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And the second?");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your result is: ");

            if (operation == "add" || operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operation == "subtract" || operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operation == "multiply" || operation == "*" || operation.ToLower() == "x")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (operation == "divide" || operation == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("You did that wrong. Go away.");
            }
        }

        static void MadLib()
        {
            Console.WriteLine("Wow, this is going to be a very fun mad lib style gaming experience.");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Plural Noun: ");
            string industry = Console.ReadLine();
            Console.Write("Number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Nick Name: ");
            string nickName = Console.ReadLine();
            Console.Write("Company: ");
            string company = Console.ReadLine();

            Console.WriteLine("Very exciting. Here's what you came up with:\n");

            Console.WriteLine("My name is " + name + " and I think we should meet.");
            Console.WriteLine("I work with " + industry + ".");
            Console.WriteLine("You can contact me at " + nickName + "@" + company + ".com.\n");

            Console.WriteLine("That is a major lol.");
        }

        static void GetDay()
        {
            Console.WriteLine("Oh, Shoot. I wish you hadn't chosen this game. It's so lame.");
            Console.Write("Please give me a number between 1 and 7: ");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            string dayName;
            switch (dayNum - 1)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Sunday";
                    break;
                case 3:
                    dayName = "Sunday";
                    break;
                case 4:
                    dayName = "Sunday";
                    break;
                case 5:
                    dayName = "Sunday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid number, dude.";
                    break;
            }

            Console.WriteLine(dayName);
        }

        static void GuessWord()
        {
            string secretWord = "daisy";
            bool playing = true;
            int guessCount = 0;
            Console.WriteLine("Okay, welcome to Guess Word. This is actually a very cool game that everyone loves.\nI hope you have never played this before.");
            Console.WriteLine("Here's a hint: This word is a flower and a babies name.");

            while (guessCount < 3 && playing == true)
            {
                Console.Write("Your guess: ");
                string guess = Console.ReadLine();
                if (guess.ToLower().Trim() == secretWord)
                {
                    Console.WriteLine("Wow, I can't believe you guessed that! Are you sure you haven't played before?");
                }
                else
                {
                    guessCount++;
                    if (guessCount < 3)
                    {
                        Console.WriteLine("That was actually super wrong. Would you like to try again? (yes/no)");
                        if (Console.ReadLine() == "no")
                        {
                            playing = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm pretty sure you lost. Sorry.\n");
                    }
                }
            }

        }

        static void Exponenter()
        {
            Console.WriteLine("\nPlease just give me two numbers. That's all I want!");
            Console.Write("1st Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int solution = num1;
            for (int i = 1; i < num2; i++)
            {
                solution *= num1;
            }
            Console.WriteLine("\n" + num1 + " to the power of " + num2 + " is " + solution);
        }

        static void BiggestBook()
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 293);
            Book book2 = new Book("Eragon", "Christopher Paolini", 530);
            Book book3 = new Book("The Goose Girl", "Shannon Hale", 432);

            Console.WriteLine("\nWelcome to Biggest Book! This is not a fun game.");
            Console.WriteLine("Can you tell me, which of these three books has the most pages?");

            Console.WriteLine("(a) " + book1.title);
            Console.WriteLine("(b) " + book2.title);
            Console.WriteLine("(c) " + book3.title);
            bool playing = true;
            while (playing == true)
            {
                Console.Write("\nYour guess: ");
                string guess = Console.ReadLine();
                if (guess == "b" || guess == "Eragon")
                {
                    Console.WriteLine("Wow, I guess you like books. Neat.");
                    playing = false;
                } else
                {
                    Console.WriteLine("You're actually wrong. Thanks.\nWant to play again?(yes/no)");
                    if (Console.ReadLine() == "no")
                    {
                        Console.WriteLine("Okay, bye.");
                        playing = false;
                    }
                }
            }
        }
    }
}
