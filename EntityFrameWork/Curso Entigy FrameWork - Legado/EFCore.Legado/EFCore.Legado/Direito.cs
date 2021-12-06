using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Direito
    {
        public Direito()
        {
            Acaos = new HashSet<Acao>();
        }

        public int Id { get; set; }
        public int DireitoGrupoId { get; set; }
        public string Descricao { get; set; }
        public int FuncionalidadeId { get; set; }

        public virtual DireitoGrupo DireitoGrupo { get; set; }
        public virtual ICollection<Acao> Acaos { get; set; }
    }
}
