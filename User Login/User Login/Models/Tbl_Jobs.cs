//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace User_Login.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Jobs
    {
        public Tbl_Jobs()
        {
            this.Tbl_Job_Application = new HashSet<Tbl_Job_Application>();
        }
    
        public int Job_Id { get; set; }
        public string Position { get; set; }
        public string Customer { get; set; }
        public Nullable<System.DateTime> Submit_Before { get; set; }
        public string Country_Name { get; set; }
        public string State_Name { get; set; }
        public string City_Name { get; set; }
        public string Profile_Description { get; set; }
        public string Required_Skills { get; set; }
        public string Description { get; set; }
        public string Pay_Rate { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Min_Exp_Required { get; set; }
        public string Max_Exp_Required { get; set; }
    
        public virtual ICollection<Tbl_Job_Application> Tbl_Job_Application { get; set; }
    }
}
