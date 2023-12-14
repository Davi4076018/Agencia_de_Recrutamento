using AutoMapper;
using Agencia_de_Recrutamento.App.Cadastros;
using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.App.Outros;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Repository.Context;
using Agencia_de_Recrutamento.Repository.Repository;
using Agencia_de_Recrutamento.Service.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Agencia_de_Recrutamento.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Candidato>, BaseRepository<Candidato>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Empresa>, BaseRepository<Empresa>>();
            Services.AddScoped<IBaseRepository<Vaga>, BaseRepository<Vaga>>();
            Services.AddScoped<IBaseRepository<Recrutador>, BaseRepository<Recrutador>>();

            // Services
            Services.AddScoped<IBaseService<Candidato>, BaseService<Candidato>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Empresa>, BaseService<Empresa>>();
            Services.AddScoped<IBaseService<Vaga>, BaseService<Vaga>>();
            Services.AddScoped<IBaseService<Recrutador>, BaseService<Recrutador>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroRecrutador, CadastroRecrutador>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCandidato, CadastroCandidato>();
            Services.AddTransient<CadastroEmpresa, CadastroEmpresa>();
            Services.AddTransient<CadastroVaga, CadastroVaga>();
            Services.AddTransient<VagasAtivas, VagasAtivas>();
            Services.AddTransient<CardVaga, CardVaga>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Candidato, CandidatoModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Empresa, EmpresaModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Recrutador, RecrutadorModel>();
                config.CreateMap<Vaga, VagaModel>()
                    .ForMember(d => d.IdEmpresa, d => d.MapFrom(x => x.Empresa!.Id))
                    .ForMember(d => d.IdRecrutador, d => d.MapFrom(x => x.Recrutador!.Nome));


            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
