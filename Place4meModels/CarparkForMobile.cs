using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place4meModels
{
    public class CarparkForMobile
    {
        public CarparkForMobile(int carpark_id, string carpark_place, string carpark_place_lat, string carpark_place_long, int carpark_free_slots, string carpark_img)
        {
            this.carpark_id = carpark_id;
            this.carpark_place = carpark_place;
            this.carpark_place_lat = carpark_place_lat;
            this.carpark_place_long = carpark_place_long;
            this.carpark_free_slots = carpark_free_slots;
            this.carpark_img = carpark_img;
        }

        public int carpark_id { get; set; }
        public string carpark_place { get; set; }
        public string carpark_place_lat { get; set; }
        public string carpark_place_long { get; set; }
        public int carpark_free_slots { get; set; }
        public string carpark_img { get; set; }
    }
}
