﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newAgency.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sno7yEntities : DbContext
    {
        public Sno7yEntities()
            : base("name=Sno7yEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<car> cars { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<package> packages { get; set; }
        public virtual DbSet<reservation_car> reservation_car { get; set; }
        public virtual DbSet<setting_agency> setting_agency { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<type_client> type_client { get; set; }
    }
}
