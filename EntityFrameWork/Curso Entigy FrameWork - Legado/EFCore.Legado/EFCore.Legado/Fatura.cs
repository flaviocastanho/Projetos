using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Fatura
    {
        public Fatura()
        {
            Cobrancas = new HashSet<Cobranca>();
            FaturaCobrancaRealizada = new HashSet<FaturaCobrancaRealizadum>();
            FaturaControles = new HashSet<FaturaControle>();
            FaturaItems = new HashSet<FaturaItem>();
        }

        public int Id { get; set; }
        public string VencimentoReferencia { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string RegraJurosId { get; set; }
        public string RegraJuros { get; set; }
        public string Situacao { get; set; }
        public int? MeioDePagamentoId { get; set; }
        public int PagadorPessoaId { get; set; }
        public int? FaturamentoRecorrenteId { get; set; }
        public string PagadorDocumentoNumero { get; set; }
        public string PagadorDocumentoTipo { get; set; }
        public string PagadorEnderecoBairro { get; set; }
        public string PagadorEnderecoCep { get; set; }
        public string PagadorEnderecoCidade { get; set; }
        public string PagadorEnderecoComplemento { get; set; }
        public string PagadorEnderecoNumero { get; set; }
        public string PagadorEnderecoPais { get; set; }
        public string PagadorEnderecoRua { get; set; }
        public string PagadorEnderecoUf { get; set; }
        public string PagadorNome { get; set; }
        public string RegraMulta { get; set; }
        public string RegraMultaId { get; set; }
        public int? FormaCobrancaId { get; set; }
        public DateTime DataCalculo { get; set; }

        public virtual FaturamentoRecorrente FaturamentoRecorrente { get; set; }
        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual MeioDePagamento MeioDePagamento { get; set; }
        public virtual Pessoa PagadorPessoa { get; set; }
        public virtual ICollection<Cobranca> Cobrancas { get; set; }
        public virtual ICollection<FaturaCobrancaRealizadum> FaturaCobrancaRealizada { get; set; }
        public virtual ICollection<FaturaControle> FaturaControles { get; set; }
        public virtual ICollection<FaturaItem> FaturaItems { get; set; }
    }
}
