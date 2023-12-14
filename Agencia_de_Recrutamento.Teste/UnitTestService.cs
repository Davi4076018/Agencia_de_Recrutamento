using System.Text.Json;
using AutoMapper;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Repository.Context;
using Agencia_de_Recrutamento.Repository.Repository;
using Agencia_de_Recrutamento.Service.Services;
using Agencia_de_Recrutamento.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agencia_de_Recrutamento.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "Agencia_de_Recrutamento";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Recrutador>, BaseRepository<Recrutador>>();
            services.AddScoped<IBaseService<Recrutador>, BaseService<Recrutador>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Recrutador, Recrutador>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Recrutador>>();
            var Recrutador = new Recrutador
            {
                Nome = "Davi",
                Login = "davi4076018",
                Senha = "123",
                Email = "davi@mail.com",
                Ativo = true
            };
            var result = _userService?.Add<Recrutador, Recrutador, RecrutadorValidator>(Recrutador);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}