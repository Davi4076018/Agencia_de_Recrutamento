using Agencia_de_Recrutamento.Domain.Base;

namespace Agencia_de_Recrutamento.Domain.Entities
{
    public class Empresa : BaseEntity<int>
    {
        public Empresa()
        {

        }

        public Empresa(int id, string? nome, string? endereco, string? cnpj, string? bairro, Cidade? cidade) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            CNPJ = cnpj;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? CNPJ { get; set; }
        public string? Bairro { get; set; }
        public Cidade? Cidade { get; set; }
    }
}