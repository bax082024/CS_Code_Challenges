using System;

namespace CS_Code_Challenges.Classes;

public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 7; // Assign the secret value
        int? guess = -1;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine()); 

            // Todo: Implement the correct conditionals inside the while loop.
            if (guess < secret)
            {
                Console.WriteLine("Too Low! Guess Again!");
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too High! Guess Again!");
            }
            else
            {
                Console.WriteLine("YAAAAYYYY! You Guessed The Secret Number!!!");
            }
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.WriteLine($"{a} + {b} + ");
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        // c = a + b;
        // a = b;
        // b = c;
        for (int i = 2; i<n; i++)
        {
            c = a + b;
            Console.WriteLine($"{c} ");
            a = b;
            b = c;
        }

        Console.WriteLine(); // just a new line after the sequence
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"

        // Check the first Number:
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
        }
        else 
        {
            Console.WriteLine($"{a} is odd");
        }

        // Check the second Number:

        if (b % 2 == 0)
        {
            Console.WriteLine($"{b} is even");
        }
        else
        {
            Console.WriteLine($"{b} is odd");
        }

        Console.WriteLine();
    }
}