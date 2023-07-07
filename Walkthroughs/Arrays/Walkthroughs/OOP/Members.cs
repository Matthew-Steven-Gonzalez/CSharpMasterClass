using System;
namespace OOP
{
	public class Members
	{

		//members - prvivate field
		private string memberName;
		private string jobTitle;
		private int salary;

		//members - public field
		public int age;


		//member - property
		public string JobTitle
		{
			get
			{
				return jobTitle;
			}
			set
			{
				jobTitle = value;
			}
		}


		// member-  method
		public void Introducing(bool isFriend)
		{
			if(isFriend)
			{
				SharingPrivateInfo();
			}
			else
			{
				Console.WriteLine("Hi my name is {0} and my job title is {1}. I am {2} years old.",memberName,jobTitle,age);
			}
		}

		private void SharingPrivateInfo()
		{
			Console.WriteLine("My salary is {0}", salary);
		}

		// member - constructor
		public Members()
		{
			age = 30;
			memberName = "lucy";
			salary = 60000;
			jobTitle = "Developer";
			Console.WriteLine("Object Created");
		}

		//member - finalizer destructor
		~Members()
		{
			//cleanup statements
			Console.WriteLine("Deconstruction of members object");
		}
	}
}

