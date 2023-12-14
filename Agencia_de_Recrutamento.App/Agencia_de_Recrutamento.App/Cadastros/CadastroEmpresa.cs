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
    public partial class CadastroEmpresa : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Empresa> _empresaService;
        private readonly IBaseService<Cidade> _cidadeService;


        private List<Empresa>? empresa;

        public CadastroEmpresa(IBaseService<Empresa> empresaService, IBaseService<Cidade> cidadeService)
        {
            _empresaService = empresaService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cbCidadeEmpresa.ValueMember = "Id";
            cbCidadeEmpresa.DisplayMember = "Nome";
            cbCidadeEmpresa.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Empresa empresa)
        {
            empresa.Nome = TextEmpresaNome.Text;
            empresa.Bairro = TextEmpresaBairro.Text;
            empresa.Endereco = TextEmpresaEndereco.Text;
            empresa.CNPJ = TextEmpresaCNPJ.Text;
            empresa.Id = 0;

            if (int.TryParse(cbCidadeEmpresa.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                empresa.Cidade = cidade;
            }
        }



        protected virtual void Cadastrar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(TextEmpresaID.Text, out var id))
                    {
                        var empresa = _empresaService.GetById<Empresa>(id);
                        PreencheObjeto(empresa);
                        empresa = _empresaService.Update<Empresa, Empresa, EmpresaValidator>(empresa);
                    }
                }
                else
                {
                    var empresa = new Empresa();
                    PreencheObjeto(empresa);
                    _empresaService.Add<Empresa, Empresa, EmpresaValidator>(empresa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Agencia de Recrutamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEmpresaSalvar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
