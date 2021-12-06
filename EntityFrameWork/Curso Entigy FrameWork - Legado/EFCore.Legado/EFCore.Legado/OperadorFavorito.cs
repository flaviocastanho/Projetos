using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class OperadorFavorito
    {
        public int Id { get; set; }
        public int OperadorId { get; set; }
        public string NomeFavorito { get; set; }
        public bool? Excluido { get; set; }
        public int FuncionalidadeId { get; set; }

        public virtual ConfiguracaoClubeFuncionalidade Funcionalidade { get; set; }
    }
}
