using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TransferenciaRealizadum
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataSaldoDestino { get; set; }
        public DateTime? DataSaldoOrigem { get; set; }
        public string Tipo { get; set; }
        public string TipoForma { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int? OrigemId { get; set; }
        public int? DestinoId { get; set; }
        public string OrigemDescricao { get; set; }
        public string DestinoDescricao { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
    }
}
