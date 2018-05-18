using System;
namespace inheritance
{
	public class TruckClass : VehicleClass
    {
		int flatbedLength;

        public TruckClass(string make, string color, int fuelLevel, int flatbedLength)
			: base(make, color, fuelLevel)
        {
			this.flatbedLength = flatbedLength;
        }
    }
}
