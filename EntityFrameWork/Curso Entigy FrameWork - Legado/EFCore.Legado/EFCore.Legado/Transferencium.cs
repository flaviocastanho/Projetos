using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Transferencium
    {
        public Transferencium()
        {
            TransacaoCartaoConfirmacaoTransferencia = new HashSet<TransacaoCartaoConfirmacaoTransferencium>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Situacao { get; set; }
        public decimal Valor { get; set; }
        public int? CaixaOrigemId { get; set; }
        public int? ContaFinanceiraDestinoId { get; set; }
        public int? FormaCobrancaDestinoId { get; set; }
        public DateTime? DataSaldoDestino { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public DateTime? AprovacaoData { get; set; }
        public int? AprovacaoOperadorId { get; set; }
        public bool? Aprovado { get; set; }
        public int? ChequeId { get; set; }
        public int? CaixaDestinoId { get; set; }
        public int? SaldoContaOrigemId { get; set; }
        public int? TransacaoCartaoId { get; set; }
        public int? FormaCobrancaOrigemId { get; set; }
        public int? SaldoContaDestinoId { get; set; }
        public string TipoForma { get; set; }
        public Guid? ChaveDeTransferencia { get; set; }

        public virtual Caixa CaixaDestino { get; set; }
        public virtual Caixa CaixaOrigem { get; set; }
        public virtual Cheque Cheque { get; set; }
        public virtual ContaFinanceira ContaFinanceiraDestino { get; set; }
        public virtual FormaCobranca FormaCobrancaDestino { get; set; }
        public virtual FormaCobranca FormaCobrancaOrigem { get; set; }
        public virtual Saldo SaldoContaDestino { get; set; }
        public virtual Saldo SaldoContaOrigem { get; set; }
        public virtual TransacaoCartao TransacaoCartao { get; set; }
        public virtual ICollection<TransacaoCartaoConfirmacaoTransferencium> TransacaoCartaoConfirmacaoTransferencia { get; set; }
    }
}
