using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vektorel.Web.KitapBankosuApp.Models;

namespace Vektorel.Web.KitapBankosuApp
{
    public class KitapBankosuContext:DbContext
    {
        public KitapBankosuContext():base("cstr")
        {

        }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Yazar>().ToTable("tblYazarlar");
            modelBuilder.Entity<Yazar>().Property(yz => yz.YazarAd).HasColumnName("YazarAdi").HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Yazar>().Property(yz => yz.YazarSoyad).HasColumnName("YazarSoyad").HasMaxLength(50).IsRequired().HasColumnType("varchar");

        }
    }
}