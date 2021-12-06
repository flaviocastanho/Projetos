using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloContratoRegraDependente
    {
        public int Id { get; set; }
        public int? RelacionamentoId { get; set; }
        public string RegraDependenteId { get; set; }
        public string RegraDependenteValor { get; set; }
        public int? ModeloContratoId { get; set; }

        public virtual ModeloContrato ModeloContrato { get; set; }
        public virtual Relacionamento Relacionamento { get; set; }
    }
}
