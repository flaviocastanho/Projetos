using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContaPagamento
    {
        public ContaPagamento()
        {
            ContaPagamentoDescontos = new HashSet<ContaPagamentoDesconto>();
        }

        public int Id { get; set; }
        public DateTime RecebidoEm { get; set; }
        public int? JurosPlanoContaId { get; set; }
        public decimal JurosValor { get; set; }
        public int? ContaId { get; set; }
        public decimal ValorBruto { get; set; }
        public int? MultaPlanoContaId { get; set; }
        public decimal MultaValor { get; set; }
        public DateTime CancelamentoData { get; set; }
        public int? CancelamentoOperadorId { get; set; }
        public bool? CancelamentoRealizado { get; set; }

        public virtual Operador CancelamentoOperador { get; set; }
        public virtual Contum Conta { get; set; }
        public virtual ICollection<ContaPagamentoDesconto> ContaPagamentoDescontos { get; set; }
    }
}
