using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.App.Base;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using Agencia_de_Recrutamento.Repository.Mapping;

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class CadastroCandidato : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Candidato> _candidatoService;
        private readonly IBaseService<Cidade> _cidadeService;


        private List<Candidato>? candidato;

        public CadastroCandidato(IBaseService<Candidato> candidatoService, IBaseService<Cidade> cidadeService)
        {
            _candidatoService = candidatoService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cbCidadeCandidato.ValueMember = "Id";
            cbCidadeCandidato.DisplayMember = "Nome";
            cbCidadeCandidato.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Candidato candidato)
        {
            candidato.Nome = TextCandidatoNome.Text;
            candidato.Email = TextCandidatoEmail.Text;
            candidato.Bairro = TextCandidatoBairro.Text;
            candidato.Endereco = TextCandidatoEndereco.Text;
            candidato.CPF = TextCandidatoCPF.Text; if (int.TryParse(cbCidadeCandidato.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                candidato.Cidade = cidade;
            }
            candidato.Formacao = TextCandidatoFormacao.Text;
            candidato.Ativo = true;
            candidato.Id = 0;


        }



        protected virtual void Cadastrar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TextCandidatoID.Text, out var id))
                    {
                        var candidato = _candidatoService.GetById<Candidato>(id);
                        PreencheObjeto(candidato);
                        candidato = _candidatoService.Update<Candidato, Candidato, CandidatoValidator>(candidato);
                    }
                }
                else
                {
                    var candidato = new Candidato();
                    PreencheObjeto(candidato);
                    _candidatoService.Add<Candidato, Candidato, CandidatoValidator>(candidato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Agencia de Recrutamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCandidatoSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void CadastroCandidato_Load(object sender, EventArgs e)
        {

        }
    }
}
