using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TaxaValorVigente
    {
        public string ValidaApartirDe { get; set; }
        public decimal ValorBase { get; set; }
        public int Id { get; set; }
        public int? TaxaId { get; set; }
        public int? GrupoId { get; set; }
    }
}
