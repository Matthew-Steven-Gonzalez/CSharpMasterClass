namespace DecisionMaking
{
    internal class Program
    {
        static string userName;

        static string userNameLogin;

        static string password;

        static string passwordLogin;

        static string confirmation;

        static bool loggingIn = false;

        public static void Main(string[] args) 
        {

            Register();
            Console.WriteLine("Would You like to log in?");
            confirmation = Console.ReadLine();

            while (!loggingIn)
            {

                if (confirmation.ToLower() == "yes" || confirmation.ToLower() == "mmhm" || confirmation.ToLower() == "yeah")
                {
                    Login();
                }
                else
                {
                    Console.WriteLine("Thank you have a good day.");
                }

            }
        }

        public static void Register()
        {
            Console.WriteLine("Please Enter a username: ");
            userName = Console.ReadLine();

            Console.WriteLine("Please enter a password");
            password = Console.ReadLine();

            Console.WriteLine("You have registered.");
            Console.WriteLine("__________________________________________");
        }

        public static void Login() 
        {
            Console.WriteLine("Please enter your username: ");
            userNameLogin = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            passwordLogin = Console.ReadLine();

            if (userName == userNameLogin)
            {
                if (password == passwordLogin)
                {
                    Console.WriteLine("Congrats you have logged in. Thank you.");
                    loggingIn = true;

                }
                else
                {
                    Console.WriteLine("Your password is incorrect sorry.");
                }
            }
            else
            {
                Console.WriteLine("Your username cannot be found.");
            }
        }
    }
}