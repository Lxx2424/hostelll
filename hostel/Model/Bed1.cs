//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hostel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bed1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bed1()
        {
            this.Guests = new HashSet<Guest>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int ID { get; set; }
        public int Bed_Number { get; set; }
        public Nullable<int> Type_ID { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> Available { get; set; }
        public Nullable<int> RoomId { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
