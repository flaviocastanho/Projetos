using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratosComDividasEmAbertoParaRevisaoAdimplencium
    {
        public int ContaId { get; set; }
        public int PessoaId { get; set; }
        public int? PagadorId { get; set; }
        public int? ContratoId { get; set; }
        public DateTime Vencimento { get; set; }
        public string Situacao { get; set; }
        public int TaxaId { get; set; }
        public int GrupoTaxaId { get; set; }
    }
}
