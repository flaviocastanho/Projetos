using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FaturamentoRecorrente
    {
        public FaturamentoRecorrente()
        {
            Faturas = new HashSet<Fatura>();
        }

        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public string ProcessoId { get; set; }
        public int DiaDeCobranca { get; set; }
        public string Referente { get; set; }
        public DateTime VencimentoInicial { get; set; }
        public DateTime VencimentoFinal { get; set; }
        public DateTime DataVencimentoFaturas { get; set; }
        public DateTime DataCalculoFaturas { get; set; }
        public string Status { get; set; }
        public string FiltroSituacaoContratosNaGeracao { get; set; }
        public string FiltroPaganteContratosNaGeracao { get; set; }
        public int QuantidadePrevistoPagadores { get; set; }
        public int QuantidadePreFaturas { get; set; }
        public DateTime AprovadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public DateTime PreparacaoFinalizadaEm { get; set; }
        public DateTime PreparacaoIniciadaEm { get; set; }
        public string MetodoParaCobranca { get; set; }
        public DateTime CriadoEm { get; set; }

        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual ICollection<Fatura> Faturas { get; set; }
    }
}
