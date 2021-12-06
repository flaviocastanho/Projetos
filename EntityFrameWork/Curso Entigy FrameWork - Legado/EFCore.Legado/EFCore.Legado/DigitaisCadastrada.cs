using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class DigitaisCadastrada
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int OperadorId { get; set; }
        public string Mao { get; set; }
        public string Dedo { get; set; }
        public string ImagemDigital { get; set; }
    }
}
