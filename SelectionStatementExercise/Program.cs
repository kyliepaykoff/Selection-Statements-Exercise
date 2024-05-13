namespace SelectionStatementExercise
{
    public class Program
    {
        static void 
        
            Main(string[] args)
            {

            PrintThousand();
            Threes();
            int a = 22;
            int b = 22;
            if (IsEqual(a, b))
            {
                Console.WriteLine($"{a} and {b} are equal.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal.");
            }
            int c = 5;
            if (IsEvenOdd(c))
            {
                Console.WriteLine($"The number is even.");
            }
            else
            {
                Console.WriteLine($"The number is odd.");
            }
            int d = -7;
            if (IsPositive(d))
            {
                Console.WriteLine($"{d} is positive.");
            }
            else
            {
                Console.WriteLine($"{d} is negative.");
            }
            Console.WriteLine("Please enter your age:");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (CanVote(age))
                {
                    Console.WriteLine("Congrats, you're old enough to vote!");
                }
                else
                {
                    Console.WriteLine("Sorry, you're not old enough to vote.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid age.");
            }
            Console.WriteLine($"Please enter a number from -10 to 10.");
            int e;
            if (int.TryParse(Console.ReadLine(), out e))
            {
                if (InRange(e))
                {
                    Console.WriteLine($"Good job!");
                }
                else
                {
                    Console.WriteLine($"Sorry, that is not in range.");

                }
            }
            Console.WriteLine($"Enter a number.");
            int f;
            if (int.TryParse(Console.ReadLine(), out f))
            {
                DisplayMultiplicationTable(f);
            }
            else
            {
                Console.WriteLine($"Please enter a valid number.");
            }



            } 

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool IsEqual(int a, int b)
        {

            return a == b;

        }
        public static bool IsEvenOdd(int c)

        {


            return c % 2 == 0;


        }
        public static bool IsPositive(int number)
        {
            return number > 0;
        }
        public static bool CanVote(int age)
        {
            const int votingAge = 18;
            return age >= votingAge;
        }
        public static bool InRange(int e)
        {
            return e >= -10 && e <= 10;
        }
        public static void DisplayMultiplicationTable(int f)
        {


            Console.WriteLine($"Multiplication table of {f}");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{f} x {i}; = {f * i}");
            }
        }






    } 

}