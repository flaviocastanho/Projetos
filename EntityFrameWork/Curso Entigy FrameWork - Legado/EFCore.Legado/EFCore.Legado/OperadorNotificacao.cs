using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class OperadorNotificacao
    {
        public int Id { get; set; }
        public int OperadorId { get; set; }
        public DateTime? DataLida { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string AcaoTexto { get; set; }
        public string TipoRota { get; set; }
        public string Rota { get; set; }
        public string Parametros { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Operador Operador { get; set; }
    }
}
