using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TransacaoItem
    {
        public int Id { get; set; }
        public int TransacaoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DescontoValidoAte { get; set; }
        public decimal DescontoValor { get; set; }

        public virtual Transacao Transacao { get; set; }
    }
}
