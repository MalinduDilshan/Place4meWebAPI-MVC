using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Place4meModels
{
    public class Carpark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carpark()
        {
            this.slots = new HashSet<Slot>();
        }

        public int carpark_id { get; set; }
        [Display(Name ="Car park place")]
        [Required(ErrorMessage ="Car park place is Required")]
        public string carpark_place { get; set; }
        [Display(Name = "Car park latitude")]
        [Required(ErrorMessage = "Car park location latitude is Required")]
        public string carpark_place_lat { get; set; }
        [Display(Name = "Car park longitude")]
        [Required(ErrorMessage = "Car park location longitude is Required")]
        public string carpark_place_long { get; set; }
        public string carpark_place_img { get; set; }
        public int carpark_status { get; set; }

        [ScriptIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slot> slots { get; set; }
    }
}
