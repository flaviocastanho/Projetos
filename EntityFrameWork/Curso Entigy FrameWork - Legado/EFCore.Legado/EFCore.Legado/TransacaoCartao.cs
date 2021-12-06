using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TransacaoCartao
    {
        public TransacaoCartao()
        {
            Movimentos = new HashSet<Movimento>();
            RecebimentoFormas = new HashSet<RecebimentoForma>();
            TransacaoCartaoConfirmacaoTransferencia = new HashSet<TransacaoCartaoConfirmacaoTransferencium>();
            Transferencia = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public string Especializacao { get; set; }
        public int? AdquirenteId { get; set; }
        public int? BandeiraId { get; set; }
        public int Parcelamento { get; set; }
        public decimal Valor { get; set; }
        public string Autorizacao { get; set; }
        public DateTime RecebidoEm { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Adquirente Adquirente { get; set; }
        public virtual AdquirenteBandeira Bandeira { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual ICollection<TransacaoCartaoConfirmacaoTransferencium> TransacaoCartaoConfirmacaoTransferencia { get; set; }
        public virtual ICollection<Transferencium> Transferencia { get; set; }
    }
}
