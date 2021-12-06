using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PlanoContum
    {
        public PlanoContum()
        {
            Adquirentes = new HashSet<Adquirente>();
            Conta = new HashSet<Contum>();
            ContaDescontos = new HashSet<ContaDesconto>();
            ContaPagamentoDescontos = new HashSet<ContaPagamentoDesconto>();
            FormaCobrancaIntegracaoOnlines = new HashSet<FormaCobrancaIntegracaoOnline>();
            GrupoTaxaPlanoContaDescontos = new HashSet<GrupoTaxa>();
            GrupoTaxaPlanoContaJuros = new HashSet<GrupoTaxa>();
            GrupoTaxaPlanoContaSinteticas = new HashSet<GrupoTaxa>();
            Lancamentos = new HashSet<Lancamento>();
            RecebimentoItemDescontos = new HashSet<RecebimentoItemDesconto>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int ContaPaiId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Excluido { get; set; }
        public string Tipo { get; set; }
        public string TipoLancamento { get; set; }
        public DateTime UltimaAlteracao { get; set; }

        public virtual ICollection<Adquirente> Adquirentes { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
        public virtual ICollection<ContaDesconto> ContaDescontos { get; set; }
        public virtual ICollection<ContaPagamentoDesconto> ContaPagamentoDescontos { get; set; }
        public virtual ICollection<FormaCobrancaIntegracaoOnline> FormaCobrancaIntegracaoOnlines { get; set; }
        public virtual ICollection<GrupoTaxa> GrupoTaxaPlanoContaDescontos { get; set; }
        public virtual ICollection<GrupoTaxa> GrupoTaxaPlanoContaJuros { get; set; }
        public virtual ICollection<GrupoTaxa> GrupoTaxaPlanoContaSinteticas { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<RecebimentoItemDesconto> RecebimentoItemDescontos { get; set; }
    }
}
