using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;

        public Car(string name, int hp, string color = "black") 
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.Write(name + " was created.\n");
        }

        public void Drive()
        {
            Console.WriteLine(_name +" is driving.");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " has stopped.");
        }

        public void CarInfo()
        {
            Console.WriteLine("The car is a "+ _color + " " + _name);
            Console.WriteLine("It has {0} horsepower.", _hp);
        }

    }


}
