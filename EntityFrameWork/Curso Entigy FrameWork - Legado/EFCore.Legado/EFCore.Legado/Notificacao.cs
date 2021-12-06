using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Notificacao
    {
        public int Id { get; set; }
        public string Template { get; set; }
        public DateTime DadosEnvioQuando { get; set; }
        public string DadosEnvioStatus { get; set; }
        public string Campos { get; set; }
        public string DestinatarioEnderecoEmail { get; set; }
        public int? EventoId { get; set; }
        public string Tipo { get; set; }
        public string Assunto { get; set; }
        public string DestinatarioNome { get; set; }
        public string RemetenteEnderecoEmail { get; set; }
        public string RemetenteNome { get; set; }

        public virtual Evento Evento { get; set; }
    }
}
