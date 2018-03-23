using BusinessEntities.Database;
using Place4meModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImpl
{
    public class CarParkMapper
    {
        public CarparkForMobile mapToMobile(int free_slots, carpark carpark)
        {
            return new CarparkForMobile(carpark.carpark_id, carpark.carpark_place, carpark.carpark_place_lat, carpark.carpark_place_long, free_slots, carpark.carpark_place_img);
        }
    }
}
