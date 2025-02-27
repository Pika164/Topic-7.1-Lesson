using System.Reflection.Emit;

namespace Topic_7._1_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Learning Loops below this.
            int pin = 12345;
            int entry;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.Write("ENTER YOUR PIN: ");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN: ");
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //More learning
            Random generator = new Random();
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Please enter a valid number. ");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Programming task 1 
            int userGuess, secretNumber;

            secretNumber = generator.Next(1, 10);

            Console.WriteLine("Hello and welcome to upgraded verson of the slightly bad guessing game from topic 5 :). As usual you get one guess to guess the number from 1-10.");
            Console.WriteLine();
            Console.Write("Now, whats you guess of my secret number? ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (userGuess != secretNumber)
            {
                Console.WriteLine("Incorrect. Please enter a number from 1-10 again.");
                userGuess = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine();

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Yippee! You guessed my random number correct. You must be good at guessing.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();

            //Programming task 2
            int num1 = 1, num2 = 0;
            int total;

            Console.WriteLine("Hello. Press ENTER to roll the dice.");
            Console.ReadLine();
            while (num1 != num2)
            {
                num1 = generator.Next(1, 7);
                num2 = generator.Next(1, 7);
                total = num1 + num2;
                Console.WriteLine("Die 1 - " + num1);
                Console.WriteLine("Die 2 - " + num2);
                Console.WriteLine("Total - " + total);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
