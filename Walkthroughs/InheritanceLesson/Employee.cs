using System;
namespace InheritanceLesson
{
	public class Employee
	{

		public string Name { get; set; }

		public string FirstName { get; set; }

		public double Salary { get; set; }


		public Employee()
		{
		}

		public Employee(string name, string firstName, double salary)
		{
			this.Name = name;
			this.FirstName = firstName;
			this.Salary = salary;
		}

		public virtual void Work()
		{
			Console.WriteLine($"{Name} is working.");
		}

		public void Pause()
		{
			Console.WriteLine($"{Name} has paused working.");
		}
	}
}

