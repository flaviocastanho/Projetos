using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class DevolucaoForma
    {
        public int Id { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? DevolucaoId { get; set; }

        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual Devolucao Devolucao { get; set; }
        public virtual FormaCobranca FormaCobranca { get; set; }
    }
}
