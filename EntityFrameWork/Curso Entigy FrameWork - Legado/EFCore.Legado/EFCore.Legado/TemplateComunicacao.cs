using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TemplateComunicacao
    {
        public TemplateComunicacao()
        {
            ModeloContratos = new HashSet<ModeloContrato>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual ICollection<ModeloContrato> ModeloContratos { get; set; }
    }
}
