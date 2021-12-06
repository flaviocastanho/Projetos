using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Adquirente
    {
        public Adquirente()
        {
            AdquirenteBandeiras = new HashSet<AdquirenteBandeira>();
            FormaCobrancas = new HashSet<FormaCobranca>();
            TransacaoCartaos = new HashSet<TransacaoCartao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoConvenio { get; set; }
        public string RedeAdquirente { get; set; }
        public int? PlanoContaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }

        public virtual PlanoContum PlanoConta { get; set; }
        public virtual ICollection<AdquirenteBandeira> AdquirenteBandeiras { get; set; }
        public virtual ICollection<FormaCobranca> FormaCobrancas { get; set; }
        public virtual ICollection<TransacaoCartao> TransacaoCartaos { get; set; }
    }
}
