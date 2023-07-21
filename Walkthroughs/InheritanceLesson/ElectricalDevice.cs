using System;
namespace InheritanceLesson
{
	public class ElectricalDevice
	{
        //bool for if electrical device is on or not
        public bool IsOn { get; set; }

        //string for brand of electical device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
		{
            this.IsOn = isOn;
            this.Brand = brand;
		}

        //method for turning on electrical device
        public void TurnOn()
        {
            IsOn = true;
        }

        //method for turning off electrical device
        public void TurnOff()
        {
            IsOn = false;
        }
    }
}

