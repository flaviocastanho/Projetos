using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoItem
    {
        public RecebimentoItem()
        {
            Lancamentos = new HashSet<Lancamento>();
            RecebimentoItemDescontos = new HashSet<RecebimentoItemDesconto>();
        }

        public int Id { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal JurosValor { get; set; }
        public decimal MultaValor { get; set; }
        public int? MultaPlanoContaId { get; set; }
        public int? JurosPlanoContaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? ContaId { get; set; }
        public int? RecebimentoId { get; set; }

        public virtual Contum Conta { get; set; }
        public virtual Recebimento Recebimento { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<RecebimentoItemDesconto> RecebimentoItemDescontos { get; set; }
    }
}
