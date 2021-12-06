using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoItemDesconto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int? PlanoContaId { get; set; }
        public int? RecebimentoItemId { get; set; }

        public virtual PlanoContum PlanoConta { get; set; }
        public virtual RecebimentoItem RecebimentoItem { get; set; }
    }
}
