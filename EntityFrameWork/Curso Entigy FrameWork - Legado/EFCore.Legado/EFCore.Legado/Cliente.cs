using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
