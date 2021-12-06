using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TaxaValorRegraDesconto
    {
        public int Id { get; set; }
        public string RegraId { get; set; }
        public string Regra { get; set; }
        public int? TaxaValorId { get; set; }
        public string Especializacao { get; set; }
        public int OrdemExecucao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual TaxaValor TaxaValor { get; set; }
    }
}
