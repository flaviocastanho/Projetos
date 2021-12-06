using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Marcador
    {
        public Marcador()
        {
            ClienteMarcadors = new HashSet<ClienteMarcador>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Especializacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string Cor { get; set; }

        public virtual ICollection<ClienteMarcador> ClienteMarcadors { get; set; }
    }
}
