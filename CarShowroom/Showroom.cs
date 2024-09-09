namespace CarShowroom
{
    public class Showroom : IShowroom
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        public List<Car> carList = new List<Car>();
        public List<Boat> boatList = new List<Boat>();
        public void AddVehicle(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
            Type type = vehicle.GetType();
            type.GetProperties();
            if(vehicle is not null)
            {
                if (vehicle is Car)
                {
                    Car? car = vehicle as Car;
                    carList.Add(car);
                }
                else if (vehicle is Boat)
                {
                    Boat? boat = vehicle as Boat;
                    boatList.Add(boat);
                }
            }   
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicleList.Remove(vehicle);
        }

        public List<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetSpecificVehicleType(Type t)
        {
            List<Vehicle> list = new List<Vehicle>();
            foreach(Vehicle item in vehicleList)
            {
                var type = item.GetType();

                if(type == t)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
