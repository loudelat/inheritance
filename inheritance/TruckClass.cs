using System;
namespace inheritance
{
    public class TruckClass
    {
		int flatbedLength;

        public TruckClass(string make, string color, int fuelLevel, int flatbedLength)
        {
			this.flatbedLength = flatbedLength;
        }
    }
}
