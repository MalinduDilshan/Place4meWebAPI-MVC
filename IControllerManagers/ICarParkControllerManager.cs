using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Database;
using Place4meModels;

namespace IControllerManagers
{
    public interface ICarParkControllerManager
    {
        carpark GetCarPark(int id);
        IEnumerable<carpark> GetAllCarParks();

        void AddCarPark(carpark entity);
        void AddMultipleCarParks(IEnumerable<carpark> entities);

        void UpdateCarPark(int id, carpark entity);

        void RemoveCarPark(carpark entity);
        void RemoveMultipleCarParks(IEnumerable<carpark> entities);

        bool CarParkExists(int id);

        IEnumerable<carpark> GetFreeCarParks();

        IEnumerable<CarparkForMobile> GetCarParksForMobile();
    }
}
