using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TransacaoCartaoConfirmacaoTransferencium
    {
        public Guid Id { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int TransferenciaCaixaId { get; set; }
        public bool Confirmado { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? TransacaoId { get; set; }

        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual TransacaoCartao Transacao { get; set; }
        public virtual Transferencium TransferenciaCaixa { get; set; }
    }
}
