using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Taxa
    {
        public Taxa()
        {
            Conta = new HashSet<Contum>();
            ContratoTaxas = new HashSet<ContratoTaxa>();
            ModeloContratoTaxas = new HashSet<ModeloContratoTaxa>();
            ModeloDeCarteiras = new HashSet<ModeloDeCarteira>();
            TaxaValors = new HashSet<TaxaValor>();
        }

        public int Id { get; set; }
        public int PlanoDeContaId { get; set; }
        public string Descricao { get; set; }
        public string VigenciaPor { get; set; }
        public string RegraVencimento { get; set; }
        public string Recorrencia { get; set; }
        public string ConfiguracaoFechamento { get; set; }
        public int GrupoId { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Contum> Conta { get; set; }
        public virtual ICollection<ContratoTaxa> ContratoTaxas { get; set; }
        public virtual ICollection<ModeloContratoTaxa> ModeloContratoTaxas { get; set; }
        public virtual ICollection<ModeloDeCarteira> ModeloDeCarteiras { get; set; }
        public virtual ICollection<TaxaValor> TaxaValors { get; set; }
    }
}
