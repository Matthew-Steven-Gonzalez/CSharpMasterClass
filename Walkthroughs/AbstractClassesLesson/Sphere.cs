using System;
namespace AbstractClassesLesson
{
	public class Sphere : Shape
	{
        public double Radius { get; set; }

        public Sphere(double radius)
		{
            this.Name = "Sphere";
            this.Radius = radius;
		}

        public override void GetInfo()
        {
            Console.WriteLine("\n this is a {0} it has a radius of {1}", Name,Radius);
        }

        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4/3;
        }
    }
}

