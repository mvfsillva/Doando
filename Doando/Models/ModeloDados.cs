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

        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Necessidade> Necessidade { get; set; }
        public virtual DbSet<Ong> Ong { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>()
                .Property(e => e.RUA)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.TELEFONE_PRIMARIO)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.TELEFONE_SECUNDARIO)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Necessidade>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<Necessidade>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<Necessidade>()
                .Property(e => e.PRIORIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Necessidade>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Ong>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Ong>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<Ong>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<Ong>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Ong>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);
        }
    }
}
