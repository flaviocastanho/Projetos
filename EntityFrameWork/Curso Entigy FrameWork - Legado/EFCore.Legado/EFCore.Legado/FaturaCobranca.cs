using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturaCobranca
    {
        public int FaturaId { get; set; }
        public int? CobrancaId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string VencimentoReferencia { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? Valor { get; set; }
        public string Situacao { get; set; }
        public int PagadorPessoaId { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorDocumentoTipo { get; set; }
        public string PagadorDocumentoNumero { get; set; }
        public string PagadorEnderecoCep { get; set; }
        public string PagadorEnderecoBairro { get; set; }
        public string PagadorEnderecoCidade { get; set; }
        public string PagadorEnderecoComplemento { get; set; }
        public string PagadorEnderecoNumero { get; set; }
        public string PagadorEnderecoPais { get; set; }
        public string PagadorEnderecoRua { get; set; }
        public string PagadorEnderecoUf { get; set; }
        public string BoletoLinhaDigitavel { get; set; }
        public string BoletoUrl { get; set; }
        public int? FaturaItemId { get; set; }
        public string FaturaItemDescricao { get; set; }
        public decimal? FaturaItemValor { get; set; }
    }
}
