using BusinessEntities.Database;
using ControllerManagersImpl;
using IControllerManagers;
using Place4meModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Place4meWebAPI.Controllers
{
    public class MobileCarParksController : ApiController
    {
        private ICarParkControllerManager _carParkControllerManager;

        public MobileCarParksController()
        {
            _carParkControllerManager = new CarParkControllerManagerImpl();
        }

        // GET: api/MobileCarParks
        public IEnumerable<CarparkForMobile> Getcarparks()
        {
            return _carParkControllerManager.GetCarParksForMobile();
        }

        // GET: api/MobileCarParks/5
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


        // GET: api/MobileCarParks/5
        //[ResponseType(typeof(CarParkFreeSlotNo))]
        //public IHttpActionResult Getcarpark(string place)
        //{
        //    CarParkFreeSlotNo carParkFreeSlotNo = _carParkControllerManager.GetCarParksFreeSlotNo(place);
        //    if (carParkFreeSlotNo == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(carParkFreeSlotNo);
        //}
    }
}
