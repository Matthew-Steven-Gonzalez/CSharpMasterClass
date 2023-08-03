using System;
namespace AbstractClassesLesson
{
	 abstract public class Shape
	{

		public string Name { get; set; }
		
		public virtual void GetInfo()
		{
			Console.WriteLine("\n this is a {0}",Name);
		}

		public abstract double Volume();
	}
}

