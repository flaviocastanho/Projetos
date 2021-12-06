using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaProcesso
    {
        public PessoaProcesso()
        {
            PessoaProcessoEtapas = new HashSet<PessoaProcessoEtapa>();
        }

        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int ProcessoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual ICollection<PessoaProcessoEtapa> PessoaProcessoEtapas { get; set; }
    }
}
