﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoBus.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TodoBusEntities : DbContext
    {
        public TodoBusEntities()
            : base("name=TodoBusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brands> brands { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<spare> spare { get; set; }
        public virtual DbSet<spare_categories> spare_categories { get; set; }
        public virtual DbSet<spare_subcategories> spare_subcategories { get; set; }
        public virtual DbSet<spare_subclasses> spare_subclasses { get; set; }
        public virtual DbSet<units> units { get; set; }
        public virtual DbSet<units_spare> units_spare { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}