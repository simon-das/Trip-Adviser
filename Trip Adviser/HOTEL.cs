//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trip_Adviser
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOTEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOTEL()
        {
            this.HOTEL_OFFER = new HashSet<HOTEL_OFFER>();
            this.PICTUREs = new HashSet<PICTURE>();
            this.REVIEW_RATING = new HashSet<REVIEW_RATING>();
            this.PLACEs = new HashSet<PLACE>();
        }
    
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelDesc { get; set; }
        public string HotelLocation { get; set; }
        public Nullable<int> IdealPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOTEL_OFFER> HOTEL_OFFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PICTURE> PICTUREs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW_RATING> REVIEW_RATING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLACE> PLACEs { get; set; }
    }
}