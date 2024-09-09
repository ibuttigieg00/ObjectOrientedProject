using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarShowroom
{
    public interface IShowroom
    {
        void AddVehicle(Vehicle vehicle);
        void RemoveVehicle(Vehicle vehicle);
        List<Vehicle> GetAllVehicles();
        List<Vehicle> GetSpecificVehicleType(Type t);
    }
}
