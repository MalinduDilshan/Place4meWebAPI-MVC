using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place4meModels
{
    public class Slot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Slot()
        {
            this.slot_details = new HashSet<SlotDetails>();
        }

        public int slot_id { get; set; }
        [Display(Name ="Slot status")]
        public int slot_isFree { get; set; }
        public int slot_status { get; set; }

        public int carpark_id { get; set; }

        public virtual Carpark carpark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SlotDetails> slot_details { get; set; }
    }
}
