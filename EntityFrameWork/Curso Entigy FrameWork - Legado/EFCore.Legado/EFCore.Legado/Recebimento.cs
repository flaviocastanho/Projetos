using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Recebimento
    {
        public Recebimento()
        {
            Devolucaos = new HashSet<Devolucao>();
            Lancamentos = new HashSet<Lancamento>();
            Movimentos = new HashSet<Movimento>();
            RecebimentoFormas = new HashSet<RecebimentoForma>();
            RecebimentoItems = new HashSet<RecebimentoItem>();
        }

        public int Id { get; set; }
        public int PagadorPessoaId { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorDocumentoTipo { get; set; }
        public string PagadorDocumentoNumero { get; set; }
        public string PagadorEnderecoRua { get; set; }
        public string PagadorEnderecoNumero { get; set; }
        public string PagadorEnderecoComplemento { get; set; }
        public string PagadorEnderecoBairro { get; set; }
        public string PagadorEnderecoCidade { get; set; }
        public string PagadorEnderecoUf { get; set; }
        public string PagadorEnderecoCep { get; set; }
        public string PagadorEnderecoPais { get; set; }
        public int? OperadorId { get; set; }
        public string Tipo { get; set; }
        public DateTime DataBaseDeCalculo { get; set; }
        public DateTime DataVencimentoFaturamento { get; set; }
        public DateTime DataLiquidacao { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Operador Operador { get; set; }
        public virtual Pessoa PagadorPessoa { get; set; }
        public virtual RecebimentoEstorno RecebimentoEstorno { get; set; }
        public virtual ICollection<Devolucao> Devolucaos { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual ICollection<RecebimentoItem> RecebimentoItems { get; set; }
    }
}
