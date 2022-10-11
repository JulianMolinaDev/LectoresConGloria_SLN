namespace LectoresConGloria_SVC.Data
{
    using Microsoft.EntityFrameworkCore;

    public partial class LectoresConGloria_Context : DbContext
    {
        public LectoresConGloria_Context(DbContextOptions<LectoresConGloria_Context> options)
            : base(options)
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "Server=.;Database=CentroUniversitario_BD;Trusted_Connection = True; MultipleActiveResultSets = true";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(conn);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_Categorias>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Categorias>()
                .HasMany(e => e.TBL_TextosCategorias)
                .WithOne(e => e.TBL_Categorias)
                .HasForeignKey(e => e.IdCategoria)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TBL_Formatos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Formatos>()
                .HasMany(e => e.TBL_FormatosLibros)
                .WithOne(e => e.TBL_Formatos)
                .HasForeignKey(e => e.IdFormato)
                .OnDelete(DeleteBehavior.NoAction);

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
                .WithOne(e => e.TBL_Lectores)
                .HasForeignKey(e => e.IdLector)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TBL_Libros>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_Libros>()
                .HasMany(e => e.TBL_FormatosLibros)
                .WithOne(e => e.TBL_Libros)
                .HasForeignKey(e => e.IdLibro)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TBL_Libros>()
                .HasMany(e => e.TBL_TextosLibros)
                .WithOne(e => e.TBL_Libros)
                .HasForeignKey(e => e.IdLibro)
                .OnDelete(DeleteBehavior.NoAction);

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
                .WithOne(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TBL_Textos>()
                .HasMany(e => e.TBL_TextosCategorias)
                .WithOne(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TBL_Textos>()
                .HasMany(e => e.TBL_TextosLibros)
                .WithOne(e => e.TBL_Textos)
                .HasForeignKey(e => e.IdTexto)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
