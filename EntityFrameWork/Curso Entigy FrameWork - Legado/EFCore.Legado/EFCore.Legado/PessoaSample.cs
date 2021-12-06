using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaSample
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public TimeSpan? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
