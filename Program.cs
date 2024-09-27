namespace CS_Code_Challenges;

using CS_Code_Challenges.Classes;

class Program
{
    static void Main(string[] args)
    {
        

        // Create an instance of Challenge_one, Challange_two and Challenge_three
        Challenge_one one = new Challenge_one();
        Challenge_two two = new Challenge_two();
        Challenge_three three = new Challenge_three();
        
        // Challenge One: Print Numbers
            Console.WriteLine("Testing PrintNumbers:");
            one.PrintNumbers();
            Console.WriteLine();

        // Challenge One: Print Strings
            Console.WriteLine("Testing PrintStrings:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            one.PrintStrings(fruits);
            Console.WriteLine();

        // Challenge One: Check Positive or Negative
            Console.WriteLine("Testing CheckIfNumberIsPositiveOrNegative:");
            one.CheckIfNumberIsPositiveOrNegative(5);
            one.CheckIfNumberIsPositiveOrNegative(-3);
            one.CheckIfNumberIsPositiveOrNegative(0);
            Console.WriteLine();

        
        // Challenge Two: Play Guess Number Game
            Console.WriteLine("Starting the Guess Number Game:");
            two.GuessNumber();
            Console.WriteLine();

            

        // Challenge Three: FizzBuzz
            Console.WriteLine("Testing FizzBuzz:");
            three.FizzBuzz();
            Console.WriteLine();

            // Challenge Three: Reverse String
            Console.WriteLine("Testing ReverseString:");
            string reversed = three.ReverseString("Hello World");
            Console.WriteLine($"Reversed String: {reversed}");

        
        
        
        

         


        
        // validate some methods
        void ValidateRecursiveFactorial(Challenge_three three)
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        // Validate Recursive Factorial from Challenge Three
            ValidateRecursiveFactorial(three);
            Console.WriteLine();
    }
}
