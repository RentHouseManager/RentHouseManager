﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentHouseManager.Project.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentHouseManagerEntities : DbContext
    {
        public RentHouseManagerEntities()
            : base("name=RentHouseManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BAOCAONGQUANLY> BAOCAONGQUANLies { get; set; }
        public virtual DbSet<BAOCAONGTHUE> BAOCAONGTHUEs { get; set; }
        public virtual DbSet<CHUTRO> CHUTROes { get; set; }
        public virtual DbSet<DAYTRO> DAYTROes { get; set; }
        public virtual DbSet<IDRLSS> IDRLSSes { get; set; }
        public virtual DbSet<NGQUANLY> NGQUANLies { get; set; }
        public virtual DbSet<NGTHUE> NGTHUEs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<QHPHG> QHPHGs { get; set; }
        public virtual DbSet<TIEN> TIENs { get; set; }
    }
}
