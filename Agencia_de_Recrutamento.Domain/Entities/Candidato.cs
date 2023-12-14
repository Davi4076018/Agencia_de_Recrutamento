using Agencia_de_Recrutamento.Domain.Base;

namespace Agencia_de_Recrutamento.Domain.Entities
{
    public class Candidato : BaseEntity<int>
    {
        public Candidato()
        {

        }

        public Candidato(int id, string? nome, string? email, Cidade? cidade, string? bairro, string? endereco, string? cpf, string? formacao, bool ativo) : base(id)
        {
            Nome = nome;
            Email = email;
            Cidade = cidade;
            Bairro = bairro;
            Endereco = endereco;
            CPF = cpf;
            Formacao = formacao;
            Ativo = ativo;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Cidade? Cidade { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? CPF { get; set; }
        public string? Formacao { get; set; }
        public bool Ativo { get; set; }

    }
}
