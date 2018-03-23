using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Database;
using IServices;
using Place4meModels;

namespace ServicesImpl
{
    public class CarParkServiceImpl : AbstractCarParkService
    {
        private Place4meEntities db;
        private CarParkMapper carParkMapper;

        public CarParkServiceImpl()
        {
            db = new Place4meEntities();
        }

        public override IEnumerable<CarparkForMobile> GetCarParksForMobile()    //implementation of GetCarParksForMobile() in AbstractCarParkService
        {
            List<carpark> caroarkDBList = new List<carpark>();
            List<CarparkForMobile> carparkMobileList = new List<CarparkForMobile>();
            carParkMapper = new CarParkMapper();

            caroarkDBList = db.carparks.Where(c => c.carpark_status == 1).ToList();

            if (caroarkDBList.Count() != 0)
            {
                foreach (var item in caroarkDBList)
                {
                    int freeSlots = db.slots.Count(s => s.carpark_id == item.carpark_id && s.slot_isFree == 0);
                    carparkMobileList.Add(carParkMapper.mapToMobile(freeSlots, item));
                }
            }
            return carparkMobileList;   //this will return new carpark list for Mobile version
        }

        public override IEnumerable<carpark> GetFreeCarParks()
        {
            throw new NotImplementedException();
        }
    }
}
