using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FormasCobrancaPorOperador
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int ContaFinanceiraId { get; set; }
        public string ContaFinanceiraDescricao { get; set; }
        public int? AdquirenteId { get; set; }
        public string AdquirenteNome { get; set; }
        public int? AdquirenteBandeiraId { get; set; }
        public string AdquirenteBandeiraTipo { get; set; }
        public string AdquirenteBandeiraOperacao { get; set; }
        public int? AdquirenteBandeiraParcelaMinima { get; set; }
        public int? AdquirenteBandeiraParcelaMaxima { get; set; }
        public int? OperadorId { get; set; }
    }
}
