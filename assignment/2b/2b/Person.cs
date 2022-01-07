using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2b
{
    class Person
    {
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
		}
		public void print()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}
}

