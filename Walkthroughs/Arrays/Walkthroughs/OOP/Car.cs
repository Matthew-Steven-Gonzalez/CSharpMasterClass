﻿using System;
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
        private int _maxSpeed;

        
        //public properties
        public string Name {
            get { return _name; } // get accessor
            set {
                if(value == "")
                {
                    _name = "Hello World From default Name";
                    
                }
                else { _name = value; }
                }
            
        }

        //autoImplemented properties

        //public int MaxSpeed { get; set; }

        //read-only
        //public int MaxSpeed { get; } = 10;

        //write-only
        public int MaxSpeed
        {
            set
            {
                _maxSpeed = value;
            }
        }

        //constructors
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "Red";
            Drive();
            Console.Write(_color + " " + _name + " was created.\n");

        }

        public Car (string? name, int hp)
        {
            _color = "Red";
            Console.Write( _color + " " +_name + " was created.\n");

        }

        public Car(string name, int hp, string color = "black") 
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.Write(name + " was created.\n");
        }


        //member methods
        private void Drive()
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
