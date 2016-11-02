using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FarmaciaMagaña.DAL
{
    public class BaseDeDatos : DbContext
    {
        public BaseDeDatos() : base("ServidorSQL")
        {
            Database.SetInitializer<BaseDeDatos>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<FarmaciaMagaña.Models.ProductosModel> allProductos { get; set; }

        
    }
}