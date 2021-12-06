using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class DireitoGrupo
    {
        public DireitoGrupo()
        {
            Direitos = new HashSet<Direito>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int FuncionalidadeId { get; set; }

        public virtual ICollection<Direito> Direitos { get; set; }
    }
}
