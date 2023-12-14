using Agencia_de_Recrutamento.App.Infra;
using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.Domain.Base;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.App.Outros;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using Agencia_de_Recrutamento.App.Cadastros;



namespace Agencia_de_Recrutamento.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Recrutador> _recrutadorService;

        public Login(IBaseService<Recrutador> recrutadorService)
        {
            _recrutadorService = recrutadorService;
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Exibeformulario<CadastroRecrutador>();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            var recrutador = ObterRecrutador(LoginText.Text, senhaText.Text);

            if (recrutador == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginText.Focus();
            }
            else if (!recrutador.Ativo)
            {
                MessageBox.Show("Usuário inativo!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginText.Focus();
            }
            else
            {
                recrutador = _recrutadorService.Update<Recrutador, Recrutador, RecrutadorValidator>(recrutador);
                FormPrincipal.Recrutador = recrutador;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Recrutador? ObterRecrutador(string login, string senha)
        {
            ChecaExistenciaDeRecrutadoresCadastrados();

            var recrutador = _recrutadorService.Get<Recrutador>().Where(x => x.Login == login).FirstOrDefault();
            if (recrutador == null)
            {
                return null;
            }
            return recrutador.Senha != senha ? null : recrutador;
        }

        private void ChecaExistenciaDeRecrutadoresCadastrados()
        {
            var recrutadores = _recrutadorService.Get<RecrutadorModel>().ToList();
            if (!recrutadores.Any())
            {
                var recrutador = new Recrutador
                {
                    Ativo = true,
                    Nome = "Administrador",
                    Login = "admin",
                    Senha = "admin",
                    Email = "admin@mail.com"
                };
                _recrutadorService.Add<Recrutador, Recrutador, RecrutadorValidator>(recrutador);
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            cad.Show();
        }
    }
}
