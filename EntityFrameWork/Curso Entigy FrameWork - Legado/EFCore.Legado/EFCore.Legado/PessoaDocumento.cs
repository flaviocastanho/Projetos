using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaDocumento
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Numero { get; set; }
        public bool EstaAtivo { get; set; }
        public DateTime DataEmissao { get; set; }
        public string ImagemFrente { get; set; }
        public string ImagemVerso { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime Validade { get; set; }
        public int? TipoDocumentoId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
