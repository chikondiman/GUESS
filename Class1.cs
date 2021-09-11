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
            Console.Write("Guess a number in between 0-100");
        } while (win == false);
    }
}
