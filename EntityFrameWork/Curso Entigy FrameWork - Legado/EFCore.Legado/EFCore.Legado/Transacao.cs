using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Transacao
    {
        public Transacao()
        {
            TransacaoItems = new HashSet<TransacaoItem>();
        }

        public int Id { get; set; }
        public string ClienteModulo { get; set; }
        public string ClientePedidoId { get; set; }
        public DateTime CriadoEm { get; set; }
        public string PagadorTipoDocumento { get; set; }
        public string PagadorNumeroDocumento { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorRua { get; set; }
        public string PagadorRuaNumero { get; set; }
        public string PagadorRuaComplemento { get; set; }
        public string PagadorRuaBairro { get; set; }
        public string PagadorRuaCidade { get; set; }
        public string PagadorRuaCep { get; set; }
        public string PagadorRuaUf { get; set; }
        public string PagadorRuaPais { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public DateTime PagamentoRealizadoEm { get; set; }
        public decimal PagamentoValorAcrescimos { get; set; }
        public decimal PagamentoValorDesconto { get; set; }
        public decimal PagamentoValorPago { get; set; }
        public decimal PagamentoValorTaxa { get; set; }
        public string PagamentoStatus { get; set; }
        public int PagadorPessoaId { get; set; }
        public DateTime DescontoValidoAte { get; set; }
        public decimal DescontoValor { get; set; }
        public string Gateway { get; set; }
        public string ClienteOrigem { get; set; }

        public virtual TransacaoCobranca TransacaoCobranca { get; set; }
        public virtual ICollection<TransacaoItem> TransacaoItems { get; set; }
    }
}
