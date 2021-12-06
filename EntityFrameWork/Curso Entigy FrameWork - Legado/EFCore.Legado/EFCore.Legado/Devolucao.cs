using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Devolucao
    {
        public Devolucao()
        {
            DevolucaoFormas = new HashSet<DevolucaoForma>();
            Movimentos = new HashSet<Movimento>();
        }

        public int Id { get; set; }
        public int OperadorId { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int RecebimentoId { get; set; }

        public virtual Operador Operador { get; set; }
        public virtual Recebimento Recebimento { get; set; }
        public virtual ICollection<DevolucaoForma> DevolucaoFormas { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
    }
}
