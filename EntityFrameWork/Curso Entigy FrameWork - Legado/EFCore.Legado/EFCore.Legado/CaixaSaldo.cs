using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class CaixaSaldo
    {
        public int Id { get; set; }
        public int? CaixaId { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int FormaCobrancaId { get; set; }
        public string Forma { get; set; }
        public decimal ValorConfirmado { get; set; }
        public decimal ValorSaidaConfirmar { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string Token { get; set; }
        public decimal ValorEntradaConfirmar { get; set; }

        public virtual Caixa Caixa { get; set; }
    }
}
