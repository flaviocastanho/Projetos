using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TaxaValor
    {
        public TaxaValor()
        {
            TaxaValorRegraDescontos = new HashSet<TaxaValorRegraDesconto>();
        }

        public int Id { get; set; }
        public string Vigencia { get; set; }
        public decimal ValorBase { get; set; }
        public string RegraJurosId { get; set; }
        public string RegraJuros { get; set; }
        public int? TaxaId { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public string RegraMulta { get; set; }
        public string RegraMultaId { get; set; }

        public virtual Taxa Taxa { get; set; }
        public virtual ICollection<TaxaValorRegraDesconto> TaxaValorRegraDescontos { get; set; }
    }
}
