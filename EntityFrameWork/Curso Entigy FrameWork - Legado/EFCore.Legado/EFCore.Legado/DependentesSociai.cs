using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class DependentesSociai
    {
        public int PessoaId { get; set; }
        public int ContratoId { get; set; }
        public int ContratoTitularId { get; set; }
        public string Nome { get; set; }
        public string FotoPerfil { get; set; }
        public string Categoria { get; set; }
        public string Relacionamento { get; set; }
        public string SituacaoContrato { get; set; }
        public string PosicaoContrato { get; set; }
        public string SituacaoFinanceira { get; set; }
    }
}
