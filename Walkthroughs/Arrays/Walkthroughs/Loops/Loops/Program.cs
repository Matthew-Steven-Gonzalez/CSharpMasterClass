namespace Loops
{
    internal class Program
    {
        public static int average;
        public static int total = 0;
        public static int grade = 0;
        public static int counter = 0;

        public 
        static void Main(string[] args)
        {
            //Challenge build a for loop that prints odd numbers

            for(int i = 1; i <= 20;i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //loops 1 challenge

            Console.WriteLine("Welcome to average");
            Console.WriteLine("------------------");
            Console.WriteLine("Enter -1 to see average of all grades");
            while (grade != -1)
            {
                Console.WriteLine("Enter a grade between 0-20");
                Console.WriteLine("Please enter grade: ");
                if (Int32.TryParse(Console.ReadLine(), out grade))
                {
                    if(grade == -1)
                    {
                        continue;
                    }

                    if(grade <= 20  && grade >= 0 )
                    {
                        total += grade;
                        counter++;
                        Console.WriteLine("You have entered {0} grades.", counter);
                    }
                    else
                    {
                        Console.WriteLine("Your number is outside the parameters.");
                    }
                }
                else
                {
                    Console.WriteLine("You entered a non numerical value.");
                }
            }
            try
            {
                Console.WriteLine("The average is {0}", average = total / counter);

            }catch (Exception)
            {
                Console.WriteLine("you entered no numbers");
            }

        }

    }
}