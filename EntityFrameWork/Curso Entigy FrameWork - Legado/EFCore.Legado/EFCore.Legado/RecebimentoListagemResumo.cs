using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoListagemResumo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Pagador { get; set; }
        public string Operador { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public decimal? TotalItens { get; set; }
        public decimal? TotalMulta { get; set; }
        public decimal? TotalJuros { get; set; }
        public decimal TotalDesconto { get; set; }
        public string Status { get; set; }
    }
}
