using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


namespace Agencia_de_Recrutamento.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Candidato>? Candidato { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Empresa>? Empresa { get; set; }
        public DbSet<Recrutador>? Recrutador { get; set; }
        public DbSet<Vaga>? Vaga { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Candidato>(new CandidatoMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Empresa>(new EmpresaMap().Configure);
            modelBuilder.Entity<Recrutador>(new RecrutadorMap().Configure);
            modelBuilder.Entity<Vaga>(new VagaMap().Configure);
        }
    }
}
