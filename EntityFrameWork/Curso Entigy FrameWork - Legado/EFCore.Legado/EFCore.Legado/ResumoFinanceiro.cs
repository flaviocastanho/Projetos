using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ResumoFinanceiro
    {
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime PrevisaoConciliacao { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorTroco { get; set; }
        public decimal ValorTaxa { get; set; }
    }
}
