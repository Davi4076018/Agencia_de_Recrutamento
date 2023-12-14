namespace Agencia_de_Recrutamento.App.Models
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? CNPJ { get; set; }
        public string? Bairro { get; set; }
        public int IdCidade { get; set; }
        public string? Cidade { get; set; }

    }
}
