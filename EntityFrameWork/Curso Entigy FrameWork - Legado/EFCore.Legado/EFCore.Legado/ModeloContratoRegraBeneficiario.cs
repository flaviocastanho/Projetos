using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloContratoRegraBeneficiario
    {
        public int Id { get; set; }
        public string RegraBeneficiarioId { get; set; }
        public string Valor { get; set; }
        public int? ModeloContratoId { get; set; }

        public virtual ModeloContrato ModeloContrato { get; set; }
    }
}
