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

    [MetadataType(typeof(Carpark))]
    public partial class carpark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carpark()
        {
            this.slots = new HashSet<slot>();
        }
    
        public int carpark_id { get; set; }
        public string carpark_place { get; set; }
        public string carpark_place_lat { get; set; }
        public string carpark_place_long { get; set; }
        public string carpark_place_img { get; set; }
        public int carpark_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<slot> slots { get; set; }
    }
}
