using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratoHistorico
    {
        public int Id { get; set; }
        public DateTime Quando { get; set; }
        public int? ContratoId { get; set; }
        public int? OcorrenciaId { get; set; }
        public int OperadorId { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }

        public virtual Contrato Contrato { get; set; }
        public virtual Ocorrencium Ocorrencia { get; set; }
        public virtual Operador Operador { get; set; }
    }
}
