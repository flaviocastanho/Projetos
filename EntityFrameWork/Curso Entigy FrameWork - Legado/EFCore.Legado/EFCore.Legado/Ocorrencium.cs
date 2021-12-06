using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Ocorrencium
    {
        public Ocorrencium()
        {
            ContratoHistoricos = new HashSet<ContratoHistorico>();
            ModeloContratos = new HashSet<ModeloContrato>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string SituacaoContrato { get; set; }
        public string PosicaoContrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? AfetarContratosDependentes { get; set; }

        public virtual ICollection<ContratoHistorico> ContratoHistoricos { get; set; }
        public virtual ICollection<ModeloContrato> ModeloContratos { get; set; }
    }
}
