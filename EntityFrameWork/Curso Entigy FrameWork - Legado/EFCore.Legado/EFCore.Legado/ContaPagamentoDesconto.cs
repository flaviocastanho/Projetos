using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContaPagamentoDesconto
    {
        public int Id { get; set; }
        public int PlanoContaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int PagamentoId { get; set; }

        public virtual ContaPagamento Pagamento { get; set; }
        public virtual PlanoContum PlanoConta { get; set; }
    }
}
