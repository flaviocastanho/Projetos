using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Caixa
    {
        public Caixa()
        {
            CaixaSaldos = new HashSet<CaixaSaldo>();
            TransferenciumCaixaDestinos = new HashSet<Transferencium>();
            TransferenciumCaixaOrigems = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public int OperadorId { get; set; }
        public DateTime Dia { get; set; }
        public string Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Operador Operador { get; set; }
        public virtual ICollection<CaixaSaldo> CaixaSaldos { get; set; }
        public virtual ICollection<Transferencium> TransferenciumCaixaDestinos { get; set; }
        public virtual ICollection<Transferencium> TransferenciumCaixaOrigems { get; set; }
    }
}
