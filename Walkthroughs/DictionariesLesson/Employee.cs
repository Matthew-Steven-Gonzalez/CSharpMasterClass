﻿using System;
namespace DictionariesLesson
{
	public class Employee
	{
		public string Role { get; set; }

		public string Name { get; set; }

		public int Age { get; set; }

		public float Rate { get; set; }

		public float Salary
		{
			get
			{
				return Rate * 8 * 5 * 4 * 12; 
			}
		}

		public Employee(string role, string name, int age, float rate)
		{
			this.Role = role;
			this.Age = age;
			this.Name = name;
			this.Rate = rate;
			
		}
	}
}

