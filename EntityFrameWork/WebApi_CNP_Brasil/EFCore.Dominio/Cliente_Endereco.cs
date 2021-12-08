using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Dominio
{
    public class Cliente_Endereco
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public String Logradouro { get; set; }
        public String Cep { get; set; }
        public String UF { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public int Status { get; set; }
        public DateTime Dt_Inclusao { get; set; }

    }
}
