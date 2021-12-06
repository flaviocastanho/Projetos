using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ConfiguracaoClubeOpcaoMenu
    {
        public int Id { get; set; }
        public int FuncionalidadeId { get; set; }
        public string Titulo { get; set; }
        public string Rota { get; set; }
        public int Ordem { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int? ConfiguracaoClubeGrupoMenuId { get; set; }

        public virtual ConfiguracaoClubeGrupoMenu ConfiguracaoClubeGrupoMenu { get; set; }
        public virtual ConfiguracaoClubeFuncionalidade Funcionalidade { get; set; }
    }
}
