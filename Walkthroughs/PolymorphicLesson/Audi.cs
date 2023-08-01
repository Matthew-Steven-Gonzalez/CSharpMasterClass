using System;
namespace PolymorphicLesson
{
	public class Audi : Car
	{
		public string Model { get; set; }

		private string Brand;

		public Audi(string color, int hp, string model): base(color, hp)
		{
			this.Model = model;
			this.Brand = "Audi";
			Console.WriteLine("Congrats on your new {0}",Brand);
		}

        public override void ShowDetails()
        {
            Console.WriteLine($"The {Brand} is {Color} and has a horsepower of {HP}");
        }

        public override void RepairCar()
        {
            Console.WriteLine($"The {Brand} has been repaired.");
        }
    }
}

