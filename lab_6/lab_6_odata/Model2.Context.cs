﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_6_odata
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.ServiceModel.Web;

    public partial class WSGEAEntities1 : DbContext
    {
        public WSGEAEntities1()
            : base("name=WSGEAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Student> Students { get; set; }

    }
}
