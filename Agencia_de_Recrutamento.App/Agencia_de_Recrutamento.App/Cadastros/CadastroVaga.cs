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

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class CadastroVaga : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Vaga> _vagaService;
        private readonly IBaseService<Candidato> _candidatoService;
        private readonly IBaseService<Empresa> _empresaService;
        private readonly IBaseService<Recrutador> _recrutadorService;

        private List<Vaga>? vaga;

        public CadastroVaga(IBaseService<Vaga> vagaService, IBaseService<Candidato> candidatoService, IBaseService<Empresa> empresaService, IBaseService<Recrutador> recrutadorService)
        {
            _vagaService = vagaService;
            _candidatoService = candidatoService;
            _empresaService = empresaService;
            _recrutadorService = recrutadorService;
            InitializeComponent();
            CarregarCombo();

        }

        private void CarregarCombo()
        {
            cbCandidatoVaga.ValueMember = "Id";
            cbCandidatoVaga.DisplayMember = "Nome";
            cbCandidatoVaga.DataSource = _candidatoService.Get<CandidatoModel>().ToList();

            cbEmpresaVaga.ValueMember = "Id";
            cbEmpresaVaga.DisplayMember = "Nome";
            cbEmpresaVaga.DataSource = _empresaService.Get<EmpresaModel>().ToList();

            cbRecrutadorVaga.ValueMember = "Id";
            cbRecrutadorVaga.DisplayMember = "Nome";
            cbRecrutadorVaga.DataSource = _recrutadorService.Get<RecrutadorModel>().ToList();

        }

        private void PreencheObjeto(Vaga vaga)
        {
            vaga.Titulo = TextVagaTitulo.Text;
            vaga.Descricao = TextVagaDescricao.Text;
            vaga.Formacao = TextVagaFormacao.Text;
            if (float.TryParse(TextVagaSalario.Text, out var preco))
            {
                vaga.Salario = preco;
            }
            vaga.DataCriacao = DateTime.Now;
            vaga.Ativo = true;
            vaga.Id = 0;


            if (int.TryParse(cbRecrutadorVaga.SelectedValue.ToString(), out var idGrupo3))
            {
                var recrutador = _recrutadorService.GetById<Recrutador>(idGrupo3);
                vaga.Recrutador = (recrutador);
            }

            if (int.TryParse(cbCandidatoVaga.SelectedValue.ToString(), out var idGrupo))
            {
                var candidato = _candidatoService.GetById<Candidato>(idGrupo);
                vaga.Inscritos.Add(candidato);
            }

            if (int.TryParse(cbEmpresaVaga.SelectedValue.ToString(), out var idGrupo2))
            {
                var empresa = _empresaService.GetById<Empresa>(idGrupo2);
                vaga.Empresa = empresa;
            }

        }



        protected virtual void Cadastrar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TextVagaID.Text, out var id))
                    {
                        var vaga = _vagaService.GetById<Vaga>(id);
                        PreencheObjeto(vaga);
                        vaga = _vagaService.Update<Vaga, Vaga, VagaValidator>(vaga);
                    }
                }
                else
                {
                    var vaga = new Vaga();
                    PreencheObjeto(vaga);
                    _vagaService.Add<Vaga, Vaga, VagaValidator>(vaga);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Agencia de Recrutamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonVagaSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void CadastroVaga_Load(object sender, EventArgs e)
        {

        }
    }
}
