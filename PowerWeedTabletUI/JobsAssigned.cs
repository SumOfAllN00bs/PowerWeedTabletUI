//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PWBackend
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobsAssigned
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobsAssigned()
        {
            this.EmployeeJobs = new HashSet<EmployeeJob>();
        }
    
        public int assignID { get; set; }
        public string assignJOBNUM { get; set; }
        public string assignCLIENT { get; set; }
        public string assignWORK { get; set; }
        public string assignAREA { get; set; }
        public Nullable<System.DateTime> assignTIME { get; set; }
        public string assignINSTRUCTIONS { get; set; }
        public string assignTRUCK { get; set; }
        public Nullable<System.DateTime> txtSENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeJob> EmployeeJobs { get; set; }
    }
}
