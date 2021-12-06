using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratoTaxa
    {
        public int Id { get; set; }
        public int? TaxaId { get; set; }
        public int? ContratoId { get; set; }

        public virtual Contrato Contrato { get; set; }
        public virtual Taxa Taxa { get; set; }
    }
}
