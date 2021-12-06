using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Arma
    {
        public Arma()
        {
            ArmaDocumentos = new HashSet<ArmaDocumento>();
        }

        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string NumeroDeSerie { get; set; }
        public string Especie { get; set; }
        public string Calibre { get; set; }
        public string QuantidadeDeCanos { get; set; }
        public string NumeroDeRaias { get; set; }
        public string Marca { get; set; }
        public string TipoDeFuncionamento { get; set; }
        public string Acabamento { get; set; }
        public string ComprimentoDoCano { get; set; }
        public string SentidoDaRaia { get; set; }
        public string Modelo { get; set; }
        public string PaisDeFabricacao { get; set; }
        public string CapacidadeDeCarregamento { get; set; }
        public string TipoDeAlma { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<ArmaDocumento> ArmaDocumentos { get; set; }
    }
}
