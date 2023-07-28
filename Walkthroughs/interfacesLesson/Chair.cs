using System;
namespace interfacesLesson
{
	public class Chair : Furniture, IDestroyable
	{
		public string DestructionSound { get; set; }

		//Constructor
		public Chair(string color, string material)
		{
			this.Color = color;
			this.Material = material;

			DestructionSound = "boom.mp3";
		}

		public void Destroy()
		{
			Console.WriteLine("chair went boom");
			Console.WriteLine("Destuction sound");
			Console.WriteLine("spawn parts");
		}
	}
}

