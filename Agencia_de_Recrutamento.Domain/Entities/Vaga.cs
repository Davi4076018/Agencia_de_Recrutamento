using Agencia_de_Recrutamento.Domain.Base;

namespace Agencia_de_Recrutamento.Domain.Entities
{
    public class Vaga : BaseEntity<int>
    {
        public Vaga()
        {
            Inscritos = new List<Candidato>();
        }

        public Vaga(int id, string? titulo, string? descricao, string? formacao, float salario, DateTime datacriacao, bool ativo, Empresa? empresa, List<Candidato> inscritos, Recrutador? recrutador) : base(id)
        {
            Titulo = titulo;
            Descricao = descricao;
            Formacao = formacao;
            Salario = salario;
            DataCriacao = datacriacao;
            Ativo = ativo;
            Empresa = empresa;
            Inscritos = inscritos;
            Recrutador = recrutador;
        }

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Formacao { get; set; }
        public float Salario { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
        public Empresa? Empresa { get; set; }
        public List<Candidato> Inscritos { get; set; }
        public Recrutador? Recrutador { get; set; }
    }
}