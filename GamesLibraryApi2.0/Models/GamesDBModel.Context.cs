﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamesLibraryApi2._0.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GamesDBEntities : DbContext
    {
        public GamesDBEntities()
            : base("name=GamesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<GameDeveloper> GameDevelopers { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
    }
}