using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContratosServicoDaPessoa
    {
        public int ContratoId { get; set; }
        public string Descricao { get; set; }
        public int ModeloContratoId { get; set; }
        public int ContratanteId { get; set; }
        public string ContratanteNome { get; set; }
        public int BeneficiarioId { get; set; }
        public string BeneficiarioNome { get; set; }
        public int PagadorId { get; set; }
        public string PagadorNome { get; set; }
        public string PagadorFoto { get; set; }
        public int PagadorMeioDePagamentoId { get; set; }
        public string PagadorFormaCobrancaDescricao { get; set; }
        public string PagadorFormaCobrancaTipo { get; set; }
        public int PagadorMeioDePagamentoDia { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime Quando { get; set; }
        public string SituacaoContrato { get; set; }
        public string PosicaoContrato { get; set; }
        public string SituacaoFinanceira { get; set; }
        public string TipoAssociacao { get; set; }
    }
}
