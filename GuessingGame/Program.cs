using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string secretWord = "USA";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;


        Console.WriteLine("Guess the word!");
        while (guessCount < guessLimit)
        {
            if (guess != secretWord)
            {



                guess = Console.ReadLine();

                guessCount++;
                if (guessCount < guessLimit && guess != secretWord)
                {
                    Console.WriteLine("Try again: ");

                }


            }
            else
            {
                Console.WriteLine("You win");
                break;
            }

        }

        if (guess != secretWord) { 
        Console.WriteLine("You lost!"); }
    }

    
}