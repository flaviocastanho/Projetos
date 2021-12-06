using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class FormaCobranca
    {
        public FormaCobranca()
        {
            Cobrancas = new HashSet<Cobranca>();
            DevolucaoFormas = new HashSet<DevolucaoForma>();
            FaturamentoRecorrentes = new HashSet<FaturamentoRecorrente>();
            Faturas = new HashSet<Fatura>();
            FormaCobrancaIntegracaoOnlines = new HashSet<FormaCobrancaIntegracaoOnline>();
            MeioDePagamentos = new HashSet<MeioDePagamento>();
            Movimentos = new HashSet<Movimento>();
            OperadorFormaCobrancas = new HashSet<OperadorFormaCobranca>();
            RecebimentoFormas = new HashSet<RecebimentoForma>();
            SaldoFormaCobrancas = new HashSet<SaldoFormaCobranca>();
            TransferenciumFormaCobrancaDestinos = new HashSet<Transferencium>();
            TransferenciumFormaCobrancaOrigems = new HashSet<Transferencium>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public int? ContaFinanceiraId { get; set; }
        public string Descricao { get; set; }
        public string IntegracaoApiKey { get; set; }
        public string IntegracaoParceriaId { get; set; }
        public string IntegracaoSocietyCobrancaKey { get; set; }
        public string IntegracaoToken { get; set; }
        public string IntegracaoUriNotificacoes { get; set; }
        public string IntermediarioAgencia { get; set; }
        public string IntermediarioBanco { get; set; }
        public string IntermediarioDocumentoNumero { get; set; }
        public string IntermediarioDocumentoTipo { get; set; }
        public string IntermediarioEnderecoBairro { get; set; }
        public string IntermediarioEnderecoCep { get; set; }
        public string IntermediarioEnderecoCidade { get; set; }
        public string IntermediarioEnderecoComplemento { get; set; }
        public string IntermediarioEnderecoNumero { get; set; }
        public string IntermediarioEnderecoPais { get; set; }
        public string IntermediarioEnderecoRua { get; set; }
        public string IntermediarioEnderecoUf { get; set; }
        public string IntermediarioNome { get; set; }
        public string IntermediarioNomeSocial { get; set; }
        public string IntermediarioNumeroConta { get; set; }
        public int LiquidezAposDias { get; set; }
        public string Parceiro { get; set; }
        public string TipoCobranca { get; set; }
        public string TipoCobrancaRecorrenteDias { get; set; }
        public string Especializacao { get; set; }
        public int TaxaPlanoContaId { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool Excluido { get; set; }
        public int? AdquirenteId { get; set; }
        public string BandeirasNegadas { get; set; }
        public bool? PermiteImpressao { get; set; }
        public bool? ExigeEnderecoPagador { get; set; }
        public DateTime DataCadastro { get; set; }
        public string IntegracaoModo { get; set; }

        public virtual Adquirente Adquirente { get; set; }
        public virtual ContaFinanceira ContaFinanceira { get; set; }
        public virtual ICollection<Cobranca> Cobrancas { get; set; }
        public virtual ICollection<DevolucaoForma> DevolucaoFormas { get; set; }
        public virtual ICollection<FaturamentoRecorrente> FaturamentoRecorrentes { get; set; }
        public virtual ICollection<Fatura> Faturas { get; set; }
        public virtual ICollection<FormaCobrancaIntegracaoOnline> FormaCobrancaIntegracaoOnlines { get; set; }
        public virtual ICollection<MeioDePagamento> MeioDePagamentos { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<OperadorFormaCobranca> OperadorFormaCobrancas { get; set; }
        public virtual ICollection<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual ICollection<SaldoFormaCobranca> SaldoFormaCobrancas { get; set; }
        public virtual ICollection<Transferencium> TransferenciumFormaCobrancaDestinos { get; set; }
        public virtual ICollection<Transferencium> TransferenciumFormaCobrancaOrigems { get; set; }
    }
}
