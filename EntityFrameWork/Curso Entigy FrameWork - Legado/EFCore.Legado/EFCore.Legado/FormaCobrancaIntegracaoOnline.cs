using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FormaCobrancaIntegracaoOnline
    {
        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public int IntegracaoOnlineId { get; set; }
        public string TipoTaxa { get; set; }
        public int? PlanoContaTaxaId { get; set; }
        public decimal PercentualTaxa { get; set; }
        public decimal ValorFixoTaxa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }
        public string Instrucoes { get; set; }
        public string LocalPagamento { get; set; }

        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual IntegracaoOnline IntegracaoOnline { get; set; }
        public virtual PlanoContum PlanoContaTaxa { get; set; }
    }
}
