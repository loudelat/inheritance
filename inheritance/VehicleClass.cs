using System;
namespace inheritance
{
    public class Vehicle
    {
		string make;
		string color;
		bool isRunning = false;
		int fuelLevel;

		public Vehicle(string make, string color, int fuelLevel)
        {
			this.make = make;
			this.color = color;
			this.isRunning = false;
			this.fuelLevel = fuelLevel;
        }

        public void printDetails()
		{
			Console.WriteLine("The " + this.color + " " + this.make + " has a fuel level of " + this.fuelLevel + ". Is it running? " + this.isRunning);
		}
    }
}
