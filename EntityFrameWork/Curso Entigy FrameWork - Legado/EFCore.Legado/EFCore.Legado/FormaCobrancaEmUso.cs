using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FormaCobrancaEmUso
    {
        public string Local { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
    }
}
