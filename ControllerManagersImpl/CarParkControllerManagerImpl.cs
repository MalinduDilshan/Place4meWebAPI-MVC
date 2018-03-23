using System;
using System.Collections.Generic;
using BusinessEntities.Database;
using IControllerManagers;
using IServices;
using ServicesImpl;
using Place4meModels;

namespace ControllerManagersImpl
{
    public class CarParkControllerManagerImpl : ICarParkControllerManager
    {
        private AbstractCarParkService _carParkService;

        public CarParkControllerManagerImpl()
        {
            _carParkService = new CarParkServiceImpl();
        }

        public void AddCarPark(carpark entity)  //implementation of AddCarPark(carpark entity) in ICarParkControllerManager
        {
            try
            {
                _carParkService.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddMultipleCarParks(IEnumerable<carpark> entities)  //implementation of AddMultipleCarParks(IEnumerable<carpark> entities) in ICarParkControllerManager
        {
            throw new NotImplementedException();
        }

        public void UpdateCarPark(int id, carpark entity)   //implementation of UpdateCarPark(int id, carpark entity) in ICarParkControllerManager
        {
            try
            {
                _carParkService.Update(id, entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public carpark GetCarPark(int id)   //implementation of GetCarPark(int id) in ICarParkControllerManager
        {
            try
            {
                return _carParkService.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<carpark> GetAllCarParks()    //implementation of GetAllCarParks() in ICarParkControllerManager
        {
            try
            {
                return _carParkService.GetAll();    
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveCarPark(carpark entity)   //implementation of RemoveCarPark(carpark entity) in ICarParkControllerManager
        {
            try
            {
                _carParkService.Remove(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveMultipleCarParks(IEnumerable<carpark> entities)   //implementation of RemoveMultipleCarParks(IEnumerable<carpark> entities) in ICarParkControllerManager
        {
            throw new NotImplementedException();
        }

        public bool CarParkExists(int id)   //implementation of CarParkExists(int id) in ICarParkControllerManager
        {
            try
            {
                return _carParkService.EntityExists(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<carpark> GetFreeCarParks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarparkForMobile> GetCarParksForMobile()
        {
            try
            {
                return _carParkService.GetCarParksForMobile();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
