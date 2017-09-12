namespace PWBackend
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeJob
    {
        public int employeeJobsID { get; set; }
        public Nullable<int> assignID { get; set; }
        public Nullable<int> empID { get; set; }
    
        public virtual JobsAssigned JobsAssigned { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
