using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place4meModels
{
    public class CarParkFreeSlotNo
    {
        public CarParkFreeSlotNo(int carpark_id, string carpark_place, string carpark_place_lat, string carpark_place_long, string carpark_img, int[] free_slot_no)
        {
            this.carpark_id = carpark_id;
            this.carpark_place = carpark_place;
            this.carpark_place_lat = carpark_place_lat;
            this.carpark_place_long = carpark_place_long;
            this.carpark_img = carpark_img;
            this.free_slot_no = free_slot_no;
        }

        public int carpark_id { get; set; }
        public string carpark_place { get; set; }
        public string carpark_place_lat { get; set; }
        public string carpark_place_long { get; set; }
        public string carpark_img { get; set; }
        public int[] free_slot_no { get; set; }
    }
}
