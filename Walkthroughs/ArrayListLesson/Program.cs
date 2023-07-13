using System.Collections;

namespace ArrayListLesson;

class Program
{
    static void Main(string[] args)
    {
        //declaring an ArrayList with undefined amount of objects
        ArrayList myArrayList = new ArrayList();
        //declaring an ArrayList with defined amount of objects
        ArrayList myArrayList2 = new ArrayList(100);

        //Arraylist take all types of datatypes using .Add();

        string[] list = new string[] { "junk", "Stuff", "other" };

        //strings
        myArrayList.Add("Hello");
        //ints
        myArrayList.Add(25);
        myArrayList.Add(34);
        myArrayList.Add(24);
        //double
        myArrayList.Add(35.3);
        myArrayList.Add(-44.3);
        //other arrays
        myArrayList.Add(list);

        double sum = 0;

        foreach(object obj in myArrayList)
        {
            if(obj is int)
            {
                sum += Convert.ToDouble(obj);
            }
            else if(obj is double)
            {
                sum += (double) obj;
            }
            else if(obj is string)
            {
                Console.WriteLine(obj);
            }
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}

