using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ClienteMarcador
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int MarcadorId { get; set; }

        public virtual Marcador Marcador { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
