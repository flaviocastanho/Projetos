using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Carteira
    {
        public Carteira()
        {
            CarteiraCodigoDeBarras = new HashSet<CarteiraCodigoDeBarra>();
            CarteiraHistoricos = new HashSet<CarteiraHistorico>();
        }

        public int Id { get; set; }
        public string NomeImpresso { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
        public int? TaxaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int ContratoId { get; set; }
        public int ModeloId { get; set; }

        public virtual ModeloDeCarteira Modelo { get; set; }
        public virtual ICollection<CarteiraCodigoDeBarra> CarteiraCodigoDeBarras { get; set; }
        public virtual ICollection<CarteiraHistorico> CarteiraHistoricos { get; set; }
    }
}
