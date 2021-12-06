using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Template
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public string Estrutura { get; set; }
        public string RemetenteEnderecoEmail { get; set; }
        public string RemetenteNome { get; set; }
    }
}
