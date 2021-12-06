using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloDeCarteiraTemplate
    {
        public ModeloDeCarteiraTemplate()
        {
            ModeloDeCarteiras = new HashSet<ModeloDeCarteira>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public virtual ICollection<ModeloDeCarteira> ModeloDeCarteiras { get; set; }
    }
}
