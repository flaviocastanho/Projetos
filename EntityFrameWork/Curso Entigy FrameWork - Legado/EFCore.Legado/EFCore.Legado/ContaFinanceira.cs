using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class ContaFinanceira
    {
        public ContaFinanceira()
        {
            DevolucaoFormas = new HashSet<DevolucaoForma>();
            FormaCobrancas = new HashSet<FormaCobranca>();
            Movimentos = new HashSet<Movimento>();
            RecebimentoFormas = new HashSet<RecebimentoForma>();
            Saldos = new HashSet<Saldo>();
            TransacaoCartaoConfirmacaoTransferencia = new HashSet<TransacaoCartaoConfirmacaoTransferencium>();
            Transferencia = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string BeneficiarioBanco { get; set; }
        public string BeneficiarioAgencia { get; set; }
        public string BeneficiarioNumeroConta { get; set; }
        public string BeneficiarioNome { get; set; }
        public string BeneficiarioNomeSocial { get; set; }
        public string BeneficiarioDocumentoTipo { get; set; }
        public string BeneficiarioDocumentoNumero { get; set; }
        public string BeneficiarioEnderecoRua { get; set; }
        public string BeneficiarioEnderecoNumero { get; set; }
        public string BeneficiarioEnderecoComplemento { get; set; }
        public string BeneficiarioEnderecoBairro { get; set; }
        public string BeneficiarioEnderecoCidade { get; set; }
        public string BeneficiarioEnderecoUf { get; set; }
        public string BeneficiarioEnderecoCep { get; set; }
        public string BeneficiarioEnderecoPais { get; set; }
        public string Intermediario { get; set; }
        public int Especializacao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }
        public bool? UtilizarDadosClubeParaBeneficiario { get; set; }
        public DateTime DataCadastro { get; set; }
        public string BeneficiarioCodigo { get; set; }

        public virtual ICollection<DevolucaoForma> DevolucaoFormas { get; set; }
        public virtual ICollection<FormaCobranca> FormaCobrancas { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual ICollection<Saldo> Saldos { get; set; }
        public virtual ICollection<TransacaoCartaoConfirmacaoTransferencium> TransacaoCartaoConfirmacaoTransferencia { get; set; }
        public virtual ICollection<Transferencium> Transferencia { get; set; }
    }
}
