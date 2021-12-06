using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class TransacaoCobranca
    {
        public string Tipo { get; set; }
        public string TransacaoGatewayId { get; set; }
        public decimal Valor { get; set; }
        public string MensagemRetorno { get; set; }
        public string BoletoBanco { get; set; }
        public string BoletoCedenteAgencia { get; set; }
        public string BoletoCedenteCodigo { get; set; }
        public string BoletoBeneficiarioNome { get; set; }
        public string BoletoBeneficiarioNomeSocial { get; set; }
        public string BoletoBeneficiarioDocumentoTipo { get; set; }
        public string BoletoBeneficiarioDocumentoNumero { get; set; }
        public string BoletoBeneficiarioRua { get; set; }
        public string BoletoBeneficiarioRuaNumero { get; set; }
        public string BoletoBeneficiarioRuaComplemento { get; set; }
        public string BoletoBeneficiarioRuaBairro { get; set; }
        public string BoletoBeneficiarioRuaCidade { get; set; }
        public string BoletoBeneficiarioRuaCep { get; set; }
        public string BoletoBeneficiarioRuaUf { get; set; }
        public string BoletoBeneficiarioRuaPais { get; set; }
        public string BoletoBeneficiarioClienteNome { get; set; }
        public string BoletoBeneficiarioClienteNomeSocial { get; set; }
        public string BoletoBeneficiarioClienteDocumentoTipo { get; set; }
        public string BoletoBeneficiarioClienteDocumentoNumero { get; set; }
        public string BoletoBeneficiarioClienteRua { get; set; }
        public string BoletoBeneficiarioClienteRuaNumero { get; set; }
        public string BoletoBeneficiarioClienteRuaComplemento { get; set; }
        public string BoletoBeneficiarioClienteRuaBairro { get; set; }
        public string BoletoBeneficiarioClienteRuaCidade { get; set; }
        public string BoletoBeneficiarioClienteRuaCep { get; set; }
        public string BoletoBeneficiarioClienteRuaUf { get; set; }
        public string BoletoBeneficiarioClienteRuaPais { get; set; }
        public string BoletoLocalDePagamento { get; set; }
        public DateTime BoletoVencimento { get; set; }
        public string BoletoNossoNumero { get; set; }
        public string BoletoLinhaDigitavel { get; set; }
        public string BoletoCodigoDeBarras { get; set; }
        public string BoletoInstrucoes { get; set; }
        public string BoletoUrl { get; set; }
        public bool? PermiteImpressao { get; set; }
        public int Id { get; set; }
        public int? TransacaoId { get; set; }

        public virtual Transacao Transacao { get; set; }
    }
}
