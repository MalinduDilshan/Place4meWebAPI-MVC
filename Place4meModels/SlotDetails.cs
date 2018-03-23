using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place4meModels
{
    public class SlotDetails
    {
        public int slot_details_id { get; set; }
        [Display(Name = "Parked Started Time")]
        [DataType(DataType.Time)]
        public string slot_details_parked_time { get; set; }
        [Display(Name = "Parked End Time")]
        [DataType(DataType.Time)]
        public string slot_details_parked_end_time { get; set; }
        [Display(Name = "Parked Date")]
        [DataType(DataType.Date)]
        public System.DateTime slot_details_parked_date { get; set; }
        [Display(Name = "Parked Vehicle No")]
        public string slot_details_parked_vehicle_no { get; set; }
        public int slot_details_status { get; set; }

        public int slot_id { get; set; }

        public virtual Slot slot { get; set; }
    }
}
