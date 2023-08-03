using System;
namespace AbstractClassesLesson
{
	public class Cube : Shape
	{
        public double Length { get; set; }

        public Cube(double length)
		{
            this.Length = length;
            this.Name = "Cube";
		}

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\n this is a {0} with a length of {1}", Name, Length);
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
    }
}

