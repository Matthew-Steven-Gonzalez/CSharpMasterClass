using System;
namespace InheritanceLesson
{
	public class Animal
	{
		//properties
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsHungry { get; set; }

		//constructor
		public Animal(string name, int age)
		{
			this.Name = name;
			this.Age = age;
			this.IsHungry = true;
		}

		//virtual allows sub classes to Override base clasee using overide keyword
		//method for sound
		public virtual void MakeSound()
		{
			Console.WriteLine("{0} made a animal sound.", Name);
		}

		//method for eat
		public virtual void Eat()
		{
			if(IsHungry)
			{
                Console.WriteLine($"{Name} is eating and is no longer hungry");
                IsHungry = false;
            }
			else
			{
				Console.WriteLine($"{Name} is not hungry.");
			}
			
		}

		//method for play
		public virtual void Play()
		{
			Console.WriteLine("{0} is playing.", Name);
		}

	}
}

