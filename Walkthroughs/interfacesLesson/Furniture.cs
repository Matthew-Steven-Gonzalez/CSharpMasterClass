using System;
namespace interfacesLesson
{
	public class Furniture
	{

		public string Color { get; set; }

		public string Material { get; set; }


		//default constructor
		public Furniture()
		{
			Color = "white";
			Material = "wood";
		}

		//constructor
		public Furniture(string color, string material)
		{
			this.Color = color;
			this.Material = material;
		}
	}
}

 