using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Contum
    {
        public Contum()
        {
            ContaDescontos = new HashSet<ContaDesconto>();
            ContaPagamentos = new HashSet<ContaPagamento>();
            FaturaItems = new HashSet<FaturaItem>();
            RecebimentoItems = new HashSet<RecebimentoItem>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public int PessoaId { get; set; }
        public int PlanoDeContaId { get; set; }
        public int? MeioDePagamentoId { get; set; }
        public int? TaxaId { get; set; }
        public int? ContratoId { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public decimal ValorBruto { get; set; }
        public string RegraJurosId { get; set; }
        public string RegraJuros { get; set; }
        public DateTime Vencimento { get; set; }
        public string VencimentoReferencia { get; set; }
        public string Situacao { get; set; }
        public DateTime SituacaoAtualizadaEm { get; set; }
        public string RegraMulta { get; set; }
        public string RegraMultaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }

        public virtual Contrato Contrato { get; set; }
        public virtual MeioDePagamento MeioDePagamento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual PlanoContum PlanoDeConta { get; set; }
        public virtual Taxa Taxa { get; set; }
        public virtual ICollection<ContaDesconto> ContaDescontos { get; set; }
        public virtual ICollection<ContaPagamento> ContaPagamentos { get; set; }
        public virtual ICollection<FaturaItem> FaturaItems { get; set; }
        public virtual ICollection<RecebimentoItem> RecebimentoItems { get; set; }
    }
}
