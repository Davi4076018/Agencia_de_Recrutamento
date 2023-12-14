namespace Agencia_de_Recrutamento.App.Models
{
    public class CandidatoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int IdCidade { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Endereco { get; set; }
        public string? CPF { get; set; }
        public string? Formacao { get; set; }
        public bool Ativo { get; set; }

    }
}
