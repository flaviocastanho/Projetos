using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public int Status { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public List<Cliente_Endereco> Enderecos { get; set; }
    }
}
