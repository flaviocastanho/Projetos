using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Lancamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Operacao { get; set; }
        public DateTime Previsao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? LiquidacaoId { get; set; }
        public int? LiquidacaoItemId { get; set; }
        public int? LiquidacaoMovimentoId { get; set; }
        public int? PlanoContaId { get; set; }
        public string Tipo { get; set; }
        public DateTime CancelamentoData { get; set; }
        public int? CancelamentoOperadorId { get; set; }
        public bool? CancelamentoRealizado { get; set; }

        public virtual Operador CancelamentoOperador { get; set; }
        public virtual Recebimento Liquidacao { get; set; }
        public virtual RecebimentoItem LiquidacaoItem { get; set; }
        public virtual RecebimentoForma LiquidacaoMovimento { get; set; }
        public virtual PlanoContum PlanoConta { get; set; }
    }
}
