using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ProcessoEtapaDocumentosObrigatorio
    {
        public int Id { get; set; }
        public int EtapaId { get; set; }
        public int TipoDeDocumentoId { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ProcessoEtapa Etapa { get; set; }
        public virtual TipoDocumento TipoDeDocumento { get; set; }
    }
}
