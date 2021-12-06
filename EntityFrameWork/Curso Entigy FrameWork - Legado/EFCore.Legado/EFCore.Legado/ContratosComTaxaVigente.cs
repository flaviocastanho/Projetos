using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratosComTaxaVigente
    {
        public int ContratoId { get; set; }
        public string Descricao { get; set; }
        public int BeneficiarioId { get; set; }
        public string BeneficiarioNome { get; set; }
        public int PagadorId { get; set; }
        public string PagadorNome { get; set; }
        public string SituacaoFinanceira { get; set; }
        public string SituacaoContrato { get; set; }
        public int GrupoTaxaId { get; set; }
        public string GrupoTaxaDescricao { get; set; }
        public int TaxaId { get; set; }
        public string TaxaDescricao { get; set; }
        public decimal TaxaValorBase { get; set; }
    }
}
