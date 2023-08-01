using System;
namespace PolymorphicLesson
{
	// a BMW is A Car
	public class BMW : Car
	{
		public string Model { get; set; }

		private string Brand;

		public BMW(string color, int hp, string model) : base(color, hp)
		{
			this.Model = model;
			this.Brand = "BMW";
			Console.WriteLine($"Congrats on your new {Brand}");
		}

		public BMW() { }


        public override void ShowDetails()
        {
            Console.WriteLine($"The {Brand} is {Color} and has a horsepower of {HP}");
        }

        public sealed override void RepairCar()
        {
            Console.WriteLine($"The {Brand} has been repaired.");
        }
    }
}

