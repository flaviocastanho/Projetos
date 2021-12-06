using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class OperadorPreferencium
    {
        public int Id { get; set; }
        public int OperadorId { get; set; }
        public bool ExibirFavoritos { get; set; }
        public bool ExibirContratosCancelados { get; set; }
        public bool ExibirCarteirasCanceladas { get; set; }
        public string TipoExibicaoContratos { get; set; }
        public string Tema { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
    }
}
