using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaArmaDocumento
    {
        public int Id { get; set; }
        public int ArmaId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Numero { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime? Validade { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string ImagemFrente { get; set; }
        public string ImagemVerso { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }
        public int? PessoaArmaId { get; set; }

        public virtual PessoaArma Arma { get; set; }
        public virtual PessoaArma PessoaArma { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
