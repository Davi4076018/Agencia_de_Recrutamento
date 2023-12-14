using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.App.Base;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class CadastroCidade : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Cidade> _cidadeService;

        private List<Cidade>? cidade;

        public CadastroCidade(IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            InitializeComponent();
        }

        private void PreencheObjeto(Cidade cidade)
        {
            cidade.Nome = TextCidadeCidade.Text;
            cidade.Estado = TextEstadoCidade.Text;
            cidade.Id = 0;
        }


        protected virtual void Cadastrar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TextIDCidade.Text, out var id))
                    {
                        var cidade = _cidadeService.GetById<Cidade>(id);
                        PreencheObjeto(cidade);
                        cidade = _cidadeService.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    }
                }
                else
                {
                    var cidade = new Cidade();
                    PreencheObjeto(cidade);
                    _cidadeService.Add<Cidade, Cidade, CidadeValidator>(cidade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Agencia de Recrutamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCidadeSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
