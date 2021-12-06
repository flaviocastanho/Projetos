using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class GrupoTaxa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? PlanoContaDescontoId { get; set; }
        public int? PlanoContaJurosId { get; set; }
        public bool? Excluido { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? PlanoContaSinteticaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool? PermitirLancamentoAvulso { get; set; }

        public virtual PlanoContum PlanoContaDesconto { get; set; }
        public virtual PlanoContum PlanoContaJuros { get; set; }
        public virtual PlanoContum PlanoContaSintetica { get; set; }
        public virtual GrupoTaxaAdimplencium GrupoTaxaAdimplencium { get; set; }
    }
}
