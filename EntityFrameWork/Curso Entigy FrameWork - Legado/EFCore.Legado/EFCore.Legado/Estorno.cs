using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Estorno
    {
        public int Id { get; set; }
        public int? LiquidacaoId { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public int? OperadorId { get; set; }
        public DateTime DataPrevistaSaldo { get; set; }
        public string Operacao { get; set; }
        public string Tipo { get; set; }
        public string FormaCobranca { get; set; }
        public decimal? ValorBruto { get; set; }
        public decimal ValorTaxa { get; set; }
        public DateTime? CancelamentoData { get; set; }
        public int? CancelamentoOperadorId { get; set; }
        public bool CancelamentoRealizado { get; set; }
    }
}
