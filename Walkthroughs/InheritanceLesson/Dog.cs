using System;
namespace InheritanceLesson
{
	public class Dog: Animal
	{
		public bool IsHappy { get; set; }

		//constructor
		public Dog(string name, int age):base(name, age)
		{
			// you can add other properties in subclass not included in base class.
			IsHappy = true;
		}

		//override allows subclass to override base class.
		public override void Eat()
		{
			//to call base method from parent class
			base.Eat();
		}

        public override void MakeSound()
        {
			Console.WriteLine("Bark Bark");
        }

        public override void Play()
        {
			if(IsHappy)
			{
                base.Play();
            }
			else
			{
				Console.WriteLine("The dog doesn't feel like playing.");
			}	
        }

    }
}

