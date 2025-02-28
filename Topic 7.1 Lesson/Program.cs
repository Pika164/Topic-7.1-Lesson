using System.Reflection.Emit;

namespace Topic_7._1_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Learning Loops below this.
            int pin = 12345;
            int entry;
            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //Console.Write("ENTER YOUR PIN: ");
            //int.TryParse(Console.ReadLine(), out entry);
            //Console.WriteLine();
            //while (entry != pin)
            //{
            //    Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
            //    Console.Write("ENTER YOUR PIN: ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");
            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

            ////More learning
            Random generator = new Random();
            //int age;
            //while (!int.TryParse(Console.ReadLine(), out age))
            //    Console.WriteLine("Please enter a valid number. ");
            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

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

            //Bank pin updated
            bool done = false;
            int pins = 0, tries = 0;
            int entrys = 12345;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            while (!done)
            {
                Console.WriteLine();
                Console.Write("ENTER YOUR PIN: ");
                while (!int.TryParse(Console.ReadLine(), out entry)) ;

                tries++;
                if (pin == entry)
                {
                    Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");
                    done = true;
                }
                else if (tries == 5)
                {
                    Console.WriteLine("Too many incorrect tries. Access denied.");
                    done = true;
                }
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();

                //Programming task 3
                int totals = 0;
                int count = 0;
                int numbers = 5; // User will enter this many numbers.
                int input;

                Console.WriteLine("You will be prompted to enter 5 numbers and I will add them for you.");
                while (count < numbers)
                {
                    Console.WriteLine("Please enter a number:");
                    input = Convert.ToInt32(Console.ReadLine());
                    totals += input; // Adds the entered number to the running total
                    count++; // Increases our counter so we know how many values have been read in
                }
                Console.WriteLine();
                Console.WriteLine("The total is: " + totals);
            }
        }
    }
}
          

