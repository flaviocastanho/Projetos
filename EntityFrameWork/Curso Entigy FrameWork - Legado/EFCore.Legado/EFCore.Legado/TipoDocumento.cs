using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            ArmaDocumentos = new HashSet<ArmaDocumento>();
            PessoaArmaDocumentos = new HashSet<PessoaArmaDocumento>();
            PessoaDocumentos = new HashSet<PessoaDocumento>();
            ProcessoEtapaDocumentosObrigatorios = new HashSet<ProcessoEtapaDocumentosObrigatorio>();
        }

        public int Id { get; set; }
        public string Especializacao { get; set; }
        public string Nome { get; set; }
        public string Mascara { get; set; }
        public bool? RequerValidade { get; set; }
        public bool? RequerOrgaoExpeditor { get; set; }
        public bool? RequerImagemFrente { get; set; }
        public bool? RequerImagemVerso { get; set; }
        public int DiasNotificacaoVencimentoPessoa { get; set; }
        public int DiasNotificacaoVencimentoOperador { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual ICollection<ArmaDocumento> ArmaDocumentos { get; set; }
        public virtual ICollection<PessoaArmaDocumento> PessoaArmaDocumentos { get; set; }
        public virtual ICollection<PessoaDocumento> PessoaDocumentos { get; set; }
        public virtual ICollection<ProcessoEtapaDocumentosObrigatorio> ProcessoEtapaDocumentosObrigatorios { get; set; }
    }
}
