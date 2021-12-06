using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class IntegracaoOnline
    {
        public IntegracaoOnline()
        {
            FormaCobrancaIntegracaoOnlines = new HashSet<FormaCobrancaIntegracaoOnline>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Parceiro { get; set; }
        public string Credenciais { get; set; }
        public string Modo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }
        public string Endpoints { get; set; }

        public virtual ICollection<FormaCobrancaIntegracaoOnline> FormaCobrancaIntegracaoOnlines { get; set; }
    }
}
