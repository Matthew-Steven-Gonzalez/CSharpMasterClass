using System;
namespace InheritanceLesson
{
	public class Boss : Employee
	{

		public bool CompanyCar { get; set; }


		public Boss()
		{
		}

		public Boss(string name, string firstName, double salary, bool companyCar):base(name,firstName, salary)
		{
			CompanyCar = companyCar;
		}

		public void Lead()
		{
			Console.WriteLine($"{Name} is in charge.");
		}
	}
}

