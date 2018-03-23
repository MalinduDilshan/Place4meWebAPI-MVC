using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using BusinessEntities.Database;
using ControllerManagersImpl;
using IControllerManagers;
using Place4meModels;

namespace Place4meWebAPI.Controllers
{
    public class CarParksController : ApiController
    {
        private ICarParkControllerManager _carParkControllerManager;

        public CarParksController()
        {
            _carParkControllerManager = new CarParkControllerManagerImpl();
        }

        // GET: api/CarParks
        public IEnumerable<carpark> Getcarparks()
        {
            return _carParkControllerManager.GetAllCarParks(); 
        }

        // GET: api/CarParks/5
        [ResponseType(typeof(carpark))]
        public IHttpActionResult Getcarpark(int id)
        {
            carpark carpark = _carParkControllerManager.GetCarPark(id);
            if (carpark == null)
            {
                return NotFound();
            }

            return Ok(carpark);
        }

        // PUT: api/CarParks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcarpark(int id, carpark carpark)
        {
            if (id != carpark.carpark_id)
            {
                return BadRequest();
            }

            try
            {
                _carParkControllerManager.UpdateCarPark(id, carpark);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_carParkControllerManager.CarParkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CarParks
        [ResponseType(typeof(carpark))]
        public IHttpActionResult Postcarpark(carpark carpark)
        {
            _carParkControllerManager.AddCarPark(carpark);

            return CreatedAtRoute("DefaultApi", new { id = carpark.carpark_id }, carpark);
        }

        // DELETE: api/CarParks/5
        [ResponseType(typeof(carpark))]
        public IHttpActionResult Deletecarpark(int id)
        {
            carpark carpark = _carParkControllerManager.GetCarPark(id);
            if (carpark == null)
            {
                return NotFound();
            }
            _carParkControllerManager.RemoveCarPark(carpark);

            return Ok(carpark);
        }
    }
}