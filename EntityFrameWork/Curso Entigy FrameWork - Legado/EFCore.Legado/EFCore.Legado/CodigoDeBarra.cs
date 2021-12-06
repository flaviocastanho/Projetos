using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class CodigoDeBarra
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string ValorAtual { get; set; }
        public string ProximoValor { get; set; }
        public string Hash { get; set; }
        public DateTime Data { get; set; }
    }
}
