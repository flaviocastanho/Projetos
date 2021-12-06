using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContasParaFaturar
    {
        public int Id { get; set; }
        public DateTime Vencimento { get; set; }
        public int? MeioDePagamentoId { get; set; }
    }
}
