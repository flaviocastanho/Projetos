using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class CarteiraCodigoDeBarra
    {
        public int Id { get; set; }
        public int CarteiraId { get; set; }
        public string CodigoDecimal { get; set; }
        public DateTime? DataGravacao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string CodigoHexadecimal { get; set; }

        public virtual Carteira Carteira { get; set; }
    }
}
