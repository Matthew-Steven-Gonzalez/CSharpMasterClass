namespace ticTacToe;

class Program
{

    static string[,] values = new string[,]{
        { "1","2","3"},
        { "4","5","6" },
        { "7","8","9" }
    };

    

    static void Main(string[] args)
    {
        int player = 2;
        int input = 0;
        bool inputCorrect = true;


        do
        {
            

            //choose which player is playing
            if (player == 2)
            {
                player = 1;
                XorO(player, input);

            }
            else if(player == 1)
            {
                player = 2;
                XorO(player, input);

            }

            grapicVisual();

            //check winning condition
            string[] playerStrings = { "X", "O"};

            foreach (string playerString in playerStrings)
            {
                if ((values[0, 0] == playerString) && (values[0, 1] == playerString) && (values[0, 2] == playerString))
                {
                    Console.WriteLine("We have a winner.");
                }
            }

            //checking if position taken
            do
            {
                Console.WriteLine("Player {0} : Choose your field", player);
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Please enter a number.");
                }

                if(input == 1 && values[0,0] == "1")
                {
                    inputCorrect = true;
                }
                else if(input == 2 && values[0,1] == "2")
                {
                    inputCorrect = true;
                }
                else if (input == 3 && values[0, 2] == "3")
                {
                    inputCorrect = true;
                }
                else if (input == 4 && values[1, 0] == "4")
                {
                    inputCorrect = true;
                }
                else if (input == 5 && values[1, 1] == "5")
                {
                    inputCorrect = true;
                }
                else if (input == 6 && values[1, 2] == "6")
                {
                    inputCorrect = true;
                } 
                else if (input == 7 && values[2, 0] == "7")
                {
                    inputCorrect = true;
                }
                else if (input == 8 && values[2, 1] == "8")
                {
                    inputCorrect = true;
                }
                else if (input == 9 && values[2, 2] == "9")
                {
                    inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("\nIncorrect input please use another field. ");
                    inputCorrect = false;
                }

            } while (!inputCorrect);







        } while (true);

    }

    public static void grapicVisual()
    {
        Console.Clear();
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[0,0], values[0,1], values[0,2]);
        Console.WriteLine("     |     |     ");
        Console.WriteLine("----- ----- -----");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[1, 0], values[1, 1], values[1, 2]);
        Console.WriteLine("     |     |     ");
        Console.WriteLine("----- ----- -----");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[2, 0], values[2, 1], values[2, 2]);
        Console.WriteLine("     |     |     ");
    }

    public static void XorO(int player, int input)
    {
        string playerSign = "" ;

        if(player == 1)
        {
            playerSign = "X";
        }
        else if(player == 2)
        {
            playerSign = "O";
        }

        switch (input)
        {
            case 1:
                values[0, 0] = playerSign;
                break;
            case 2:
                values[0, 1] = playerSign;
                break;
            case 3:
                values[0, 2] = playerSign;
                break;
            case 4:
                values[1, 0] = playerSign;
                break;
            case 5:
                values[1, 1] = playerSign;
                break;
            case 6:
                values[1, 2] = playerSign;
                break;
            case 7:
                values[2, 0] = playerSign;
                break;
            case 8:
                values[2, 1] = playerSign;
                break;
            case 9:
                values[2, 2] = playerSign;
                break;


        }
    }

    
}

