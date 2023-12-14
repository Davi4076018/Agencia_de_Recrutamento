using System.Text.Json;
using System.Text.RegularExpressions;
using Agencia_de_Recrutamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agencia_de_Recrutamento.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Candidato> Candidato { get; set; }
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Empresa> Empresa { get; set; }
            public DbSet<Recrutador> Recrutador { get; set; }
            public DbSet<Vaga> Vaga { get; set; }
            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "Agencia_de_Recrutamento";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }

        [TestMethod]
        public void TestInsertRecrutador()
        {
            using (var context = new MyDbContext())
            {

                var Recrutador = new Recrutador
                {
                    Nome = "Murilo",
                    Login = "murilin1234",
                    Senha = "123",
                    Email = "murilo@mail.com",
                    Ativo = true
                };
                context.Recrutador.Add(Recrutador);

                Recrutador = new Recrutador
                {
                    Nome = "Davi",
                    Login = "davi4076018",
                    Senha = "123",
                    Email = "davi@mail.com",
                    Ativo = true
                };
                context.Recrutador.Add(Recrutador);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarRecrutador()
        {
            using (var context = new MyDbContext())
            {
                foreach (var Recrutador in context.Recrutador)
                {
                    Console.WriteLine(JsonSerializer.Serialize(Recrutador));
                }
            }
        }
    }
}
