using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class AcaoPerfil
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public int AcaoId { get; set; }
        public bool Permitido { get; set; }

        public virtual Acao Acao { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
