using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class DocumentosAtivo
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int? TipoDocumentoId { get; set; }
        public string TipoDocumentoNome { get; set; }
        public string Numero { get; set; }
        public DateTime Validade { get; set; }
    }
}
