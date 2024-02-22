namespace RandomNumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Guessing the number game");
            String YorN = "Y";

            while (YorN.Equals("Y"))
            {

                Console.ForegroundColor = ConsoleColor.White;
                Random rnd = new Random();
                int x = rnd.Next(1, 101);

                int count = 0;
                Boolean choice = false;
                while (!choice)
                {
                    Console.WriteLine("Please enter a whole number ");
                    int num = int.Parse(Console.ReadLine());

                    if (num < x)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if ((x - num) >= 10) Console.WriteLine("Your guess is way too Low!!");
                        Console.WriteLine("The number is lower than guess!");
                        count++;
                    }
                    else if (num > x)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if ((num - x) >= 10) Console.WriteLine("Your guess is way too high!!");
                        Console.WriteLine("The number is higher than the guess");
                        count++;
                    }
                    else if (num == x)
                    {
                        choice = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is a correct number! You are a great mathematician");
                        Console.WriteLine("You did it in " + count + " times");
                    }
                }
                Console.WriteLine("Do you want to play it again? Y or N");
              
                Boolean check = false;
                while (!check)
                {
                    String c = Console.ReadLine().ToUpper();

                    if (!(c.Equals("Y") || (c.Equals("N"))))
                    {
                        Console.WriteLine("PLease enter only Y or N");
                    }
                    else
                    {
                        if (c.Equals("N"))
                        {
                            check = true;
                            YorN = c;
                        }
                        else check = true;
                    }
                }   
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bye!");
        }
    }
}