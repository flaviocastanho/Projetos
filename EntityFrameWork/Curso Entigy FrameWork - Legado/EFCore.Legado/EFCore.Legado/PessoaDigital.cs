using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaDigital
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int OperadorId { get; set; }
        public string Mao { get; set; }
        public string Dedo { get; set; }
        public string ImagemDigital { get; set; }
        public byte[] TemplateIso { get; set; }
        public string TemplateFirTextEncode { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Operador Operador { get; set; }
    }
}
