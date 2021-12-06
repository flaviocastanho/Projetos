using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaArmaProcesso
    {
        public PessoaArmaProcesso()
        {
            PessoaArmaProcessoEtapas = new HashSet<PessoaArmaProcessoEtapa>();
        }

        public int Id { get; set; }
        public int ArmaId { get; set; }
        public int ProcessoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual PessoaArma Arma { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual ICollection<PessoaArmaProcessoEtapa> PessoaArmaProcessoEtapas { get; set; }
    }
}
