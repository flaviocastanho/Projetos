using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContaFinanceiraSaldoAcao
    {
        public DateTime Dia { get; set; }
        public int ContaFinanceiraId { get; set; }
        public string Acao { get; set; }
    }
}
