using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturaControle
    {
        public int Id { get; set; }
        public int OperadorId { get; set; }
        public DateTime Quando { get; set; }
        public string Status { get; set; }
        public string Mensagem { get; set; }
        public int FaturaId { get; set; }
        public int? CobrancaId { get; set; }

        public virtual Cobranca Cobranca { get; set; }
        public virtual Fatura Fatura { get; set; }
    }
}
