// Anita Martin
// amartin98@cnm.edu
// Title: Vehicle Class Inventory

// Vehicle.cs

namespace AMartin_VehicleInventory
{

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();

    }
}
