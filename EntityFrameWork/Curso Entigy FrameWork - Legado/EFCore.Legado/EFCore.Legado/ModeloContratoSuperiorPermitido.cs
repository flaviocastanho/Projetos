using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloContratoSuperiorPermitido
    {
        public int Id { get; set; }
        public int ModeloContratoSuperiorId { get; set; }
        public int? ModeloContratoId { get; set; }

        public virtual ModeloContrato ModeloContrato { get; set; }
    }
}
