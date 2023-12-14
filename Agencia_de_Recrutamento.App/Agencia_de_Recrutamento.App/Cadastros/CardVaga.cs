using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.App.Base;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using Agencia_de_Recrutamento.Repository.Mapping;
using System;
using System.Collections.Generic;
using Agencia_de_Recrutamento.App.Infra;
using Agencia_de_Recrutamento.App.Outros;
using System.Diagnostics;

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class CardVaga : MaterialForm
    {
        protected bool IsAlteracao = false;



        private readonly IBaseService<Vaga> _vagaService;
        private readonly IBaseService<Candidato> _candidatoService;
        private readonly IBaseService<Empresa> _empresaService;
        private readonly IBaseService<Recrutador> _recrutadorService;

        private List<Vaga>? vaga;

        public static Vaga Vaga { get; set; }

        public CardVaga(IBaseService<Vaga> vagaService, IBaseService<Candidato> candidatoService, IBaseService<Empresa> empresaService, IBaseService<Recrutador> recrutadorService)
        {
            _vagaService = vagaService;
            _candidatoService = candidatoService;
            _empresaService = empresaService;
            _recrutadorService = recrutadorService;
            InitializeComponent();
            CarregaVaga();
        }

        private void CarregaVaga()
        {
            
            Debug.WriteLine("vaga.empresa: ");
            Debug.WriteLine(Vaga.ToString);
            Debug.WriteLine("vaga2.empresa: ");
            Debug.WriteLine(Vaga.Titulo);
            Debug.WriteLine("vaga.Inscritos: ");
            Debug.WriteLine(Vaga.Inscritos);
            LabelTitulo.Text = $"{Vaga.Titulo}";
            labelDescricao.Text = $"{Vaga.Descricao}";
            labelCriacao.Text = $"{Vaga.DataCriacao}";
            labelSalario.Text = "R$ " + $"{Vaga.Salario}";
            labelEmpresa.Text = $"{Vaga.Empresa}";
            labelCandidato.Text = $"{Vaga.Inscritos.Count}";
            labelRecrutador.Text = $"{Vaga.Recrutador}";
        }

        private void LabelDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
