using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class RecebimentoDetalhe
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime DataSaldo { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public string Status { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public int PagadorPessoaId { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorDocumentoTipo { get; set; }
        public string PagadorDocumentoNumero { get; set; }
        public string PagadorEnderecoRua { get; set; }
        public string PagadorEnderecoNumero { get; set; }
        public string PagadorEnderecoComplemento { get; set; }
        public string PagadorEnderecoBairro { get; set; }
        public string PagadorEnderecoCep { get; set; }
        public string PagadorEnderecoCidade { get; set; }
        public string PagadorEnderecoUf { get; set; }
        public string PagadorEnderecoPais { get; set; }
        public string Operador { get; set; }
        public int? OperadorId { get; set; }
        public DateTime? DevolucaoData { get; set; }
        public int? DevolucaoId { get; set; }
        public int FormaId { get; set; }
        public string FormaTipo { get; set; }
        public decimal FormaValorBruto { get; set; }
        public decimal FormaValorTroco { get; set; }
        public int? FormaChequeId { get; set; }
        public string FormaChequeBanco { get; set; }
        public string FormaChequeAgencia { get; set; }
        public string FormaChequeContaNumero { get; set; }
        public string FormaChequeNumero { get; set; }
        public int? FormaCartaoId { get; set; }
        public string FormaCartaoAdquirente { get; set; }
        public string FormaCartaoOperacao { get; set; }
        public string FormaCartaoBandeira { get; set; }
        public int? FormaCartaoParcelamento { get; set; }
        public string FormaCartaoAutorizacao { get; set; }
        public int ItemId { get; set; }
        public int ItemPessoaId { get; set; }
        public string ItemDescricao { get; set; }
        public string ItemReferencia { get; set; }
        public DateTime ItemVencimento { get; set; }
        public int? ItemContratoId { get; set; }
        public string ItemNome { get; set; }
        public decimal ItemValorBruto { get; set; }
        public decimal ItemValorJuros { get; set; }
        public decimal ItemValorMulta { get; set; }
        public int? ItemDescontoId { get; set; }
        public int? ItemDescontoItemId { get; set; }
        public decimal? ItemDescontoValor { get; set; }
    }
}
