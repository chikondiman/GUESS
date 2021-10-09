using System;

public class Class1
{
	static void Main(string[] args)
    {
        Random r = new Random()
            int winNum = r.Next(0, 100);
        bool win = false;
        do
        {
            Console.Write("Guess a number in between 0-100!");
            string a = Console.ReadLine();

            int i = int.Parse(s);

            if (i > winNum)
            {
                Console.WriteLine("Too High! Guess lower.....");
            }

         

            else if (i == winNum)
            {
                Console.WriteLine("YOU WIN!");
            }
            Console.WriteLine();
        } while (win == false);
        Console.Write("Thank you for playing the game!");
    }
}
