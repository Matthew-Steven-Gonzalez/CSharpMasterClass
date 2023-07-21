using System;
namespace InheritanceLesson
{
	public class TV : ElectricalDevice
	{

        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        //method for watching
        public void WatchingTv()
        {
            if(IsOn)
            {
                Console.WriteLine("wonder what else is on...");
            }
            else
            {
                Console.WriteLine("you should turn the Tv on if you want to watch it.");
            }
        }

	}
}

