using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Acao
    {
        public Acao()
        {
            AcaoPerfils = new HashSet<AcaoPerfil>();
        }

        public int Id { get; set; }
        public int DireitoId { get; set; }
        public string Tipo { get; set; }

        public virtual Direito Direito { get; set; }
        public virtual ICollection<AcaoPerfil> AcaoPerfils { get; set; }
    }
}
