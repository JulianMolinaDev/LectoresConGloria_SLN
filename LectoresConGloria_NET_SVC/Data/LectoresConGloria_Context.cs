namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LectoresConGloria_Context : DbContext
    {
        public LectoresConGloria_Context()
            : base("name=LectoresConGloria_Context")
        {
        }

        public virtual DbSet<TBL_Categorias> TBL_Categorias { get; set; }
        public virtual DbSet<TBL_Clicks> TBL_Clicks { get; set; }
        public virtual DbSet<TBL_Formatos> TBL_Formatos { get; set; }
        public virtual DbSet<TBL_FormatosLibros> TBL_FormatosLibros { get; set; }
        public virtual DbSet<TBL_Lectores> TBL_Lectores { get; set; }
        public virtual DbSet<TBL_Libros> TBL_Libros { get; set; }
        public virtual DbSet<TBL_Textos> TBL_Textos { get; set; }
        public virtual DbSet<TBL_TextosCategorias> TBL_TextosCategorias { get; set; }
        public virtual DbSet<TBL_TextosLibros> TBL_TextosLibros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_Categorias>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Categorias>()
                .HasMany(e => e.TBL_TextosCategorias)
                .WithRequired(e => e.TBL_Categorias)
                .HasForeignKey(e => e.IdCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Formatos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Formatos>()
                .HasMany(e => e.TBL_FormatosLibros)
                .WithRequired(e => e.TBL_Formatos)
                .HasForeignKey(e => e.IdFormato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Lectores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Lectores>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Lectores>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Lectores>()
                .HasMany(e => e.TBL_Clicks)
                .WithRequired(e => e.TBL_Lectores)
                .HasForeignKey(e => e.IdLector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Libros>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Libros>()
                .HasMany(e => e.TBL_FormatosLibros)
                .WithRequired(e => e.TBL_Libros)
                .HasForeignKey(e => e.IdLibro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Libros>()
                .HasMany(e => e.TBL_TextosLibros)
                .WithRequired(e => e.TBL_Libros)
                .HasForeignKey(e => e.IdLibro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Textos>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Textos>()
                .Property(e => e.Explicacion)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Textos>()
                .Property(e => e.Audio)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Textos>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Textos>()
                .HasMany(e => e.TBL_Clicks)
                .WithRequired(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Textos>()
                .HasMany(e => e.TBL_TextosCategorias)
                .WithRequired(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_Textos>()
                .HasMany(e => e.TBL_TextosLibros)
                .WithRequired(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .WillCascadeOnDelete(false);

           
        }
    }
}
