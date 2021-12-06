using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContasParaListagem
    {
        public int Id { get; set; }
        public string VencimentoReferencia { get; set; }
        public DateTime Vencimento { get; set; }
        public string Descricao { get; set; }
        public int DevedorId { get; set; }
        public string DevedorNome { get; set; }
        public int? PagadorId { get; set; }
        public string PagadorNome { get; set; }
        public string Situacao { get; set; }
        public decimal ValorBruto { get; set; }
        public int? ContratoId { get; set; }
        public string ContratoNumero { get; set; }
        public string ContratoDescricao { get; set; }
        public int? ContratoContratanteId { get; set; }
        public string ContratoContratanteNome { get; set; }
        public int? ContratoBeneficiarioId { get; set; }
        public string ContratoBeneficiarioNome { get; set; }
        public int? ContratoPagadorId { get; set; }
        public string ContratoPagadorNome { get; set; }
    }
}
