using System.Collections.Generic;
namespace DictionariesLesson;

class Program
{

    //key - value pair


    static void Main(string[] args)
    {
        Queue<string> aLine = new Queue<string>();

        Dictionary<int, string> myDictionary = new Dictionary<int, string>()
        {
            {1,"one" },
            {2, "two" },
            {3, "three" }
        };

        Employee[] employees =
        {
            new Employee("CEO","John",21,21),
            new Employee("Manager","John",21,20),
            new Employee("Human Resources","John",21,19),
            new Employee("Secretary","John",21,18),
            new Employee("Lead Developer","John",21,17),
            new Employee("Intern","John",21,1)
        };


        Dictionary <string, Employee> employeeDirectory = new Dictionary<string, Employee>();
        foreach(Employee emp in employees)
        {
            employeeDirectory.Add(emp.Role, emp);
        }

        string keyToUpdate = "Human Resources";

        if (employeeDirectory.ContainsKey(keyToUpdate))
        {
            employeeDirectory[keyToUpdate] = new Employee("Human Resources", "Juan", 21, 2);
        }

        Employee empl= employeeDirectory["CEO"];

        Console.WriteLine("Employee name : {0} and their role is {1}", empl.Name, empl.Role);
        Console.ReadKey();
    }
}
 
