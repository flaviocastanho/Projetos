using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class GrupoTaxaAdimplencium
    {
        public bool Ativa { get; set; }
        public string Escopo { get; set; }
        public string Regra { get; set; }
        public int GrupoTaxaId { get; set; }

        public virtual GrupoTaxa GrupoTaxa { get; set; }
    }
}
