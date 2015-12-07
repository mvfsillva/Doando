namespace Doando.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<CAD_NECESSIDADE> CAD_NECESSIDADE { get; set; }
        public virtual DbSet<CAD_ONG> CAD_ONG { get; set; }
        public virtual DbSet<ENDERECO> ENDERECO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAD_NECESSIDADE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_NECESSIDADE>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_NECESSIDADE>()
                .Property(e => e.PRIORIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_NECESSIDADE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_ONG>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_ONG>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_ONG>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<CAD_ONG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.RUA)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.TELEFONE_PRIMARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.TELEFONE_SECUNDARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO>()
                .HasMany(e => e.CAD_ONG)
                .WithRequired(e => e.ENDERECO)
                .WillCascadeOnDelete(false);
        }
    }
}
