using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaContato
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public bool Favorito { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
