using System;

namespace InheritanceLesson
{
	//child class = radio , parent class(base class) electircal device
	public class Radio : ElectricalDevice
	{

		//constructor with 2 params
		public Radio(bool isOn, string brand):base(isOn, brand)
		{
			
		}

		//method for listening to radio

		public void ListenRadio()
		{
			if(IsOn)
			{
				//listening to radio
				Console.WriteLine("Listening to the jams.");
			}
			else
			{
				//error message
				Console.WriteLine("Radio is off, please turn it on to jam.");
			}
		}
    }
}

