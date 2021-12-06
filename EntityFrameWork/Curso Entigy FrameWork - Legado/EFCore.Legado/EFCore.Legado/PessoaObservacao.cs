using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaObservacao
    {
        public int Id { get; set; }
        public int OperadorId { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? PessoaId { get; set; }

        public virtual Operador Operador { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
