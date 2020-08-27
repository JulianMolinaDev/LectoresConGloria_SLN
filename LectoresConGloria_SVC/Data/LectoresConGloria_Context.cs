using LectoresConGloria_SVC.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Data
{
    class LectoresConGloria_Context : DbContext
    {
        public DbSet<TBL_Clicks> TBL_Clicks { get; set; }
        public DbSet<TBL_Usuarios> TBL_Usuarios { get; set; }
        public DbSet<TBL_Textos> TBL_Textos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
