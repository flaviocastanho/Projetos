using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoForma
    {
        public RecebimentoForma()
        {
            Lancamentos = new HashSet<Lancamento>();
        }

        public int Id { get; set; }
        public string Especializacao { get; set; }
        public int? ChequeId { get; set; }
        public int? TransacaoCartaoId { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorTroco { get; set; }
        public DateTime? DescontarEm { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? RecebimentoId { get; set; }

        public virtual Cheque Cheque { get; set; }
        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual Recebimento Recebimento { get; set; }
        public virtual TransacaoCartao TransacaoCartao { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
