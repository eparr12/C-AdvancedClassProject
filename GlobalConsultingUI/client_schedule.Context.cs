﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalConsultingUI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class client_schedule : DbContext
    {
        public client_schedule()
            : base("name=client_schedule")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
