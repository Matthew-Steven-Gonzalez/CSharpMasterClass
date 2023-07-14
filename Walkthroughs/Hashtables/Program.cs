using System.Collections;
namespace Hashtables;

class Program
{

    //Key - Value pair
    //ID - object

    public static void iterateStudents(Student[] students)
    {
        Hashtable interateTable = new Hashtable();

        foreach (Student alumni in students)
        {
            if (!interateTable.ContainsKey(alumni.Id))
            {
                interateTable.Add(alumni.Id, alumni);
                Console.WriteLine("{0} was added.", alumni.Name);
            }
            else
            {
                Console.WriteLine("ID is already in system.");
            }
        }
    }

    static void Main(string[] args)
    {
        /*
        Hashtable studentsTable = new Hashtable();

        Student stud1 = new Student(1, "John", 98);
        Student stud2 = new Student(2, "Johnny", 98); 
        Student stud3 = new Student(3, "Johnathan", 98);
        Student stud4 = new Student(4, "John-boy", 96);

        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        studentsTable.Add(stud4.Id, stud4);


        //retrieve with known ID
        Student storedStudent1 = (Student)studentsTable[stud1.Id];

        //retrieve all entries
        foreach(DictionaryEntry entry in studentsTable)
        {
            Student temp = (Student) entry.Value;

            Console.WriteLine("Student Name : {0}", temp.Name);
            Console.WriteLine("Student ID : {0}", temp.Id);
            Console.WriteLine("Student GPA: {0}" ,temp.GPA);
            Console.ReadKey();
        }

        Console.WriteLine("Student Id: {0} / Student name: {1} / Students GPA: {2}", stud1.Id, stud1.Name,stud1.GPA);

        foreach(Student alumni in studentsTable.Values)
        {
            Console.WriteLine("Student Name : {0}", alumni.Name);
            Console.WriteLine("Student ID : {0}", alumni.Id);
            Console.WriteLine("Student GPA: {0}", alumni.GPA);

        */

        Student[] collectionOfStudents = new Student[5];

        collectionOfStudents[0] = new Student(0, "Terry", 3.4f);
        collectionOfStudents[1] = new Student(1, "Rodney", 3.4f);
        collectionOfStudents[2] = new Student(2, "Tara", 3.4f);
        collectionOfStudents[3] = new Student(3, "T'chala", 3.4f);
        collectionOfStudents[4] = new Student(0, "Sam", 3.4f);

        iterateStudents(collectionOfStudents);

        Console.ReadKey();
        }

   
}

  
    




class Student
{

    //property for ID
    public int Id { get; set; }

    //property for Name
    public string Name { get; set; }

    //property for GPA
    public float GPA { get; set; }

    //simple constructor
    public Student(int id, string name, float gpa)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = gpa;
    }
}


