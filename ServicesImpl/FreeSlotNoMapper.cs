using BusinessEntities.Database;
using Place4meModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImpl
{
    public class FreeSlotNoMapper
    {
        public CarParkFreeSlotNo mapToMobile(carpark carpark, int[] free_slot_no)
        {
            return new CarParkFreeSlotNo(carpark.carpark_id, carpark.carpark_place, carpark.carpark_place_lat, carpark.carpark_place_long, carpark.carpark_place_img, free_slot_no);
        }
    }
}
