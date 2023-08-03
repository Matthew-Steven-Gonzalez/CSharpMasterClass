using System.IO;

namespace ReadANDWriteToTextFileLesson;

class Program
{
    static void Main(string[] args)
    {
        //reading from a file

        //reading all at once.
        //string text = System.IO.File.ReadAllText(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/Untitled.txt");

        //Console.WriteLine(text);


        ////reading line by line
        //string[] lines = System.IO.File.ReadAllLines(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/Untitled.txt");

        //foreach(string line in lines)
        //{
        //    Console.WriteLine($"\t {line}");
        //}

        //Writing to a text file

        //string[] lines = { "250", "242", "240", "239" };

        //File.WriteAllLines(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/highScores.txt", lines);

        //Console.WriteLine(System.IO.File.ReadAllText(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/highScores.txt"));

        ////making a note

        //Console.WriteLine("Please enter your note :");

        //string input = Console.ReadLine();

        //Console.WriteLine("Please enter where the note should be saved : ");

        //string fileName = Console.ReadLine();

        //File.WriteAllText(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/" + fileName + ".txt",input);

        string fileName = @"/Users/muffins/Downloads/input.txt";

        IEnumerable<string> lines = File.ReadLines(fileName);

        //foreach(string line in lines)
        //{
        //    string[] finalProduct;

        //    if(line.Contains("split"))
        //    {

        //        string[] newlines = line.Split();

        //        Console.Write(newlines[4] + " ");

        //        File.WriteLine(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/output.txt" , newlines[4] + " ");

        //    }
        //}

        using (StreamWriter file = new StreamWriter(@"/Users/muffins/Projects/CSharpMasterClass/Walkthroughs/ReadANDWriteToTextFileLesson/output.txt"))
        {
            foreach(string line in lines)
            {
                if(line.Contains("split"))
                {
                    string[] newlines = line.Split();

                    file.NewLine = "";

                    file.WriteLine(newlines[4] + " ");
                }
            }
        }



            //foreach(string line in lines)
            //{
            //    if (line.Contains("split"))
            //    {
            //        string[] lineAfterSplit = line.Split("split");

            //        File.WriteAllText(@"/Users/muffins/Downloads/input.txt", lineAfterSplit[4]);

            //        Console.WriteLine(File.ReadAllText(@"/Users/muffins/Downloads/input.txt"));
            //    }
            //}

            Console.ReadKey();
    }
}

