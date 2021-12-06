using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturaCobrancaRealizadum
    {
        public int CobrancaId { get; set; }
        public string Situacao { get; set; }
        public DateTime PagamentoData { get; set; }
        public decimal PagamentoValor { get; set; }
        public decimal PagamentoTaxa { get; set; }
        public decimal PagamentoDesconto { get; set; }
        public int? FaturaId { get; set; }
        public int Id { get; set; }

        public virtual Cobranca Cobranca { get; set; }
        public virtual Fatura Fatura { get; set; }
    }
}
