using System;
namespace PolymorphicLesson
{
	public class Car
	{
		public string Color { get; set; }

		public int HP { get; set; }

		//has a

		protected CarIDInfo carIDInfo = new CarIDInfo();

		public void SetCarIDInfo(int idNum, string owner)
		{
			carIDInfo.IDnum = idNum;
			carIDInfo.Owner = owner;
		}

		public void GetCarIDInfo()
		{
			Console.WriteLine($"The car has an Id of {});
		}

		public Car( string color, int hp)
		{
			this.Color = color;
			this.HP = hp;
		}

		public Car() { }



		public virtual void ShowDetails()
		{
			Console.WriteLine($"The car is {Color} and has a horsepower of {HP}");
		}

		public virtual void RepairCar()
		{
			Console.WriteLine("The Car has been repaired.");
		}
	}
}

