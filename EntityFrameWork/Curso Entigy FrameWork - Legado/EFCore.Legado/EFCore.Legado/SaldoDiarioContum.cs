using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class SaldoDiarioContum
    {
        public int ContaFinanceiraId { get; set; }
        public DateTime Dia { get; set; }
        public string Situacao { get; set; }
    }
}
