using System;
namespace inheritance
{
	public class CarClass : VehicleClass
    {
		int trunkWidth;

        public CarClass(string make, string color, int fuelLevel, int trunkWidth)
			:base(make, color, fuelLevel)
        {
			this.trunkWidth = trunkWidth;
        }
    }
}
