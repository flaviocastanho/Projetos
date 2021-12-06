using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Movimento
    {
        public int Id { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public int? OperadorId { get; set; }
        public int? RecebimentoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string Especializacao { get; set; }
        public int? TransacaoId { get; set; }
        public int Parcela { get; set; }
        public int Parcelamento { get; set; }
        public decimal ValorTaxa { get; set; }
        public int? ChequeId { get; set; }
        public int? DevolucaoId { get; set; }
        public string Status { get; set; }
        public int? CancelamentoOperadorId { get; set; }
        public DateTime CancelamentoQuando { get; set; }
        public bool? CancelamentoRealizado { get; set; }
        public string FormaCobranca { get; set; }

        public virtual Cheque Cheque { get; set; }
        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual Devolucao Devolucao { get; set; }
        public virtual FormaCobranca FormaCobrancaNavigation { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual Recebimento Recebimento { get; set; }
        public virtual TransacaoCartao Transacao { get; set; }
    }
}
