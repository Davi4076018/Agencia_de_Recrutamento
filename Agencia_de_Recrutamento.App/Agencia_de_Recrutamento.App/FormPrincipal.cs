using Agencia_de_Recrutamento.App.Infra;
using Agencia_de_Recrutamento.App.Outros;
using Agencia_de_Recrutamento.Domain.Entities;
using Agencia_de_Recrutamento.Service.Validators;
using Agencia_de_Recrutamento.Domain.Base;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using Agencia_de_Recrutamento.App.Models;
using Agencia_de_Recrutamento.App.Cadastros;
using System.Security.Policy;
using ReaLTaiizor.Controls;
using System.Diagnostics;


namespace Agencia_de_Recrutamento.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Recrutador Recrutador { get; set; }

        private readonly IBaseService<Cidade> _cidadeService;

        protected bool IsAlteracao = false;

        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    recrutadorLabel.Text = $"{Recrutador.Nome}";
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalvarCandidato_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCidadeSalvar_Click(object sender, EventArgs e)
        {

        }

        private void VagasTab_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("tab selecionado: ");
            Debug.WriteLine(VagasTab.SelectedIndex.ToString());
            if (VagasTab.SelectedIndex.ToString() == "1")
            {
                Exibeformulario<VagasAtivas>();
            }
            if (VagasTab.SelectedIndex.ToString() == "2")
            {
                Exibeformulario<CadastroVaga>();
            }
            else if (VagasTab.SelectedIndex.ToString() == "3")
            {
                Exibeformulario<CadastroEmpresa>();
            }
            else if (VagasTab.SelectedIndex.ToString() == "4")
            {
                Exibeformulario<CadastroCandidato>();
            }
            else if (VagasTab.SelectedIndex.ToString() == "5")
            {
                Exibeformulario<CadastroCidade>();
            }

        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            cad.Show();
        }
    }
}