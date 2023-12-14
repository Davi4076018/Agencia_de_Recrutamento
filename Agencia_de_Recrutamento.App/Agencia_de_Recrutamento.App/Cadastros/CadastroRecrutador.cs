using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.App.Base;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class CadastroRecrutador : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Recrutador> _recrutadorService;

        private List<Recrutador>? recrutador;

        public CadastroRecrutador(IBaseService<Recrutador> recrutadorService)
        {
            _recrutadorService = recrutadorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Recrutador recrutador)
        {
            recrutador.Nome = nomeTextbox.Text;
            recrutador.Email = emailTextbox.Text;
            recrutador.Login = loginTextbox.Text;
            recrutador.Senha = senhaTextbox.Text;
            recrutador.Ativo = true;
        }

        protected virtual void Cadastrar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(idTextbox.Text, out var id))
                    {
                        var recrutador = _recrutadorService.GetById<Recrutador>(id);
                        PreencheObjeto(recrutador);
                        recrutador = _recrutadorService.Update<Recrutador, Recrutador, RecrutadorValidator>(recrutador);
                    }
                }
                else
                {
                    var recrutador = new Recrutador();
                    PreencheObjeto(recrutador);
                    _recrutadorService.Add<Recrutador, Recrutador, RecrutadorValidator>(recrutador);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Agencia de Recrutamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
