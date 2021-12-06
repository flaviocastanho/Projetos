using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ConfiguracaoClubeFuncionalidade
    {
        public ConfiguracaoClubeFuncionalidade()
        {
            OperadorFavoritos = new HashSet<OperadorFavorito>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Disponivel { get; set; }
        public bool Beta { get; set; }

        public virtual ConfiguracaoClubeOpcaoMenu ConfiguracaoClubeOpcaoMenu { get; set; }
        public virtual ICollection<OperadorFavorito> OperadorFavoritos { get; set; }
    }
}
