using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ReciboLiquidacoesOperador
    {
        public int LiquidacaoId { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public int? OperadorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public string Especializacao { get; set; }
        public string CartaoTipo { get; set; }
        public string CartaoOperacao { get; set; }
        public string ChequeBanco { get; set; }
        public string ChequeNumero { get; set; }
    }
}
