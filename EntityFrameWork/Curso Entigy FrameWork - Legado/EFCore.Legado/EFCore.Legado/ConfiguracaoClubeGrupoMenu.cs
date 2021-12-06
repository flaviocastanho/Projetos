using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ConfiguracaoClubeGrupoMenu
    {
        public ConfiguracaoClubeGrupoMenu()
        {
            ConfiguracaoClubeOpcaoMenus = new HashSet<ConfiguracaoClubeOpcaoMenu>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Icone { get; set; }
        public int Ordem { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? MenuInferiorFixo { get; set; }

        public virtual ICollection<ConfiguracaoClubeOpcaoMenu> ConfiguracaoClubeOpcaoMenus { get; set; }
    }
}
