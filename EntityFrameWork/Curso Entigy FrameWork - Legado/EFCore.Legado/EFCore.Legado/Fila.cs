using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Fila
    {
        public Fila()
        {
            Lugars = new HashSet<Lugar>();
        }

        public int Id { get; set; }
        public int SetorId { get; set; }
        public string Codigo { get; set; }
        public int Ordem { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Setor Setor { get; set; }
        public virtual ICollection<Lugar> Lugars { get; set; }
    }
}
