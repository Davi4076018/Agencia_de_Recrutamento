﻿namespace Agencia_de_Recrutamento.App.Models
{
    public class RecrutadorModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public bool Ativo { get; set; }

    }
}
