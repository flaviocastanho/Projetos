using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturasAprovadasListagem
    {
        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public string FormaDescricao { get; set; }
        public string FormaTipo { get; set; }
        public int PagadorId { get; set; }
        public DateTime Emissao { get; set; }
        public string Referencia { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public string BoletoNossoNumero { get; set; }
        public string BoletoUrl { get; set; }
        public bool PermiteImpressao { get; set; }
        public string FaturaStatusOperadorNome { get; set; }
    }
}
