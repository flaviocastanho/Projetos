using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoEstorno
    {
        public int RecebimentoId { get; set; }
        public int OperadorId { get; set; }
        public DateTime Data { get; set; }

        public virtual Operador Operador { get; set; }
        public virtual Recebimento Recebimento { get; set; }
    }
}
