using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturaItem
    {
        public int Id { get; set; }
        public int ContaAreceberId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DescontoValidoAte { get; set; }
        public decimal DescontoValor { get; set; }
        public int? FaturaId { get; set; }
        public int DescontoPlanoContaId { get; set; }

        public virtual Contum ContaAreceber { get; set; }
        public virtual Fatura Fatura { get; set; }
    }
}
