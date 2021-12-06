using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Contrato
    {
        public Contrato()
        {
            Conta = new HashSet<Contum>();
            ContratoHistoricos = new HashSet<ContratoHistorico>();
            ContratoTaxas = new HashSet<ContratoTaxa>();
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public int ContratanteId { get; set; }
        public int MeioDePagamentoId { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFim { get; set; }
        public int BeneficiarioId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int ModeloDeContratoId { get; set; }
        public string SituacaoFinanceira { get; set; }

        public virtual Pessoa Beneficiario { get; set; }
        public virtual Pessoa Contratante { get; set; }
        public virtual MeioDePagamento MeioDePagamento { get; set; }
        public virtual ModeloContrato ModeloDeContrato { get; set; }
        public virtual ContratoTipo ContratoTipo { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
        public virtual ICollection<ContratoHistorico> ContratoHistoricos { get; set; }
        public virtual ICollection<ContratoTaxa> ContratoTaxas { get; set; }
    }
}
