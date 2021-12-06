using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class AcaoPo1
    {
        public int Id { get; set; }
        public string Contexto { get; set; }
        public string Evento { get; set; }
        public string Comando { get; set; }
        public string Fila { get; set; }
    }
}
