using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class CampoCustomizado
    {
        public CampoCustomizado()
        {
            CampoCustomizadoOpcaos = new HashSet<CampoCustomizadoOpcao>();
            PessoaCampoCustomizados = new HashSet<PessoaCampoCustomizado>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Local { get; set; }
        public string Label { get; set; }
        public bool Obrigatorio { get; set; }
        public bool ExibeAdesao { get; set; }
        public bool PermiteEditar { get; set; }
        public int? MaximoCaracteres { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual ICollection<CampoCustomizadoOpcao> CampoCustomizadoOpcaos { get; set; }
        public virtual ICollection<PessoaCampoCustomizado> PessoaCampoCustomizados { get; set; }
    }
}
