namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(0, 1000);
            int userInput;

            do
            {
                Console.WriteLine("Guess my favorite number! From 1-1000.");

                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"Sorry, too low");


                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Sorry, too high");


                }
                else
                {
                    Console.WriteLine($"Awesome! You guessed it!");


                }
                
                
            } while (userInput != favNumber);
        }
    }
}
