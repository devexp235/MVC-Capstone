﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Job_Candidate_Application_Entities : DbContext
    {
        public Job_Candidate_Application_Entities()
            : base("name=Job_Candidate_Application_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Customer> Tbl_Customer { get; set; }
        public virtual DbSet<Tbl_Job_Application> Tbl_Job_Application { get; set; }
        public virtual DbSet<Tbl_Jobs> Tbl_Jobs { get; set; }
        public virtual DbSet<Tbl_Users> Tbl_Users { get; set; }
    }
}
