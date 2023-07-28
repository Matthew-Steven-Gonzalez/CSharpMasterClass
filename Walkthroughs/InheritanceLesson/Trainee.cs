using System;
namespace InheritanceLesson
{
	public class Trainee : Employee
	{

		public int WorkingHours{get; set;}

		public int SchoolHours { get; set; }


		public Trainee()
		{
		}

		public Trainee(string name, string firstName, double salary, int workingHours, int schoolHours): base(name,firstName,salary)
		{
			this.WorkingHours = workingHours;
			this.SchoolHours = schoolHours;
		}

		public void learn()
		{
			Console.WriteLine($"{Name} is studying for {SchoolHours} hours");
		}

        public override void Work()
        {
			Console.WriteLine($"{WorkingHours}");
           
        }
    }
}

