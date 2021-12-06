using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ReciboLiquidacao
    {
        public string Fantasia { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoUf { get; set; }
        public string EnderecoPais { get; set; }
        public string Operador { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int LiquidacaoId { get; set; }
        public string Status { get; set; }
        public string Pagador { get; set; }
        public string ItemPessoa { get; set; }
        public string ItemDescricao { get; set; }
        public int? ItemContrato { get; set; }
        public string ItemReferencia { get; set; }
        public decimal ItemValor { get; set; }
        public decimal ItemMulta { get; set; }
        public decimal ItemJuros { get; set; }
        public decimal ItemDesconto { get; set; }
        public string MovimentoTipo { get; set; }
        public decimal MovimentoTroco { get; set; }
        public decimal MovimentoValor { get; set; }
        public int? MovimentoCartaoId { get; set; }
        public string MovimentoCartaoBandeira { get; set; }
        public string MovimentoCartaoOperacao { get; set; }
        public int? MovimentoCartaoParcelamento { get; set; }
        public decimal? MovimentoCartaoValor { get; set; }
        public string MovimentoChequeBanco { get; set; }
        public string MovimentoChequeNumero { get; set; }
    }
}
