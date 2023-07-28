using System;
namespace interfacesLesson
{
	public class Car : Vehicle,IDestroyable
	{
        public string DestructionSound { get; set; }


		public List<IDestroyable> DestroyablesNearby;


        public Car(float speed, string color)
		{
			this.Speed = speed;
			this.Color = color;
			this.DestructionSound = "boom.mp3";
			this.DestroyablesNearby = new List<IDestroyable>();
		}

		public void Destroy()
		{
			Console.WriteLine("play boom sound file");
			Console.WriteLine("create fire");

			foreach(IDestroyable destroyable in DestroyablesNearby)
			{
				destroyable.Destroy();
			}
		}
	}
}

