using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratoTipo
    {
        public int ContratoId { get; set; }
        public string Tipo { get; set; }
        public string Classificacao { get; set; }
        public string Categoria { get; set; }
        public int ContratoPaiId { get; set; }
        public int EspecializacaoTipoAssociacao { get; set; }
        public string TipoAssociacao { get; set; }
        public int RelacionamentoId { get; set; }

        public virtual Contrato Contrato { get; set; }
    }
}
