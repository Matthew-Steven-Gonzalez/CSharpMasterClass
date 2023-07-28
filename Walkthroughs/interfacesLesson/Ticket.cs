using System;
namespace interfacesLesson
{
	public class Ticket : IEquatable<Ticket>
	{
		//properties
		public int DurationInHours { get; set; }

		//empty constructor
		public Ticket()
		{
		}

		//simple consturctor
		public Ticket(int durationInHours)
		{
			this.DurationInHours = durationInHours;
		}


		public bool Equals (Ticket other)
		{
			return this.DurationInHours == other.DurationInHours;
		}
	}
}

