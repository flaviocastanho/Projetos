using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Liquidacao
    {
        public int Id { get; set; }
        public int? LiquidacaoId { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public int? OperadorId { get; set; }
        public DateTime DataPrevistaSaldo { get; set; }
        public string FormaCobranca { get; set; }
        public decimal? ValorBruto { get; set; }
        public decimal ValorTaxa { get; set; }
    }
}
