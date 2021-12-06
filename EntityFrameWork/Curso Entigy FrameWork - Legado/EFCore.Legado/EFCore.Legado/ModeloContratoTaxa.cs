using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloContratoTaxa
    {
        public int Id { get; set; }
        public int? TaxaId { get; set; }
        public int? ModeloContratoId { get; set; }

        public virtual ModeloContrato ModeloContrato { get; set; }
        public virtual Taxa Taxa { get; set; }
    }
}
