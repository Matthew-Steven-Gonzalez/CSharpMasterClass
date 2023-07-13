namespace MultiDimensionalArrays;

class Program
{
    static void Main(string[] args)
    {
        /*
        // declare 2 - d array
        string[,] matrix;
        //3-d array
        int[,,] threeD;
        //two dimensional array
        int[,] array2d = new int[,]
        {
            {1,2,3 }, //row 0
            {4,5,6 }, //row 1
            {7,8,9 }  //row 2
        };
        Console.WriteLine("The central file is : {0}", array2d[1, 1]);
        Console.WriteLine("If this work you see a 7 after this {0}", array2d[2, 0]);
        //3d array
        string[,,] array3d = new string[,,]
        {
            {
                {"000", "001"},
                {"010", "011"},
                {"Hi there", "What's Up" }
            },
            {
                {"100", "101" },
                {"110", "111" },
                {"another one", "last entry"}
            }
        };
        //another way to make a mult array
        string[,] array2dstring = new string[3, 2]
        {
            { "one", "two" },
            { "three", "four" },
            { "five", "six" }
        };
        //how to find how many rows exsist
        int dimension = array2dstring.Rank;
        //a way to auto make a multidim array
        int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
        array2dstring[1, 1] = "chicken";
        Console.WriteLine("{0}", array2dstring[1, 1]);
        Console.WriteLine("{0}", dimension);
        Console.ReadKey();
        */

        int[] happiness = { 1, 2, 3, 4, 5 };

        sunShine(happiness);

        Console.ReadKey();

    }
    //tic tac toe checker
    public static bool Checker(string[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            //for horizontal wins
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return true;
            }
            //for verticle wins
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                return true;
            }
        }
        //both logics for diagonal wins
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return true;
        }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return true;
        }
        return false;
    }

    public static void sunShine(int[] happiness)
    {
        for(int i = 0; i <happiness.Length;i++)
        {
            happiness[i] += 2;
            Console.WriteLine("{0}", happiness[i]);
        }

    }

}

