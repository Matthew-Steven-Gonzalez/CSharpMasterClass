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

        static int highScore = 0;

        static string highPlayerName;

        public static void Main(string[] args) 
        {
            /*
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
                    loggingIn = true;
                }

            }

            gameScore(97, "James");
            gameScore(37, "Tony");
            gameScore(99, "Ezekiel");
            */

            /*
            int temperature = -6;
            string stateOfMatter;

            if(temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else if(temperature > 0 && temperature < 100 )
            {
                stateOfMatter = "liquid";
            }
            else
            {
                stateOfMatter = "Gas";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature = 120;

            //enhanced if statement
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            */

            //Enchanced If statements challenge

            Console.WriteLine("Please enter a tempertaure");
            string input = Console.ReadLine();
            string tempInfo;
            int x;

            // if statement to check if input is a valid number
            if(int.TryParse(input, out x))
            {
                //enhanced if statement checking temp logic
                tempInfo = x <= 15 ? "it is too cold here" : x > 28 ? "it is too hot here" : "it is ok";
                Console.WriteLine(tempInfo);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
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
        public static void gameScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highPlayerName = playerName;
                Console.WriteLine("New High Score is " + highScore + "\nNew highscore holder is " + highPlayerName + ".");
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highPlayerName + "."); 
            }
        }
    }

  
}