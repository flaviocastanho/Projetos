using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class CarteiraHistorico
    {
        public int Id { get; set; }
        public int CarteiraId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string CanalEntrega { get; set; }
        public string MotivoRecolhimento { get; set; }
        public string MotivoCancelamento { get; set; }
        public bool? Excluido { get; set; }
        public int OperadorId { get; set; }

        public virtual Carteira Carteira { get; set; }
    }
}
