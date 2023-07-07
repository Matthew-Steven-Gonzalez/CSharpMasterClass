namespace Arrays;

class Program
{
    static void Main(string[] args)
    {

        /*
        //intializing the arry
        int[] grades = new int[5];

        //assiging values to the indexes of the array
        grades[0] = 15;
        grades[1] = 90;
        grades[2] = 100;
        grades[3] = 60;
        grades[4] = 75;
        Console.WriteLine("First grade in the array is {0}", grades[0]);

        //using input values for assiging
        Console.WriteLine("Enter a grade");
        int input = int.Parse(Console.ReadLine());
        grades[0] = input;
        Console.WriteLine("First grade in the array is {0}", grades[0]);


        //another way to intialize
        int[] allStudentGrades = {90, 91, 93, 100, 15};
        Console.WriteLine(allStudentGrades[2]);

        //third way to do it
        int[] allStudentsGrades2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(allStudentsGrades2.Length);

        Console.ReadKey();
        */

        int[] nums = new int[10];

        //assiging the index to each index in the array. using for loops
        for(int i = 0; i < 10;i++)
        {
            nums[i] = i + 1;
        }

        for(int j = 0; j < nums.Length;j++)
        {
            Console.WriteLine("Element at index: {0} = {1}", j , nums[j]);
        }

        int counter = 0;
        foreach(int k in nums)
        {
            Console.WriteLine("Element at index: {0} = {1}", counter, k);
            counter++;
        }


        //create an array with 5 of your best friends
        //create a foreach loop that greets them all

        string[] friends = {"Monica", "Rachel", "Ross", "Chandler", "Joey", "Phobee"};

        foreach(string friend in friends)
        {
            Console.WriteLine("Hello {0}", friend);
        }

        Console.ReadKey();
    }
}

