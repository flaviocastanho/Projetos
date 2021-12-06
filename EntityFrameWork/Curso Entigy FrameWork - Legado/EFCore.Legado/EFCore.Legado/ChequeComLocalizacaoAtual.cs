using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ChequeComLocalizacaoAtual
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string ContaBanco { get; set; }
        public string ContaAgencia { get; set; }
        public string ContaNumero { get; set; }
        public string CorrentistaDocumentoTipo { get; set; }
        public string CorrentistaDocumentoNumero { get; set; }
        public string CorrentistaNome { get; set; }
        public DateTime RecebidoEm { get; set; }
        public DateTime DescontarEm { get; set; }
        public decimal Valor { get; set; }
        public int? OrigemCaixaId { get; set; }
        public int OrigemContaFinanceiraId { get; set; }
        public int OrigemFormaCobrancaId { get; set; }
        public string OrigemStatus { get; set; }
        public string LocalAtualTipo { get; set; }
        public int? LocalAtualCaixaId { get; set; }
        public int? LocalAtualContaFinanceiraId { get; set; }
        public int? LocalAtualFormaCobrancaId { get; set; }
    }
}
