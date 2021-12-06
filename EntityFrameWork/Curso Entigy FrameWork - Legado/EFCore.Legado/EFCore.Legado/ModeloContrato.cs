using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloContrato
    {
        public ModeloContrato()
        {
            Contratos = new HashSet<Contrato>();
            ModeloContratoRegraBeneficiarios = new HashSet<ModeloContratoRegraBeneficiario>();
            ModeloContratoRegraDependentes = new HashSet<ModeloContratoRegraDependente>();
            ModeloContratoSuperiorPermitidos = new HashSet<ModeloContratoSuperiorPermitido>();
            ModeloContratoTaxas = new HashSet<ModeloContratoTaxa>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string RegraValidade { get; set; }
        public bool DisponivelParaContratacao { get; set; }
        public string CategoriaEstatutaria { get; set; }
        public string TipoBeneficiario { get; set; }
        public bool PossuiCobrancaRecorrente { get; set; }
        public int? OcorrenciaId { get; set; }
        public bool? Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int NumeroMesesParaGeracaoTaxas { get; set; }
        public string TipoPessoaBeneficiario { get; set; }
        public int? ModeloCarteiraId { get; set; }
        public int? TemplateTermoAdesaoId { get; set; }

        public virtual ModeloDeCarteira ModeloCarteira { get; set; }
        public virtual Ocorrencium Ocorrencia { get; set; }
        public virtual TemplateComunicacao TemplateTermoAdesao { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<ModeloContratoRegraBeneficiario> ModeloContratoRegraBeneficiarios { get; set; }
        public virtual ICollection<ModeloContratoRegraDependente> ModeloContratoRegraDependentes { get; set; }
        public virtual ICollection<ModeloContratoSuperiorPermitido> ModeloContratoSuperiorPermitidos { get; set; }
        public virtual ICollection<ModeloContratoTaxa> ModeloContratoTaxas { get; set; }
    }
}
