namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number!");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < 22)
            {
                Console.WriteLine($"Sorry, too low");
                
       
            }
            else if (userInput > 22)
            {
                Console.WriteLine($"Sorry, too high");


            }
            else
            {
                Console.WriteLine($"Awesome! You guessed it!");

            }
        }
    }
}
