using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Cobranca
    {
        public Cobranca()
        {
            FaturaCobrancaRealizada = new HashSet<FaturaCobrancaRealizadum>();
            FaturaControles = new HashSet<FaturaControle>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Especializacao { get; set; }
        public int FormaCobrancaId { get; set; }
        public string TransacaoOnLineId { get; set; }
        public string Situacao { get; set; }
        public string Status { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DescontoAntecipacaoValidoAte { get; set; }
        public decimal DescontoAntecipacaoValor { get; set; }
        public DateTime PagamentoData { get; set; }
        public decimal PagamentoValor { get; set; }
        public decimal PagamentoTaxa { get; set; }
        public decimal PagamentoDesconto { get; set; }
        public string MensagemSistemaCobranca { get; set; }
        public bool PermiteImpressao { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string BoletoNossoNumero { get; set; }
        public string BoletoLinhaDigitavel { get; set; }
        public bool BoletoRegistrado { get; set; }
        public string BoletoUrl { get; set; }
        public int? FaturaId { get; set; }

        public virtual Fatura Fatura { get; set; }
        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual ICollection<FaturaCobrancaRealizadum> FaturaCobrancaRealizada { get; set; }
        public virtual ICollection<FaturaControle> FaturaControles { get; set; }
    }
}
