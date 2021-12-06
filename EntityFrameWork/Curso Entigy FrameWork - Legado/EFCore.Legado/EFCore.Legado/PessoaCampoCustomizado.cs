using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaCampoCustomizado
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int CampoCustomizadoId { get; set; }
        public string Valor { get; set; }

        public virtual CampoCustomizado CampoCustomizado { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
