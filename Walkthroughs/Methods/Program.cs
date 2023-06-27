namespace methods
{
    internal class Program
    {
        const string friend1 = "Tony";
        const string friend2 = "Greg";
        const string friend3 = "Teri";

        static void Main(string[] args)
        {
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try 
            {
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void GreetFriend(string friend) 
        {
            Console.WriteLine("Hello " + friend + "!");
        }

   
    }
}