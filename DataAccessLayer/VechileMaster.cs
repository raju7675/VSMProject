//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class VechileMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VechileMaster()
        {
            this.ServiceRecordInfoes = new HashSet<ServiceRecordInfo>();
        }
    
        public int ModalNo { get; set; }
        public string ModalName { get; set; }
        public Nullable<int> ModalYear { get; set; }
        public string VehicleType { get; set; }
        public Nullable<System.DateTime> SoldDate { get; set; }
        public Nullable<int> ServiceSchedule { get; set; }
        public Nullable<int> CustId { get; set; }
    
        public virtual CustomerMaster CustomerMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRecordInfo> ServiceRecordInfoes { get; set; }
    }
}
