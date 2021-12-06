using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Perfil
    {
        public Perfil()
        {
            AcaoPerfils = new HashSet<AcaoPerfil>();
            Operadors = new HashSet<Operador>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual ICollection<AcaoPerfil> AcaoPerfils { get; set; }
        public virtual ICollection<Operador> Operadors { get; set; }
    }
}
