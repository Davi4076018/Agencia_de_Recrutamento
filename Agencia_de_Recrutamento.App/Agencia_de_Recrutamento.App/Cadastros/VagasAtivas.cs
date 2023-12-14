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
using System.Diagnostics;
using Agencia_de_Recrutamento.App.Infra;
using Agencia_de_Recrutamento.App.Outros;
using Microsoft.Extensions.DependencyInjection;
using Agencia_de_Recrutamento.App.Cadastros;
using System.Security.Policy;

namespace Agencia_de_Recrutamento.App.Cadastros
{
    public partial class VagasAtivas : MaterialForm
    {
        protected bool IsAlteracao = false;

        private readonly IBaseService<Vaga> _vagaService;
        private readonly IBaseService<Candidato> _candidatoService;
        private readonly IBaseService<Empresa> _empresaService;
        private readonly IBaseService<Recrutador> _recrutadorService;

        private List<Vaga>? vaga;

        public VagasAtivas(IBaseService<Vaga> vagaService, IBaseService<Candidato> candidatoService, IBaseService<Empresa> empresaService, IBaseService<Recrutador> recrutadorService)
        {
            _vagaService = vagaService;
            _candidatoService = candidatoService;
            _empresaService = empresaService;
            _recrutadorService = recrutadorService;
            InitializeComponent();
            CarregarListView();

        }

        private void CarregarListView()
        {
            var normalfont = new Font("Segoe UI", 20f, FontStyle.Bold);
            var listaVagas = _vagaService.Get<VagaModel>().ToList();
            for (var i = 0; i < listaVagas.Count; i++)
            {
                var item = listaVagas[i];
                Debug.WriteLine(item.Titulo);
                listViewVagas.Items.Add(new ListViewItem { ImageIndex = 0, Text = item.Titulo, Font = normalfont, Tag = item.Id });
            }
            //
        }

        private void listViewVagas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewVagas_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listViewVagas.Items.Count; i++)
            {
                var rectangle = listViewVagas.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    Debug.WriteLine(listViewVagas.FocusedItem);
                    Debug.WriteLine(listViewVagas.FocusedItem.Tag);
                    int id = Int32.Parse(listViewVagas.FocusedItem.Tag.ToString());
                    Debug.WriteLine(id);
                    var vaga = _vagaService.GetById<Vaga>(id);
                    CardVaga.Vaga = vaga;
                    Exibeformulario<CardVaga>();
                    return;
                }
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            cad.Show();
        }
    }
}
