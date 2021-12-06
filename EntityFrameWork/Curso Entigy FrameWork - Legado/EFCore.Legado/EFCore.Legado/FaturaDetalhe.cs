using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturaDetalhe
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public bool PermiteImpressao { get; set; }
        public DateTime Vencimento { get; set; }
        public string Situacao { get; set; }
        public int PagadorId { get; set; }
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
        public string BoletoUrl { get; set; }
        public int? FaturaItemId { get; set; }
        public string FaturaItemDescricao { get; set; }
        public decimal? FaturaItemValor { get; set; }
        public decimal? FaturaItemDesconto { get; set; }
        public string FaturaItemSituacao { get; set; }
        public string FaturaItemReferencia { get; set; }
        public int? FaturaItemContratoId { get; set; }
        public string FaturaItemContratoNumero { get; set; }
        public int FaturaStatusId { get; set; }
        public string FaturaStatusDescricao { get; set; }
        public DateTime FaturaStatusQuando { get; set; }
        public string FaturaStatusOperadorNome { get; set; }
    }
}
