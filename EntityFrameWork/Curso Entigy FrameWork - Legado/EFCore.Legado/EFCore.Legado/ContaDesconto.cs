using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContaDesconto
    {
        public int? ContaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Id { get; set; }
        public string Especializacao { get; set; }
        public string RegraAntecipacao { get; set; }
        public string RegraAntecipacaoId { get; set; }
        public string Tipo { get; set; }
        public int? PlanoContaId { get; set; }

        public virtual Contum Conta { get; set; }
        public virtual PlanoContum PlanoConta { get; set; }
    }
}
