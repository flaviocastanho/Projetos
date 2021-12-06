using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ModeloDeCarteira
    {
        public ModeloDeCarteira()
        {
            Carteiras = new HashSet<Carteira>();
            ModeloContratos = new HashSet<ModeloContrato>();
        }

        public int Id { get; set; }
        public int? ModeloCarteiraTemplateId { get; set; }
        public int? TaxaId { get; set; }
        public bool ContratoGeraIdentificacao { get; set; }
        public string OpcaoDePagamento { get; set; }
        public bool GeracaoAutomaticaDoCodigoDeBarras { get; set; }
        public string RegraValidade { get; set; }
        public string OpcaoDeCancelamentoDasViasAnteriores { get; set; }
        public string OpcaoDeImpressao { get; set; }
        public string ImagemDeFundoFrente { get; set; }
        public string ImagemDeFundoVerso { get; set; }

        public virtual ModeloDeCarteiraTemplate ModeloCarteiraTemplate { get; set; }
        public virtual Taxa Taxa { get; set; }
        public virtual ICollection<Carteira> Carteiras { get; set; }
        public virtual ICollection<ModeloContrato> ModeloContratos { get; set; }
    }
}
