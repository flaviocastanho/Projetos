using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class SaldoFormaCobranca
    {
        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public string Tipo { get; set; }
        public decimal ValorConfirmado { get; set; }
        public decimal ValorTotal { get; set; }
        public string Token { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int SaldoId { get; set; }
        public decimal ValorEntradaConfirmar { get; set; }
        public decimal ValorSaidaConfirmar { get; set; }

        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual Saldo Saldo { get; set; }
    }
}
