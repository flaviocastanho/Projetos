using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Evento
    {
        public Evento()
        {
            Notificacaos = new HashSet<Notificacao>();
        }

        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Tipo { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Notificacao> Notificacaos { get; set; }
    }
}
