﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ROP_WEB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ROP_WEBEntities : DbContext
    {
        public ROP_WEBEntities()
            : base("name=ROP_WEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<FAQCategory> FAQCategories { get; set; }
        public DbSet<FAQMain> FAQMains { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
        public DbSet<NewsMain> NewsMains { get; set; }
        public DbSet<SERVICE> SERVICEs { get; set; }
        public DbSet<SERVICE_CAT> SERVICE_CAT { get; set; }
        public DbSet<SERVICE_PROVIDER> SERVICE_PROVIDER { get; set; }
        public DbSet<SERVICE_STATUS> SERVICE_STATUS { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}