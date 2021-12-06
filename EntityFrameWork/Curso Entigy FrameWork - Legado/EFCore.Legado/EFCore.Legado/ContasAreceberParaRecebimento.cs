using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContasAreceberParaRecebimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public string VencimentoReferencia { get; set; }
        public int DevedorId { get; set; }
        public string DevedorNome { get; set; }
        public int? PagadorId { get; set; }
        public string PagadorNome { get; set; }
        public int? ContratoBeneficiarioId { get; set; }
        public string ContratoBeneficiarioNome { get; set; }
        public int? ContratoId { get; set; }
        public string ContratoDescricao { get; set; }
    }
}
