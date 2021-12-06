using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ProcessoEtapa
    {
        public ProcessoEtapa()
        {
            PessoaArmaProcessoEtapas = new HashSet<PessoaArmaProcessoEtapa>();
            PessoaProcessoEtapas = new HashSet<PessoaProcessoEtapa>();
            ProcessoEtapaDocumentosObrigatorios = new HashSet<ProcessoEtapaDocumentosObrigatorio>();
        }

        public int Id { get; set; }
        public int ProcessoId { get; set; }
        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int Especializacao { get; set; }
        public bool PagamentoParaTerceiros { get; set; }
        public int TaxaId { get; set; }
        public string Declaracao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual ICollection<PessoaArmaProcessoEtapa> PessoaArmaProcessoEtapas { get; set; }
        public virtual ICollection<PessoaProcessoEtapa> PessoaProcessoEtapas { get; set; }
        public virtual ICollection<ProcessoEtapaDocumentosObrigatorio> ProcessoEtapaDocumentosObrigatorios { get; set; }
    }
}
