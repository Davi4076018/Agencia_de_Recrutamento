using Agencia_de_Recrutamento.Domain.Base;

namespace Agencia_de_Recrutamento.Domain.Entities
{
    public class Recrutador : BaseEntity<int>
    {
        public Recrutador()
        {

        }

        public Recrutador(int id, string? nome, string? login, string? senha, string? email, bool ativo) : base(id)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Email = email;
            Ativo = ativo;
        }

        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public bool Ativo { get; set; }
    }
}