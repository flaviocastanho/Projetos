using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class PessoaProcessoEtapa
    {
        public int Id { get; set; }
        public int PessoaProcessoId { get; set; }
        public int ProcessoEtapaId { get; set; }
        public bool Concluido { get; set; }
        public DateTime? DataDeConclusao { get; set; }
        public int? OperadorConclusao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual Operador OperadorConclusaoNavigation { get; set; }
        public virtual PessoaProcesso PessoaProcesso { get; set; }
        public virtual ProcessoEtapa ProcessoEtapa { get; set; }
    }
}
