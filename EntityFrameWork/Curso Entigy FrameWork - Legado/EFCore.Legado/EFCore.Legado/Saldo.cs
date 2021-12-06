using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Saldo
    {
        public Saldo()
        {
            SaldoFormaCobrancas = new HashSet<SaldoFormaCobranca>();
            TransferenciumSaldoContaDestinos = new HashSet<Transferencium>();
            TransferenciumSaldoContaOrigems = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public int ContaFinanceiraId { get; set; }
        public DateTime Dia { get; set; }
        public int? OperadorId { get; set; }
        public string Status { get; set; }
        public DateTime Quando { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual ICollection<SaldoFormaCobranca> SaldoFormaCobrancas { get; set; }
        public virtual ICollection<Transferencium> TransferenciumSaldoContaDestinos { get; set; }
        public virtual ICollection<Transferencium> TransferenciumSaldoContaOrigems { get; set; }
    }
}
