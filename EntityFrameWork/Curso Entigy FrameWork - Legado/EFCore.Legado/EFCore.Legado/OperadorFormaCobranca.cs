using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class OperadorFormaCobranca
    {
        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public int? OperadorId { get; set; }

        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual Operador Operador { get; set; }
    }
}
