using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Processo
    {
        public Processo()
        {
            PessoaArmaProcessos = new HashSet<PessoaArmaProcesso>();
            PessoaProcessos = new HashSet<PessoaProcesso>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual ICollection<PessoaArmaProcesso> PessoaArmaProcessos { get; set; }
        public virtual ICollection<PessoaProcesso> PessoaProcessos { get; set; }
    }
}
