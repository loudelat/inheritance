using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
			Vehicle newVehicle = new Vehicle("AcmeVehicle", "Gray", 5);
			    newVehicle.printDetails();

			CarClass newCarClass = new CarClass("AcmeCar", "Black", 15, 10);
			    newCarClass.printDetails();

			TruckClass newTruckClass = new TruckClass("AcmeTruck", "White", 25, 20);
       }
    }
}
