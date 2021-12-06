using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Relacionamento
    {
        public Relacionamento()
        {
            ModeloContratoRegraDependentes = new HashSet<ModeloContratoRegraDependente>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual ICollection<ModeloContratoRegraDependente> ModeloContratoRegraDependentes { get; set; }
    }
}
