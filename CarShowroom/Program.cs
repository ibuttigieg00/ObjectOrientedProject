using CarShowroom;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicleList = new List<Vehicle>();

        Showroom showroom = new Showroom();
        showroom.AddVehicle(new Car(550, 2.5, "Subaru", "Impreza WRX STI", "Blue"));
        showroom.AddVehicle(new Car(89, 1.2, "Suzuki", "Swift", "Pearl White"));
        showroom.AddVehicle(new Boat("speed boat", 27, 2, false, true, "Chaudron", "SVJ", "red"));

        vehicleList = showroom.GetSpecificVehicleType(typeof(Car));

        foreach(Vehicle vehicle in vehicleList)
        {
            Console.WriteLine(vehicle.Brand);
            Console.WriteLine(vehicle.Colour);
            Console.WriteLine(vehicle.Model);
        }
        Console.ReadKey();
    }
}





