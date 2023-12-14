namespace Agencia_de_Recrutamento.App.Models
{
    public class VagaModel
    {
        public VagaModel()
        {
            Inscritos = new List<CandidatoModel>();
        }
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Formacao { get; set; }
        public float Salario { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public int IdRecrutador { get; set; }
        public string Recrutador { get; set; }
        public List<CandidatoModel> Inscritos { get; set; }

    }
}
