using Agencia_de_Recrutamento.App.Cadastros;
using Agencia_de_Recrutamento.App.Infra;
using System.Diagnostics;

namespace Agencia_de_Recrutamento.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfiguraServices();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}