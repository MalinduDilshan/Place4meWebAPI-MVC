//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Place4meModels;

    [MetadataType(typeof(Slot))]
    public partial class slot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public slot()
        {
            this.slot_details = new HashSet<slot_details>();
        }
    
        public int slot_id { get; set; }
        public int slot_isFree { get; set; }
        public int slot_status { get; set; }
        public int carpark_id { get; set; }
    
        public virtual carpark carpark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<slot_details> slot_details { get; set; }
    }
}