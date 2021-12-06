using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class AdquirenteBandeira
    {
        public AdquirenteBandeira()
        {
            TransacaoCartaos = new HashSet<TransacaoCartao>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Operacao { get; set; }
        public int ParcelamentoMinimo { get; set; }
        public int ParcelamentoMaximo { get; set; }
        public string TaxaConfiguracao { get; set; }
        public string PrevisaoLiquidezConfiguracao { get; set; }
        public int? AdquirenteId { get; set; }
        public bool? Excluido { get; set; }

        public virtual Adquirente Adquirente { get; set; }
        public virtual ICollection<TransacaoCartao> TransacaoCartaos { get; set; }
    }
}
