using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Cheque
    {
        public Cheque()
        {
            Movimentos = new HashSet<Movimento>();
            RecebimentoFormas = new HashSet<RecebimentoForma>();
            Transferencia = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string ContaBanco { get; set; }
        public string ContaAgencia { get; set; }
        public string ContaNumero { get; set; }
        public string CorrentistaDocumentoTipo { get; set; }
        public string CorrentistaDocumentoNumero { get; set; }
        public string CorrentistaNome { get; set; }
        public DateTime RecebidoEm { get; set; }
        public DateTime DescontarEm { get; set; }
        public DateTime? DescontadoEm { get; set; }
        public DateTime? ConciliadoEm { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public decimal Valor { get; set; }

        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual ICollection<Transferencium> Transferencia { get; set; }
    }
}
