using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCore.Legado
{
    public partial class Society360_DEVContext : DbContext
    {
        public Society360_DEVContext()
        {
        }

        public Society360_DEVContext(DbContextOptions<Society360_DEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acao> Acaos { get; set; }
        public virtual DbSet<AcaoPerfil> AcaoPerfils { get; set; }
        public virtual DbSet<AcaoPo> AcaoPos { get; set; }
        public virtual DbSet<AcaoPo1> AcaoPos1 { get; set; }
        public virtual DbSet<Adquirente> Adquirentes { get; set; }
        public virtual DbSet<AdquirenteBandeira> AdquirenteBandeiras { get; set; }
        public virtual DbSet<Arma> Armas { get; set; }
        public virtual DbSet<ArmaDocumento> ArmaDocumentos { get; set; }
        public virtual DbSet<Caixa> Caixas { get; set; }
        public virtual DbSet<CaixaSaldo> CaixaSaldos { get; set; }
        public virtual DbSet<CampoCustomizado> CampoCustomizados { get; set; }
        public virtual DbSet<CampoCustomizadoOpcao> CampoCustomizadoOpcaos { get; set; }
        public virtual DbSet<Carteira> Carteiras { get; set; }
        public virtual DbSet<CarteiraCodigoDeBarra> CarteiraCodigoDeBarras { get; set; }
        public virtual DbSet<CarteiraHistorico> CarteiraHistoricos { get; set; }
        public virtual DbSet<CelularesCadastrado> CelularesCadastrados { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<ChequeComLocalizacaoAtual> ChequeComLocalizacaoAtuals { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClienteMarcador> ClienteMarcadors { get; set; }
        public virtual DbSet<Clube> Clubes { get; set; }
        public virtual DbSet<CnpjsAtivo> CnpjsAtivos { get; set; }
        public virtual DbSet<Cobranca> Cobrancas { get; set; }
        public virtual DbSet<CodigoDeBarra> CodigoDeBarras { get; set; }
        public virtual DbSet<ConfiguracaoClubeFuncionalidade> ConfiguracaoClubeFuncionalidades { get; set; }
        public virtual DbSet<ConfiguracaoClubeGrupoMenu> ConfiguracaoClubeGrupoMenus { get; set; }
        public virtual DbSet<ConfiguracaoClubeOpcaoMenu> ConfiguracaoClubeOpcaoMenus { get; set; }
        public virtual DbSet<ContaDesconto> ContaDescontos { get; set; }
        public virtual DbSet<ContaFinanceira> ContaFinanceiras { get; set; }
        public virtual DbSet<ContaFinanceiraSaldoAcao> ContaFinanceiraSaldoAcaos { get; set; }
        public virtual DbSet<ContaFinanceriaPorFormaCobranca> ContaFinanceriaPorFormaCobrancas { get; set; }
        public virtual DbSet<ContaPagamento> ContaPagamentos { get; set; }
        public virtual DbSet<ContaPagamentoDesconto> ContaPagamentoDescontos { get; set; }
        public virtual DbSet<ContasAreceberParaRecebimento> ContasAreceberParaRecebimentos { get; set; }
        public virtual DbSet<ContasParaFaturar> ContasParaFaturars { get; set; }
        public virtual DbSet<ContasParaListagem> ContasParaListagems { get; set; }
        public virtual DbSet<Contrato> Contratos { get; set; }
        public virtual DbSet<ContratoHistorico> ContratoHistoricos { get; set; }
        public virtual DbSet<ContratoTaxa> ContratoTaxas { get; set; }
        public virtual DbSet<ContratoTipo> ContratoTipos { get; set; }
        public virtual DbSet<ContratosComDividasEmAbertoParaRevisaoAdimplencium> ContratosComDividasEmAbertoParaRevisaoAdimplencia { get; set; }
        public virtual DbSet<ContratosComTaxaVigente> ContratosComTaxaVigentes { get; set; }
        public virtual DbSet<ContratosServicoDaPessoa> ContratosServicoDaPessoas { get; set; }
        public virtual DbSet<ContratosSociaisDaPessoa> ContratosSociaisDaPessoas { get; set; }
        public virtual DbSet<Contum> Conta { get; set; }
        public virtual DbSet<CpfsAtivo> CpfsAtivos { get; set; }
        public virtual DbSet<DependentesSociai> DependentesSociais { get; set; }
        public virtual DbSet<Devolucao> Devolucaos { get; set; }
        public virtual DbSet<Devolucao1> Devolucaos1 { get; set; }
        public virtual DbSet<DevolucaoForma> DevolucaoFormas { get; set; }
        public virtual DbSet<DigitaisCadastrada> DigitaisCadastradas { get; set; }
        public virtual DbSet<Direito> Direitos { get; set; }
        public virtual DbSet<DireitoGrupo> DireitoGrupos { get; set; }
        public virtual DbSet<DocumentosAtivo> DocumentosAtivos { get; set; }
        public virtual DbSet<EmailsCadastrado> EmailsCadastrados { get; set; }
        public virtual DbSet<Estorno> Estornos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Fatura> Faturas { get; set; }
        public virtual DbSet<FaturaCobranca> FaturaCobrancas { get; set; }
        public virtual DbSet<FaturaCobrancaRealizadum> FaturaCobrancaRealizada { get; set; }
        public virtual DbSet<FaturaControle> FaturaControles { get; set; }
        public virtual DbSet<FaturaDetalhe> FaturaDetalhes { get; set; }
        public virtual DbSet<FaturaItem> FaturaItems { get; set; }
        public virtual DbSet<FaturamentoRecorrente> FaturamentoRecorrentes { get; set; }
        public virtual DbSet<FaturasAprovadasListagem> FaturasAprovadasListagems { get; set; }
        public virtual DbSet<Fila> Filas { get; set; }
        public virtual DbSet<FormaCobranca> FormaCobrancas { get; set; }
        public virtual DbSet<FormaCobrancaEmUso> FormaCobrancaEmUsos { get; set; }
        public virtual DbSet<FormaCobrancaIntegracaoOnline> FormaCobrancaIntegracaoOnlines { get; set; }
        public virtual DbSet<FormasCobrancaPorOperador> FormasCobrancaPorOperadors { get; set; }
        public virtual DbSet<GrupoTaxa> GrupoTaxas { get; set; }
        public virtual DbSet<GrupoTaxaAdimplencium> GrupoTaxaAdimplencia { get; set; }
        public virtual DbSet<IntegracaoOnline> IntegracaoOnlines { get; set; }
        public virtual DbSet<Lancamento> Lancamentos { get; set; }
        public virtual DbSet<Layout> Layouts { get; set; }
        public virtual DbSet<Liquidacao> Liquidacaos { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Lugar> Lugars { get; set; }
        public virtual DbSet<Marcador> Marcadors { get; set; }
        public virtual DbSet<MeioDePagamento> MeioDePagamentos { get; set; }
        public virtual DbSet<ModeloContrato> ModeloContratos { get; set; }
        public virtual DbSet<ModeloContratoRegraBeneficiario> ModeloContratoRegraBeneficiarios { get; set; }
        public virtual DbSet<ModeloContratoRegraDependente> ModeloContratoRegraDependentes { get; set; }
        public virtual DbSet<ModeloContratoSuperiorPermitido> ModeloContratoSuperiorPermitidos { get; set; }
        public virtual DbSet<ModeloContratoTaxa> ModeloContratoTaxas { get; set; }
        public virtual DbSet<ModeloDeCarteira> ModeloDeCarteiras { get; set; }
        public virtual DbSet<ModeloDeCarteiraTemplate> ModeloDeCarteiraTemplates { get; set; }
        public virtual DbSet<ModelosDeContratosServicosDisponiveisParaContratacao> ModelosDeContratosServicosDisponiveisParaContratacaos { get; set; }
        public virtual DbSet<ModelosDeContratosSociaisDisponiveisParaContratacao> ModelosDeContratosSociaisDisponiveisParaContratacaos { get; set; }
        public virtual DbSet<Movimento> Movimentos { get; set; }
        public virtual DbSet<Notificacao> Notificacaos { get; set; }
        public virtual DbSet<Ocorrencium> Ocorrencia { get; set; }
        public virtual DbSet<Operador> Operadors { get; set; }
        public virtual DbSet<OperadorFavorito> OperadorFavoritos { get; set; }
        public virtual DbSet<OperadorFormaCobranca> OperadorFormaCobrancas { get; set; }
        public virtual DbSet<OperadorNotificacao> OperadorNotificacaos { get; set; }
        public virtual DbSet<OperadorPreferencium> OperadorPreferencia { get; set; }
        public virtual DbSet<Pagador> Pagadors { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<PessoaArma> PessoaArmas { get; set; }
        public virtual DbSet<PessoaArmaDocumento> PessoaArmaDocumentos { get; set; }
        public virtual DbSet<PessoaArmaProcesso> PessoaArmaProcessos { get; set; }
        public virtual DbSet<PessoaArmaProcessoEtapa> PessoaArmaProcessoEtapas { get; set; }
        public virtual DbSet<PessoaCampoCustomizado> PessoaCampoCustomizados { get; set; }
        public virtual DbSet<PessoaContato> PessoaContatos { get; set; }
        public virtual DbSet<PessoaDigital> PessoaDigitals { get; set; }
        public virtual DbSet<PessoaDocumento> PessoaDocumentos { get; set; }
        public virtual DbSet<PessoaEndereco> PessoaEnderecos { get; set; }
        public virtual DbSet<PessoaObservacao> PessoaObservacaos { get; set; }
        public virtual DbSet<PessoaProcesso> PessoaProcessos { get; set; }
        public virtual DbSet<PessoaProcessoEtapa> PessoaProcessoEtapas { get; set; }
        public virtual DbSet<PessoaSample> PessoaSamples { get; set; }
        public virtual DbSet<PlanoContum> PlanoConta { get; set; }
        public virtual DbSet<Processo> Processos { get; set; }
        public virtual DbSet<ProcessoEtapa> ProcessoEtapas { get; set; }
        public virtual DbSet<ProcessoEtapaDocumentosObrigatorio> ProcessoEtapaDocumentosObrigatorios { get; set; }
        public virtual DbSet<Recebimento> Recebimentos { get; set; }
        public virtual DbSet<RecebimentoDetalhe> RecebimentoDetalhes { get; set; }
        public virtual DbSet<RecebimentoEstorno> RecebimentoEstornos { get; set; }
        public virtual DbSet<RecebimentoForma> RecebimentoFormas { get; set; }
        public virtual DbSet<RecebimentoItem> RecebimentoItems { get; set; }
        public virtual DbSet<RecebimentoItemDesconto> RecebimentoItemDescontos { get; set; }
        public virtual DbSet<RecebimentoListagemResumo> RecebimentoListagemResumos { get; set; }
        public virtual DbSet<ReciboLiquidacao> ReciboLiquidacaos { get; set; }
        public virtual DbSet<ReciboLiquidacoesOperador> ReciboLiquidacoesOperadors { get; set; }
        public virtual DbSet<Relacionamento> Relacionamentos { get; set; }
        public virtual DbSet<ResumoFinanceiro> ResumoFinanceiros { get; set; }
        public virtual DbSet<Saldo> Saldos { get; set; }
        public virtual DbSet<SaldoDiarioContum> SaldoDiarioConta { get; set; }
        public virtual DbSet<SaldoFormaCobranca> SaldoFormaCobrancas { get; set; }
        public virtual DbSet<Setor> Setors { get; set; }
        public virtual DbSet<Society360ContextoMigration> Society360ContextoMigrations { get; set; }
        public virtual DbSet<Taxa> Taxas { get; set; }
        public virtual DbSet<TaxaValor> TaxaValors { get; set; }
        public virtual DbSet<TaxaValorRegraDesconto> TaxaValorRegraDescontos { get; set; }
        public virtual DbSet<TaxaValorVigente> TaxaValorVigentes { get; set; }
        public virtual DbSet<TelefonesCadastrado> TelefonesCadastrados { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TemplateComunicacao> TemplateComunicacaos { get; set; }
        public virtual DbSet<TemplateComunicacaoCampo> TemplateComunicacaoCampos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<Transacao> Transacaos { get; set; }
        public virtual DbSet<TransacaoCartao> TransacaoCartaos { get; set; }
        public virtual DbSet<TransacaoCartaoConfirmacaoTransferencium> TransacaoCartaoConfirmacaoTransferencia { get; set; }
        public virtual DbSet<TransacaoCobranca> TransacaoCobrancas { get; set; }
        public virtual DbSet<TransacaoItem> TransacaoItems { get; set; }
        public virtual DbSet<TransferenciaRealizadum> TransferenciaRealizada { get; set; }
        public virtual DbSet<Transferencium> Transferencia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = society-banco-dados.brazilsouth.cloudapp.azure.com, 5050;Initial Catalog=Society360_DEV;User ID=suporte;Password=STI000Society;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Acao>(entity =>
            {
                entity.ToTable("Acao", "Autorizacao");

                entity.HasIndex(e => e.DireitoId, "IX_Acao_DireitoId");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Direito)
                    .WithMany(p => p.Acaos)
                    .HasForeignKey(d => d.DireitoId);
            });

            modelBuilder.Entity<AcaoPerfil>(entity =>
            {
                entity.ToTable("AcaoPerfil", "Autorizacao");

                entity.HasIndex(e => e.AcaoId, "IX_AcaoPerfil_AcaoId");

                entity.HasIndex(e => e.PerfilId, "IX_AcaoPerfil_PerfilId");

                entity.HasOne(d => d.Acao)
                    .WithMany(p => p.AcaoPerfils)
                    .HasForeignKey(d => d.AcaoId);

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.AcaoPerfils)
                    .HasForeignKey(d => d.PerfilId);
            });

            modelBuilder.Entity<AcaoPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AcaoPos", "Associados");

                entity.Property(e => e.Comando)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Evento)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Fila)
                    .HasMaxLength(160)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcaoPo1>(entity =>
            {
                entity.ToTable("AcaoPos", "Sistema");

                entity.Property(e => e.Comando)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Contexto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Evento)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Fila)
                    .HasMaxLength(160)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adquirente>(entity =>
            {
                entity.ToTable("Adquirente", "Financeiro");

                entity.HasIndex(e => e.PlanoContaId, "IX_Adquirente_PlanoContaId");

                entity.Property(e => e.CodigoConvenio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RedeAdquirente)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlanoConta)
                    .WithMany(p => p.Adquirentes)
                    .HasForeignKey(d => d.PlanoContaId);
            });

            modelBuilder.Entity<AdquirenteBandeira>(entity =>
            {
                entity.ToTable("AdquirenteBandeira", "Financeiro");

                entity.HasIndex(e => e.AdquirenteId, "IX_AdquirenteBandeira_AdquirenteId");

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Operacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PrevisaoLiquidezConfiguracao).IsUnicode(false);

                entity.Property(e => e.TaxaConfiguracao).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Adquirente)
                    .WithMany(p => p.AdquirenteBandeiras)
                    .HasForeignKey(d => d.AdquirenteId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Arma>(entity =>
            {
                entity.ToTable("Arma", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_Arma_PessoaId");

                entity.Property(e => e.Acabamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Calibre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeDeCarregamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComprimentoDoCano)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Especie)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeRaias)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeSerie)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDeFabricacao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.QuantidadeDeCanos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SentidoDaRaia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeAlma)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeFuncionamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Armas)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<ArmaDocumento>(entity =>
            {
                entity.ToTable("ArmaDocumento", "Sistema");

                entity.HasIndex(e => e.ArmaId, "IX_ArmaDocumento_ArmaId");

                entity.HasIndex(e => e.TipoDocumentoId, "IX_ArmaDocumento_TipoDocumentoId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.ImagemFrente).IsUnicode(false);

                entity.Property(e => e.ImagemVerso).IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoEmissor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Validade).HasColumnType("date");

                entity.HasOne(d => d.Arma)
                    .WithMany(p => p.ArmaDocumentos)
                    .HasForeignKey(d => d.ArmaId);

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.ArmaDocumentos)
                    .HasForeignKey(d => d.TipoDocumentoId);
            });

            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.ToTable("Caixa", "Financeiro");

                entity.HasIndex(e => e.OperadorId, "IX_Caixa_OperadorId");

                entity.Property(e => e.Dia).HasColumnType("date");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Caixas)
                    .HasForeignKey(d => d.OperadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CaixaSaldo>(entity =>
            {
                entity.ToTable("CaixaSaldo", "Financeiro");

                entity.HasIndex(e => e.CaixaId, "IX_CaixaSaldo_CaixaId");

                entity.Property(e => e.Forma)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ValorConfirmado).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorEntradaConfirmar).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorSaidaConfirmar).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Caixa)
                    .WithMany(p => p.CaixaSaldos)
                    .HasForeignKey(d => d.CaixaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<CampoCustomizado>(entity =>
            {
                entity.ToTable("CampoCustomizado", "Sistema");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CampoCustomizadoOpcao>(entity =>
            {
                entity.ToTable("CampoCustomizadoOpcao", "Sistema");

                entity.HasIndex(e => e.CampoCustomizadoId, "IX_CampoCustomizadoOpcao_CampoCustomizadoId");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampoCustomizado)
                    .WithMany(p => p.CampoCustomizadoOpcaos)
                    .HasForeignKey(d => d.CampoCustomizadoId);
            });

            modelBuilder.Entity<Carteira>(entity =>
            {
                entity.ToTable("Carteira", "Associados");

                entity.HasIndex(e => e.ModeloId, "IX_Carteira_ModeloId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.NomeImpresso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaFinal).HasColumnType("datetime");

                entity.Property(e => e.VigenciaInicial).HasColumnType("datetime");

                entity.HasOne(d => d.Modelo)
                    .WithMany(p => p.Carteiras)
                    .HasForeignKey(d => d.ModeloId);
            });

            modelBuilder.Entity<CarteiraCodigoDeBarra>(entity =>
            {
                entity.ToTable("CarteiraCodigoDeBarras", "Associados");

                entity.HasIndex(e => e.CarteiraId, "IX_CarteiraCodigoDeBarras_CarteiraId");

                entity.Property(e => e.CodigoDecimal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoHexadecimal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataGravacao).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carteira)
                    .WithMany(p => p.CarteiraCodigoDeBarras)
                    .HasForeignKey(d => d.CarteiraId);
            });

            modelBuilder.Entity<CarteiraHistorico>(entity =>
            {
                entity.ToTable("CarteiraHistorico", "Associados");

                entity.HasIndex(e => e.CarteiraId, "IX_CarteiraHistorico_CarteiraId");

                entity.Property(e => e.CanalEntrega)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.MotivoCancelamento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoRecolhimento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carteira)
                    .WithMany(p => p.CarteiraHistoricos)
                    .HasForeignKey(d => d.CarteiraId);
            });

            modelBuilder.Entity<CelularesCadastrado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CelularesCadastrados", "Sistema");

                entity.Property(e => e.Celular)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.ToTable("Cheque", "Financeiro");

                entity.Property(e => e.ConciliadoEm).HasColumnType("date");

                entity.Property(e => e.ContaAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaDocumentoTipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DescontadoEm).HasColumnType("date");

                entity.Property(e => e.DescontarEm).HasColumnType("date");

                entity.Property(e => e.Numero)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ChequeComLocalizacaoAtual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChequeComLocalizacaoAtual", "Financeiro");

                entity.Property(e => e.ContaAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContaNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaDocumentoTipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorrentistaNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescontarEm).HasColumnType("date");

                entity.Property(e => e.LocalAtualTipo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OrigemStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Clientes", "CRM");

                entity.Property(e => e.Celular)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClienteMarcador>(entity =>
            {
                entity.ToTable("ClienteMarcador", "CRM");

                entity.HasIndex(e => new { e.MarcadorId, e.PessoaId }, "IX_ClienteMarcador_MarcadorId_PessoaId")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId, "IX_ClienteMarcador_PessoaId");

                entity.HasOne(d => d.Marcador)
                    .WithMany(p => p.ClienteMarcadors)
                    .HasForeignKey(d => d.MarcadorId);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.ClienteMarcadors)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<Clube>(entity =>
            {
                entity.HasKey(e => e.Cnpj);

                entity.ToTable("Clube", "Sistema");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EnderecoUF");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CnpjsAtivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CnpjsAtivos", "Sistema");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cobranca>(entity =>
            {
                entity.ToTable("Cobranca", "Faturamento");

                entity.HasIndex(e => e.BoletoNossoNumero, "IX_Cobranca_BoletoNossoNumero");

                entity.HasIndex(e => e.FaturaId, "IX_Cobranca_FaturaId");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_Cobranca_FormaCobrancaId");

                entity.HasIndex(e => e.TransacaoOnLineId, "IX_Cobranca_TransacaoOnLineId");

                entity.Property(e => e.BoletoLinhaDigitavel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoletoNossoNumero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoletoUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DescontoAntecipacaoValor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Especializacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MensagemSistemaCobranca)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PagamentoDesconto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PagamentoTaxa).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PagamentoValor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransacaoOnLineId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Fatura)
                    .WithMany(p => p.Cobrancas)
                    .HasForeignKey(d => d.FaturaId);

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.Cobrancas)
                    .HasForeignKey(d => d.FormaCobrancaId);
            });

            modelBuilder.Entity<CodigoDeBarra>(entity =>
            {
                entity.ToTable("CodigoDeBarras", "Sistema");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProximoValor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAtual)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracaoClubeFuncionalidade>(entity =>
            {
                entity.ToTable("ConfiguracaoClubeFuncionalidade", "Sistema");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracaoClubeGrupoMenu>(entity =>
            {
                entity.ToTable("ConfiguracaoClubeGrupoMenu", "Sistema");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Icone)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MenuInferiorFixo)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracaoClubeOpcaoMenu>(entity =>
            {
                entity.ToTable("ConfiguracaoClubeOpcaoMenu", "Sistema");

                entity.HasIndex(e => e.ConfiguracaoClubeGrupoMenuId, "IX_ConfiguracaoClubeOpcaoMenu_ConfiguracaoClubeGrupoMenuId");

                entity.HasIndex(e => e.FuncionalidadeId, "IX_ConfiguracaoClubeOpcaoMenu_FuncionalidadeId")
                    .IsUnique();

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Rota)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConfiguracaoClubeGrupoMenu)
                    .WithMany(p => p.ConfiguracaoClubeOpcaoMenus)
                    .HasForeignKey(d => d.ConfiguracaoClubeGrupoMenuId);

                entity.HasOne(d => d.Funcionalidade)
                    .WithOne(p => p.ConfiguracaoClubeOpcaoMenu)
                    .HasForeignKey<ConfiguracaoClubeOpcaoMenu>(d => d.FuncionalidadeId);
            });

            modelBuilder.Entity<ContaDesconto>(entity =>
            {
                entity.ToTable("ContaDesconto", "Financeiro");

                entity.HasIndex(e => e.ContaId, "IX_ContaDesconto_ContaId");

                entity.HasIndex(e => e.PlanoContaId, "IX_ContaDesconto_PlanoContaId");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegraAntecipacao).IsUnicode(false);

                entity.Property(e => e.RegraAntecipacaoId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Conta)
                    .WithMany(p => p.ContaDescontos)
                    .HasForeignKey(d => d.ContaId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.PlanoConta)
                    .WithMany(p => p.ContaDescontos)
                    .HasForeignKey(d => d.PlanoContaId);
            });

            modelBuilder.Entity<ContaFinanceira>(entity =>
            {
                entity.ToTable("ContaFinanceira", "Financeiro");

                entity.Property(e => e.BeneficiarioAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BeneficiarioEnderecoUF");

                entity.Property(e => e.BeneficiarioNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNomeSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNumeroConta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Intermediario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UtilizarDadosClubeParaBeneficiario)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<ContaFinanceiraSaldoAcao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContaFinanceiraSaldoAcao", "Financeiro");

                entity.Property(e => e.Acao)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Dia).HasColumnType("date");
            });

            modelBuilder.Entity<ContaFinanceriaPorFormaCobranca>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContaFinanceriaPorFormaCobranca", "Financeiro");
            });

            modelBuilder.Entity<ContaPagamento>(entity =>
            {
                entity.ToTable("ContaPagamento", "Financeiro");

                entity.HasIndex(e => e.CancelamentoOperadorId, "IX_ContaPagamento_CancelamentoOperadorId");

                entity.HasIndex(e => e.ContaId, "IX_ContaPagamento_ContaId");

                entity.Property(e => e.CancelamentoData).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.CancelamentoRealizado)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.JurosValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MultaValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CancelamentoOperador)
                    .WithMany(p => p.ContaPagamentos)
                    .HasForeignKey(d => d.CancelamentoOperadorId);

                entity.HasOne(d => d.Conta)
                    .WithMany(p => p.ContaPagamentos)
                    .HasForeignKey(d => d.ContaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ContaPagamentoDesconto>(entity =>
            {
                entity.ToTable("ContaPagamentoDesconto", "Financeiro");

                entity.HasIndex(e => e.PagamentoId, "IX_ContaPagamentoDesconto_PagamentoId");

                entity.HasIndex(e => e.PlanoContaId, "IX_ContaPagamentoDesconto_PlanoContaId");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Pagamento)
                    .WithMany(p => p.ContaPagamentoDescontos)
                    .HasForeignKey(d => d.PagamentoId);

                entity.HasOne(d => d.PlanoConta)
                    .WithMany(p => p.ContaPagamentoDescontos)
                    .HasForeignKey(d => d.PlanoContaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContasAreceberParaRecebimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContasAReceberParaRecebimento", "Financeiro");

                entity.Property(e => e.ContratoBeneficiarioNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ContratoDescricao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Vencimento).HasColumnType("date");

                entity.Property(e => e.VencimentoReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContasParaFaturar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContasParaFaturar", "Financeiro");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Vencimento).HasColumnType("date");
            });

            modelBuilder.Entity<ContasParaListagem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContasParaListagem", "Financeiro");

                entity.Property(e => e.ContratoBeneficiarioNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ContratoContratanteNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ContratoDescricao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoNumero)
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoPagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DevedorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vencimento).HasColumnType("date");

                entity.Property(e => e.VencimentoReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.ToTable("Contrato", "Associados");

                entity.HasIndex(e => e.BeneficiarioId, "IX_Contrato_BeneficiarioId");

                entity.HasIndex(e => e.ContratanteId, "IX_Contrato_ContratanteId");

                entity.HasIndex(e => e.MeioDePagamentoId, "IX_Contrato_MeioDePagamentoId");

                entity.HasIndex(e => e.ModeloDeContratoId, "IX_Contrato_ModeloDeContratoId");

                entity.HasIndex(e => e.Numero, "IX_Contrato_Numero")
                    .IsUnique();

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoFinanceira)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Beneficiario)
                    .WithMany(p => p.ContratoBeneficiarios)
                    .HasForeignKey(d => d.BeneficiarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contratante)
                    .WithMany(p => p.ContratoContratantes)
                    .HasForeignKey(d => d.ContratanteId);

                entity.HasOne(d => d.MeioDePagamento)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.MeioDePagamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModeloDeContrato)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.ModeloDeContratoId);
            });

            modelBuilder.Entity<ContratoHistorico>(entity =>
            {
                entity.ToTable("ContratoHistorico", "Associados");

                entity.HasIndex(e => e.ContratoId, "IX_ContratoHistorico_ContratoId");

                entity.HasIndex(e => e.OcorrenciaId, "IX_ContratoHistorico_OcorrenciaId");

                entity.HasIndex(e => e.OperadorId, "IX_ContratoHistorico_OperadorId");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Contrato)
                    .WithMany(p => p.ContratoHistoricos)
                    .HasForeignKey(d => d.ContratoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Ocorrencia)
                    .WithMany(p => p.ContratoHistoricos)
                    .HasForeignKey(d => d.OcorrenciaId);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.ContratoHistoricos)
                    .HasForeignKey(d => d.OperadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContratoTaxa>(entity =>
            {
                entity.ToTable("ContratoTaxa", "Associados");

                entity.HasIndex(e => e.ContratoId, "IX_ContratoTaxa_ContratoId");

                entity.HasIndex(e => e.TaxaId, "IX_ContratoTaxa_TaxaId");

                entity.HasOne(d => d.Contrato)
                    .WithMany(p => p.ContratoTaxas)
                    .HasForeignKey(d => d.ContratoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Taxa)
                    .WithMany(p => p.ContratoTaxas)
                    .HasForeignKey(d => d.TaxaId);
            });

            modelBuilder.Entity<ContratoTipo>(entity =>
            {
                entity.HasKey(e => e.ContratoId);

                entity.ToTable("ContratoTipo", "Associados");

                entity.Property(e => e.ContratoId).ValueGeneratedNever();

                entity.Property(e => e.Categoria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Classificacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAssociacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Contrato)
                    .WithOne(p => p.ContratoTipo)
                    .HasForeignKey<ContratoTipo>(d => d.ContratoId);
            });

            modelBuilder.Entity<ContratosComDividasEmAbertoParaRevisaoAdimplencium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContratosComDividasEmAbertoParaRevisaoAdimplencia", "Associados");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimento).HasColumnType("date");
            });

            modelBuilder.Entity<ContratosComTaxaVigente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContratosComTaxaVigente", "Associados");

                entity.Property(e => e.BeneficiarioNome)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoTaxaDescricao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoFinanceira)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxaDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxaValorBase).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ContratosServicoDaPessoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContratosServicoDaPessoa", "Associados");

                entity.Property(e => e.BeneficiarioNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ContratanteNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFormaCobrancaDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFormaCobrancaTipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFoto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.PosicaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoFinanceira)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAssociacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContratosSociaisDaPessoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContratosSociaisDaPessoa", "Associados");

                entity.Property(e => e.BeneficiarioNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ContratanteNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ContratoTitularDescricao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFormaCobrancaDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFormaCobrancaTipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorFoto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.PosicaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelacionamentoComTitular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoFinanceira)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAssociacao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TitularFoto)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TitularNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");
            });

            modelBuilder.Entity<Contum>(entity =>
            {
                entity.ToTable("Conta", "Financeiro");

                entity.HasIndex(e => e.ContratoId, "IX_Conta_ContratoId");

                entity.HasIndex(e => e.MeioDePagamentoId, "IX_Conta_MeioDePagamentoId");

                entity.HasIndex(e => e.Numero, "IX_Conta_Numero");

                entity.HasIndex(e => e.PessoaId, "IX_Conta_PessoaId");

                entity.HasIndex(e => e.PlanoDeContaId, "IX_Conta_PlanoDeContaId");

                entity.HasIndex(e => new { e.Situacao, e.TaxaId }, "IX_Conta_Situacao");

                entity.HasIndex(e => e.TaxaId, "IX_Conta_TaxaId");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Numero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegraJuros).IsUnicode(false);

                entity.Property(e => e.RegraJurosId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegraMulta).IsUnicode(false);

                entity.Property(e => e.RegraMultaId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vencimento).HasColumnType("date");

                entity.Property(e => e.VencimentoReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contrato)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.ContratoId);

                entity.HasOne(d => d.MeioDePagamento)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.MeioDePagamentoId);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.PessoaId);

                entity.HasOne(d => d.PlanoDeConta)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.PlanoDeContaId);

                entity.HasOne(d => d.Taxa)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.TaxaId);
            });

            modelBuilder.Entity<CpfsAtivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CpfsAtivos", "Sistema");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DependentesSociai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DependentesSociais", "Associados");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPerfil)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.PosicaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Relacionamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoFinanceira)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Devolucao>(entity =>
            {
                entity.ToTable("Devolucao", "Financeiro");

                entity.HasIndex(e => e.OperadorId, "IX_Devolucao_OperadorId");

                entity.HasIndex(e => e.RecebimentoId, "IX_Devolucao_RecebimentoId");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Devolucaos)
                    .HasForeignKey(d => d.OperadorId);

                entity.HasOne(d => d.Recebimento)
                    .WithMany(p => p.Devolucaos)
                    .HasForeignKey(d => d.RecebimentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Devolucao1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Devolucao", "Saldos");

                entity.Property(e => e.FormaCobranca)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Operacao)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ValorTaxa).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<DevolucaoForma>(entity =>
            {
                entity.ToTable("DevolucaoForma", "Financeiro");

                entity.HasIndex(e => e.ContaFinanceiraId, "IX_DevolucaoForma_ContaFinanceiraId");

                entity.HasIndex(e => e.DevolucaoId, "IX_DevolucaoForma_DevolucaoId");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_DevolucaoForma_FormaCobrancaId");

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.DevolucaoFormas)
                    .HasForeignKey(d => d.ContaFinanceiraId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Devolucao)
                    .WithMany(p => p.DevolucaoFormas)
                    .HasForeignKey(d => d.DevolucaoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.DevolucaoFormas)
                    .HasForeignKey(d => d.FormaCobrancaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DigitaisCadastrada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DigitaisCadastradas", "Sistema");

                entity.Property(e => e.Dedo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemDigital).IsUnicode(false);

                entity.Property(e => e.Mao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Direito>(entity =>
            {
                entity.ToTable("Direito", "Autorizacao");

                entity.HasIndex(e => e.DireitoGrupoId, "IX_Direito_DireitoGrupoId");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.DireitoGrupo)
                    .WithMany(p => p.Direitos)
                    .HasForeignKey(d => d.DireitoGrupoId);
            });

            modelBuilder.Entity<DireitoGrupo>(entity =>
            {
                entity.ToTable("DireitoGrupo", "Autorizacao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentosAtivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DocumentosAtivos", "Sistema");

                entity.Property(e => e.Numero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Validade).HasColumnType("date");
            });

            modelBuilder.Entity<EmailsCadastrado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmailsCadastrados", "Sistema");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estorno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Estorno", "Saldos");

                entity.Property(e => e.FormaCobranca)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Operacao)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ValorTaxa).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.ToTable("Evento", "CRM");

                entity.HasIndex(e => e.PessoaId, "IX_Evento_PessoaId");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.PessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Fatura>(entity =>
            {
                entity.ToTable("Fatura", "Faturamento");

                entity.HasIndex(e => e.FaturamentoRecorrenteId, "IX_Fatura_FaturamentoRecorrenteId");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_Fatura_FormaCobrancaId");

                entity.HasIndex(e => e.MeioDePagamentoId, "IX_Fatura_MeioDePagamentoId");

                entity.HasIndex(e => e.PagadorPessoaId, "IX_Fatura_PagadorPessoaId");

                entity.Property(e => e.DataCalculo).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.PagadorDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RegraJuros).IsUnicode(false);

                entity.Property(e => e.RegraJurosId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegraMulta).IsUnicode(false);

                entity.Property(e => e.RegraMultaId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vencimento).HasColumnType("date");

                entity.Property(e => e.VencimentoReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.FaturamentoRecorrente)
                    .WithMany(p => p.Faturas)
                    .HasForeignKey(d => d.FaturamentoRecorrenteId);

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.Faturas)
                    .HasForeignKey(d => d.FormaCobrancaId);

                entity.HasOne(d => d.MeioDePagamento)
                    .WithMany(p => p.Faturas)
                    .HasForeignKey(d => d.MeioDePagamentoId);

                entity.HasOne(d => d.PagadorPessoa)
                    .WithMany(p => p.Faturas)
                    .HasForeignKey(d => d.PagadorPessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<FaturaCobranca>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FaturaCobranca", "CRM");

                entity.Property(e => e.BoletoLinhaDigitavel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoletoUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemDescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PagadorDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VencimentoReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaturaCobrancaRealizadum>(entity =>
            {
                entity.ToTable("FaturaCobrancaRealizada", "Faturamento");

                entity.HasIndex(e => e.CobrancaId, "IX_FaturaCobrancaRealizada_CobrancaId");

                entity.HasIndex(e => e.FaturaId, "IX_FaturaCobrancaRealizada_FaturaId");

                entity.Property(e => e.PagamentoDesconto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PagamentoTaxa).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PagamentoValor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cobranca)
                    .WithMany(p => p.FaturaCobrancaRealizada)
                    .HasForeignKey(d => d.CobrancaId);

                entity.HasOne(d => d.Fatura)
                    .WithMany(p => p.FaturaCobrancaRealizada)
                    .HasForeignKey(d => d.FaturaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FaturaControle>(entity =>
            {
                entity.ToTable("FaturaControle", "Faturamento");

                entity.HasIndex(e => e.CobrancaId, "IX_FaturaControle_CobrancaId");

                entity.HasIndex(e => e.FaturaId, "IX_FaturaControle_FaturaId");

                entity.Property(e => e.Mensagem)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cobranca)
                    .WithMany(p => p.FaturaControles)
                    .HasForeignKey(d => d.CobrancaId);

                entity.HasOne(d => d.Fatura)
                    .WithMany(p => p.FaturaControles)
                    .HasForeignKey(d => d.FaturaId);
            });

            modelBuilder.Entity<FaturaDetalhe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FaturaDetalhe", "Faturamento");

                entity.Property(e => e.BoletoUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemContratoNumero)
                    .HasMaxLength(37)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemDesconto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FaturaItemDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemSituacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaItemValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FaturaStatusDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaStatusOperadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimento).HasColumnType("date");
            });

            modelBuilder.Entity<FaturaItem>(entity =>
            {
                entity.ToTable("FaturaItem", "Faturamento");

                entity.HasIndex(e => e.ContaAreceberId, "IX_FaturaItem_ContaAReceberId");

                entity.HasIndex(e => e.FaturaId, "IX_FaturaItem_FaturaId");

                entity.Property(e => e.ContaAreceberId).HasColumnName("ContaAReceberId");

                entity.Property(e => e.DescontoValidoAte).HasColumnType("date");

                entity.Property(e => e.DescontoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ContaAreceber)
                    .WithMany(p => p.FaturaItems)
                    .HasForeignKey(d => d.ContaAreceberId);

                entity.HasOne(d => d.Fatura)
                    .WithMany(p => p.FaturaItems)
                    .HasForeignKey(d => d.FaturaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FaturamentoRecorrente>(entity =>
            {
                entity.ToTable("FaturamentoRecorrente", "Faturamento");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_FaturamentoRecorrente_FormaCobrancaId");

                entity.Property(e => e.CriadoEm).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.DataCalculoFaturas).HasColumnType("date");

                entity.Property(e => e.DataVencimentoFaturas).HasColumnType("date");

                entity.Property(e => e.FiltroPaganteContratosNaGeracao)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FiltroSituacaoContratosNaGeracao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MetodoParaCobranca)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreparacaoFinalizadaEm).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.PreparacaoIniciadaEm).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.ProcessoId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Referente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VencimentoFinal).HasColumnType("date");

                entity.Property(e => e.VencimentoInicial).HasColumnType("date");

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.FaturamentoRecorrentes)
                    .HasForeignKey(d => d.FormaCobrancaId);
            });

            modelBuilder.Entity<FaturasAprovadasListagem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FaturasAprovadasListagem", "Faturamento");

                entity.Property(e => e.BoletoNossoNumero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoletoUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FaturaStatusOperadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FormaDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormaTipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vencimento).HasColumnType("date");
            });

            modelBuilder.Entity<Fila>(entity =>
            {
                entity.ToTable("Fila", "Mapeamento");

                entity.HasIndex(e => e.SetorId, "IX_Fila_SetorId");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.HasOne(d => d.Setor)
                    .WithMany(p => p.Filas)
                    .HasForeignKey(d => d.SetorId);
            });

            modelBuilder.Entity<FormaCobranca>(entity =>
            {
                entity.ToTable("FormaCobranca", "Financeiro");

                entity.HasIndex(e => e.AdquirenteId, "IX_FormaCobranca_AdquirenteId");

                entity.HasIndex(e => e.ContaFinanceiraId, "IX_FormaCobranca_ContaFinanceiraId");

                entity.Property(e => e.BandeirasNegadas).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExigeEnderecoPagador)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IntegracaoApiKey)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IntegracaoModo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IntegracaoParceriaId)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IntegracaoSocietyCobrancaKey)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IntegracaoToken)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IntegracaoUriNotificacoes)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IntermediarioEnderecoUF");

                entity.Property(e => e.IntermediarioNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioNomeSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediarioNumeroConta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Parceiro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermiteImpressao)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobranca)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobrancaRecorrenteDias).IsUnicode(false);

                entity.HasOne(d => d.Adquirente)
                    .WithMany(p => p.FormaCobrancas)
                    .HasForeignKey(d => d.AdquirenteId);

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.FormaCobrancas)
                    .HasForeignKey(d => d.ContaFinanceiraId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FormaCobrancaEmUso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FormaCobrancaEmUso", "Financeiro");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormaCobrancaIntegracaoOnline>(entity =>
            {
                entity.ToTable("FormaCobrancaIntegracaoOnline", "Financeiro");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_FormaCobrancaIntegracaoOnline_FormaCobrancaId");

                entity.HasIndex(e => e.IntegracaoOnlineId, "IX_FormaCobrancaIntegracaoOnline_IntegracaoOnlineId");

                entity.HasIndex(e => e.PlanoContaTaxaId, "IX_FormaCobrancaIntegracaoOnline_PlanoContaTaxaId");

                entity.Property(e => e.Instrucoes).IsUnicode(false);

                entity.Property(e => e.LocalPagamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PercentualTaxa).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoTaxa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValorFixoTaxa).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.FormaCobrancaIntegracaoOnlines)
                    .HasForeignKey(d => d.FormaCobrancaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IntegracaoOnline)
                    .WithMany(p => p.FormaCobrancaIntegracaoOnlines)
                    .HasForeignKey(d => d.IntegracaoOnlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PlanoContaTaxa)
                    .WithMany(p => p.FormaCobrancaIntegracaoOnlines)
                    .HasForeignKey(d => d.PlanoContaTaxaId);
            });

            modelBuilder.Entity<FormasCobrancaPorOperador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FormasCobrancaPorOperador", "Financeiro");

                entity.Property(e => e.AdquirenteBandeiraOperacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AdquirenteBandeiraTipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AdquirenteNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ContaFinanceiraDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoTaxa>(entity =>
            {
                entity.ToTable("GrupoTaxa", "Associados");

                entity.HasIndex(e => e.PlanoContaDescontoId, "IX_GrupoTaxa_PlanoContaDescontoId");

                entity.HasIndex(e => e.PlanoContaJurosId, "IX_GrupoTaxa_PlanoContaJurosId");

                entity.HasIndex(e => e.PlanoContaSinteticaId, "IX_GrupoTaxa_PlanoContaSinteticaId");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.PermitirLancamentoAvulso)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.PlanoContaDesconto)
                    .WithMany(p => p.GrupoTaxaPlanoContaDescontos)
                    .HasForeignKey(d => d.PlanoContaDescontoId);

                entity.HasOne(d => d.PlanoContaJuros)
                    .WithMany(p => p.GrupoTaxaPlanoContaJuros)
                    .HasForeignKey(d => d.PlanoContaJurosId);

                entity.HasOne(d => d.PlanoContaSintetica)
                    .WithMany(p => p.GrupoTaxaPlanoContaSinteticas)
                    .HasForeignKey(d => d.PlanoContaSinteticaId);
            });

            modelBuilder.Entity<GrupoTaxaAdimplencium>(entity =>
            {
                entity.HasKey(e => e.GrupoTaxaId);

                entity.ToTable("GrupoTaxaAdimplencia", "Associados");

                entity.Property(e => e.GrupoTaxaId).ValueGeneratedNever();

                entity.Property(e => e.Escopo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regra).IsUnicode(false);

                entity.HasOne(d => d.GrupoTaxa)
                    .WithOne(p => p.GrupoTaxaAdimplencium)
                    .HasForeignKey<GrupoTaxaAdimplencium>(d => d.GrupoTaxaId);
            });

            modelBuilder.Entity<IntegracaoOnline>(entity =>
            {
                entity.ToTable("IntegracaoOnline", "Sistema");

                entity.Property(e => e.Credenciais).IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Endpoints).IsUnicode(false);

                entity.Property(e => e.Modo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Parceiro)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.ToTable("Lancamento", "Financeiro");

                entity.HasIndex(e => e.CancelamentoOperadorId, "IX_Lancamento_CancelamentoOperadorId");

                entity.HasIndex(e => e.LiquidacaoId, "IX_Lancamento_LiquidacaoId");

                entity.HasIndex(e => e.LiquidacaoItemId, "IX_Lancamento_LiquidacaoItemId");

                entity.HasIndex(e => e.LiquidacaoMovimentoId, "IX_Lancamento_LiquidacaoMovimentoId");

                entity.HasIndex(e => e.PlanoContaId, "IX_Lancamento_PlanoContaId");

                entity.Property(e => e.CancelamentoData).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.CancelamentoRealizado)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Operacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CancelamentoOperador)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.CancelamentoOperadorId);

                entity.HasOne(d => d.Liquidacao)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.LiquidacaoId);

                entity.HasOne(d => d.LiquidacaoItem)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.LiquidacaoItemId);

                entity.HasOne(d => d.LiquidacaoMovimento)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.LiquidacaoMovimentoId);

                entity.HasOne(d => d.PlanoConta)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.PlanoContaId);
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.ToTable("Layout", "Sistema");

                entity.Property(e => e.CorLinks)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorPrimaria)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorSecundaria)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Favicon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LogoExterno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LogoInterno)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Liquidacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Liquidacao", "Saldos");

                entity.Property(e => e.FormaCobranca)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ValorTaxa).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Local>(entity =>
            {
                entity.ToTable("Local", "Mapeamento");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.ToTable("Lugar", "Mapeamento");

                entity.HasIndex(e => e.FilaId, "IX_Lugar_FilaId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Numero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Comum')");

                entity.HasOne(d => d.Fila)
                    .WithMany(p => p.Lugars)
                    .HasForeignKey(d => d.FilaId);
            });

            modelBuilder.Entity<Marcador>(entity =>
            {
                entity.ToTable("Marcador", "CRM");

                entity.Property(e => e.Cor)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Especializacao).IsRequired();

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeioDePagamento>(entity =>
            {
                entity.ToTable("MeioDePagamento", "Faturamento");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_MeioDePagamento_FormaCobrancaId");

                entity.HasIndex(e => e.PagadorPessoaId, "IX_MeioDePagamento_PagadorPessoaId");

                entity.HasIndex(e => e.PessoaId, "IX_MeioDePagamento_PessoaId");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000Z')");

                entity.Property(e => e.DocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoTipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.MeioDePagamentos)
                    .HasForeignKey(d => d.FormaCobrancaId);

                entity.HasOne(d => d.PagadorPessoa)
                    .WithMany(p => p.MeioDePagamentoPagadorPessoas)
                    .HasForeignKey(d => d.PagadorPessoaId);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.MeioDePagamentoPessoas)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<ModeloContrato>(entity =>
            {
                entity.ToTable("ModeloContrato", "Associados");

                entity.HasIndex(e => e.ModeloCarteiraId, "IX_ModeloContrato_ModeloCarteiraId");

                entity.HasIndex(e => e.OcorrenciaId, "IX_ModeloContrato_OcorrenciaId");

                entity.HasIndex(e => e.TemplateTermoAdesaoId, "IX_ModeloContrato_TemplateTermoAdesaoId");

                entity.Property(e => e.CategoriaEstatutaria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RegraValidade).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPessoaBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModeloCarteira)
                    .WithMany(p => p.ModeloContratos)
                    .HasForeignKey(d => d.ModeloCarteiraId);

                entity.HasOne(d => d.Ocorrencia)
                    .WithMany(p => p.ModeloContratos)
                    .HasForeignKey(d => d.OcorrenciaId);

                entity.HasOne(d => d.TemplateTermoAdesao)
                    .WithMany(p => p.ModeloContratos)
                    .HasForeignKey(d => d.TemplateTermoAdesaoId);
            });

            modelBuilder.Entity<ModeloContratoRegraBeneficiario>(entity =>
            {
                entity.ToTable("ModeloContratoRegraBeneficiario", "Associados");

                entity.HasIndex(e => e.ModeloContratoId, "IX_ModeloContratoRegraBeneficiario_ModeloContratoId");

                entity.Property(e => e.RegraBeneficiarioId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.ModeloContrato)
                    .WithMany(p => p.ModeloContratoRegraBeneficiarios)
                    .HasForeignKey(d => d.ModeloContratoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ModeloContratoRegraDependente>(entity =>
            {
                entity.ToTable("ModeloContratoRegraDependente", "Associados");

                entity.HasIndex(e => e.ModeloContratoId, "IX_ModeloContratoRegraDependente_ModeloContratoId");

                entity.HasIndex(e => e.RelacionamentoId, "IX_ModeloContratoRegraDependente_RelacionamentoId");

                entity.Property(e => e.RegraDependenteId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegraDependenteValor).IsUnicode(false);

                entity.HasOne(d => d.ModeloContrato)
                    .WithMany(p => p.ModeloContratoRegraDependentes)
                    .HasForeignKey(d => d.ModeloContratoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Relacionamento)
                    .WithMany(p => p.ModeloContratoRegraDependentes)
                    .HasForeignKey(d => d.RelacionamentoId);
            });

            modelBuilder.Entity<ModeloContratoSuperiorPermitido>(entity =>
            {
                entity.ToTable("ModeloContratoSuperiorPermitido", "Associados");

                entity.HasIndex(e => e.ModeloContratoId, "IX_ModeloContratoSuperiorPermitido_ModeloContratoId");

                entity.HasOne(d => d.ModeloContrato)
                    .WithMany(p => p.ModeloContratoSuperiorPermitidos)
                    .HasForeignKey(d => d.ModeloContratoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ModeloContratoTaxa>(entity =>
            {
                entity.ToTable("ModeloContratoTaxa", "Associados");

                entity.HasIndex(e => e.ModeloContratoId, "IX_ModeloContratoTaxa_ModeloContratoId");

                entity.HasIndex(e => e.TaxaId, "IX_ModeloContratoTaxa_TaxaId");

                entity.HasOne(d => d.ModeloContrato)
                    .WithMany(p => p.ModeloContratoTaxas)
                    .HasForeignKey(d => d.ModeloContratoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Taxa)
                    .WithMany(p => p.ModeloContratoTaxas)
                    .HasForeignKey(d => d.TaxaId);
            });

            modelBuilder.Entity<ModeloDeCarteira>(entity =>
            {
                entity.ToTable("ModeloDeCarteira", "Associados");

                entity.HasIndex(e => e.ModeloCarteiraTemplateId, "IX_ModeloDeCarteira_ModeloCarteiraTemplateId");

                entity.HasIndex(e => e.TaxaId, "IX_ModeloDeCarteira_TaxaId");

                entity.Property(e => e.ImagemDeFundoFrente).IsUnicode(false);

                entity.Property(e => e.ImagemDeFundoVerso).IsUnicode(false);

                entity.Property(e => e.OpcaoDeCancelamentoDasViasAnteriores)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpcaoDeImpressao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpcaoDePagamento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegraValidade).IsUnicode(false);

                entity.HasOne(d => d.ModeloCarteiraTemplate)
                    .WithMany(p => p.ModeloDeCarteiras)
                    .HasForeignKey(d => d.ModeloCarteiraTemplateId);

                entity.HasOne(d => d.Taxa)
                    .WithMany(p => p.ModeloDeCarteiras)
                    .HasForeignKey(d => d.TaxaId);
            });

            modelBuilder.Entity<ModeloDeCarteiraTemplate>(entity =>
            {
                entity.ToTable("ModeloDeCarteiraTemplate", "Associados");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imagem).IsUnicode(false);
            });

            modelBuilder.Entity<ModelosDeContratosServicosDisponiveisParaContratacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ModelosDeContratosServicosDisponiveisParaContratacao", "Associados");
            });

            modelBuilder.Entity<ModelosDeContratosSociaisDisponiveisParaContratacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ModelosDeContratosSociaisDisponiveisParaContratacao", "Associados");

                entity.Property(e => e.TipoBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movimento>(entity =>
            {
                entity.ToTable("Movimento", "Financeiro");

                entity.HasIndex(e => e.ChequeId, "IX_Movimento_ChequeId");

                entity.HasIndex(e => e.ContaFinanceiraId, "IX_Movimento_ContaFinanceiraId");

                entity.HasIndex(e => e.DevolucaoId, "IX_Movimento_DevolucaoId");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_Movimento_FormaCobrancaId");

                entity.HasIndex(e => e.OperadorId, "IX_Movimento_OperadorId");

                entity.HasIndex(e => e.RecebimentoId, "IX_Movimento_RecebimentoId");

                entity.HasIndex(e => e.TransacaoId, "IX_Movimento_TransacaoId");

                entity.Property(e => e.CancelamentoQuando).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.CancelamentoRealizado)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FormaCobranca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorTaxa).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Cheque)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.ChequeId);

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.ContaFinanceiraId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Devolucao)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.DevolucaoId);

                entity.HasOne(d => d.FormaCobrancaNavigation)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.FormaCobrancaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.OperadorId);

                entity.HasOne(d => d.Recebimento)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.RecebimentoId);

                entity.HasOne(d => d.Transacao)
                    .WithMany(p => p.Movimentos)
                    .HasForeignKey(d => d.TransacaoId);
            });

            modelBuilder.Entity<Notificacao>(entity =>
            {
                entity.ToTable("Notificacao", "CRM");

                entity.HasIndex(e => e.EventoId, "IX_Notificacao_EventoId");

                entity.Property(e => e.Assunto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campos).IsUnicode(false);

                entity.Property(e => e.DadosEnvioStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatarioEnderecoEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DestinatarioNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemetenteEnderecoEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RemetenteNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Template).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Evento)
                    .WithMany(p => p.Notificacaos)
                    .HasForeignKey(d => d.EventoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Ocorrencium>(entity =>
            {
                entity.ToTable("Ocorrencia", "Associados");

                entity.HasIndex(e => e.Codigo, "IX_Ocorrencia_Codigo")
                    .IsUnique();

                entity.Property(e => e.AfetarContratosDependentes)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('1753-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosicaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Operador>(entity =>
            {
                entity.ToTable("Operador", "Sistema");

                entity.HasIndex(e => e.PerfilId, "IX_Operador_PerfilId");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Foto).IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.Operadors)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<OperadorFavorito>(entity =>
            {
                entity.ToTable("OperadorFavoritos", "Sistema");

                entity.HasIndex(e => e.FuncionalidadeId, "IX_OperadorFavorito_FuncionalidadeId");

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.NomeFavorito)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Funcionalidade)
                    .WithMany(p => p.OperadorFavoritos)
                    .HasForeignKey(d => d.FuncionalidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperadorFavorito_FuncionalidadeId");
            });

            modelBuilder.Entity<OperadorFormaCobranca>(entity =>
            {
                entity.ToTable("OperadorFormaCobranca", "Sistema");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_OperadorFormaCobranca_FormaCobrancaId");

                entity.HasIndex(e => e.OperadorId, "IX_OperadorFormaCobranca_OperadorId");

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.OperadorFormaCobrancas)
                    .HasForeignKey(d => d.FormaCobrancaId);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.OperadorFormaCobrancas)
                    .HasForeignKey(d => d.OperadorId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OperadorNotificacao>(entity =>
            {
                entity.ToTable("OperadorNotificacao", "Sistema");

                entity.HasIndex(e => e.OperadorId, "IX_OperadorNotificacao_OperadorId");

                entity.Property(e => e.AcaoTexto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataLida).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Parametros)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rota)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Texto).IsUnicode(false);

                entity.Property(e => e.TipoRota)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.OperadorNotificacaos)
                    .HasForeignKey(d => d.OperadorId);
            });

            modelBuilder.Entity<OperadorPreferencium>(entity =>
            {
                entity.ToTable("OperadorPreferencia", "Sistema");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Tema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoExibicaoContratos)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pagador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pagador", "Sistema");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoNumero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoTipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Numero)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("Perfil", "Autorizacao");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.ToTable("Pessoa", "Sistema");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(N'1953-01-01T00:00:00')");

                entity.Property(e => e.DataFundacao).HasColumnType("date");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.DocumentoTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoValor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.FotoPerfil)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.NomeSocial)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Fisica')");

                entity.HasOne(d => d.PessoaResponsavel)
                    .WithMany(p => p.InversePessoaResponsavel)
                    .HasForeignKey(d => d.PessoaResponsavelId);
            });

            modelBuilder.Entity<PessoaArma>(entity =>
            {
                entity.ToTable("PessoaArma", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaArma_PessoaId");

                entity.Property(e => e.Acabamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Calibre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeDeCarregamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ComprimentoDoCano)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Especie)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeRaias)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeSerie)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDeFabricacao)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.QuantidadeDeCanos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SentidoDaRaia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeAlma)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeFuncionamento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaArmas)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<PessoaArmaDocumento>(entity =>
            {
                entity.ToTable("PessoaArmaDocumento", "Sistema");

                entity.HasIndex(e => e.ArmaId, "IX_PessoaArmaDocumento_ArmaId");

                entity.HasIndex(e => e.PessoaArmaId, "IX_PessoaArmaDocumento_PessoaArmaId");

                entity.HasIndex(e => e.TipoDocumentoId, "IX_PessoaArmaDocumento_TipoDocumentoId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.ImagemFrente).IsUnicode(false);

                entity.Property(e => e.ImagemVerso).IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoEmissor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Validade).HasColumnType("date");

                entity.HasOne(d => d.Arma)
                    .WithMany(p => p.PessoaArmaDocumentoArmas)
                    .HasForeignKey(d => d.ArmaId);

                entity.HasOne(d => d.PessoaArma)
                    .WithMany(p => p.PessoaArmaDocumentoPessoaArmas)
                    .HasForeignKey(d => d.PessoaArmaId);

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.PessoaArmaDocumentos)
                    .HasForeignKey(d => d.TipoDocumentoId);
            });

            modelBuilder.Entity<PessoaArmaProcesso>(entity =>
            {
                entity.ToTable("PessoaArmaProcesso", "Sistema");

                entity.HasIndex(e => e.ArmaId, "IX_PessoaArmaProcesso_ArmaId");

                entity.HasIndex(e => e.ProcessoId, "IX_PessoaArmaProcesso_ProcessoId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.HasOne(d => d.Arma)
                    .WithMany(p => p.PessoaArmaProcessos)
                    .HasForeignKey(d => d.ArmaId);

                entity.HasOne(d => d.Processo)
                    .WithMany(p => p.PessoaArmaProcessos)
                    .HasForeignKey(d => d.ProcessoId);
            });

            modelBuilder.Entity<PessoaArmaProcessoEtapa>(entity =>
            {
                entity.ToTable("PessoaArmaProcessoEtapa", "Sistema");

                entity.HasIndex(e => e.OperadorConclusao, "IX_PessoaArmaProcessoEtapa_OperadorConclusao");

                entity.HasIndex(e => e.PessoaArmaProcessoId, "IX_PessoaArmaProcessoEtapa_PessoaArmaProcessoId");

                entity.HasIndex(e => e.ProcessoEtapaId, "IX_PessoaArmaProcessoEtapa_ProcessoEtapaId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataDeConclusao).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.HasOne(d => d.OperadorConclusaoNavigation)
                    .WithMany(p => p.PessoaArmaProcessoEtapas)
                    .HasForeignKey(d => d.OperadorConclusao);

                entity.HasOne(d => d.PessoaArmaProcesso)
                    .WithMany(p => p.PessoaArmaProcessoEtapas)
                    .HasForeignKey(d => d.PessoaArmaProcessoId);

                entity.HasOne(d => d.ProcessoEtapa)
                    .WithMany(p => p.PessoaArmaProcessoEtapas)
                    .HasForeignKey(d => d.ProcessoEtapaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PessoaCampoCustomizado>(entity =>
            {
                entity.ToTable("PessoaCampoCustomizado", "Sistema");

                entity.HasIndex(e => e.CampoCustomizadoId, "IX_PessoaCampoCustomizado_CampoCustomizadoId");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaCampoCustomizado_PessoaId");

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampoCustomizado)
                    .WithMany(p => p.PessoaCampoCustomizados)
                    .HasForeignKey(d => d.CampoCustomizadoId);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaCampoCustomizados)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<PessoaContato>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PessoaId });

                entity.ToTable("PessoaContato", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaContato_PessoaId");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaContatos)
                    .HasForeignKey(d => d.PessoaId);
            });

            modelBuilder.Entity<PessoaDigital>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PessoaId });

                entity.ToTable("PessoaDigital", "Sistema");

                entity.HasIndex(e => e.OperadorId, "IX_PessoaDigital_OperadorId");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Dedo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagemDigital).IsUnicode(false);

                entity.Property(e => e.Mao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateFirTextEncode).IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.PessoaDigitals)
                    .HasForeignKey(d => d.OperadorId);
            });

            modelBuilder.Entity<PessoaDocumento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PessoaId });

                entity.ToTable("PessoaDocumento", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaDocumento_PessoaId");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DataEmissao).HasColumnType("date");

                entity.Property(e => e.ImagemFrente).IsUnicode(false);

                entity.Property(e => e.ImagemVerso).IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoEmissor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Validade).HasColumnType("date");

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaDocumentos)
                    .HasForeignKey(d => d.PessoaId);

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.PessoaDocumentos)
                    .HasForeignKey(d => d.TipoDocumentoId);
            });

            modelBuilder.Entity<PessoaEndereco>(entity =>
            {
                entity.ToTable("PessoaEndereco", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaEndereco_PessoaId");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Preferencial)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF");

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaEnderecos)
                    .HasForeignKey(d => d.PessoaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PessoaObservacao>(entity =>
            {
                entity.ToTable("PessoaObservacao", "Sistema");

                entity.HasIndex(e => e.OperadorId, "IX_PessoaObservacao_OperadorId");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaObservacao_PessoaId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao).HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.PessoaObservacaos)
                    .HasForeignKey(d => d.OperadorId);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaObservacaos)
                    .HasForeignKey(d => d.PessoaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PessoaProcesso>(entity =>
            {
                entity.ToTable("PessoaProcesso", "Sistema");

                entity.HasIndex(e => e.PessoaId, "IX_PessoaProcesso_PessoaId");

                entity.HasIndex(e => e.ProcessoId, "IX_PessoaProcesso_ProcessoId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaProcessos)
                    .HasForeignKey(d => d.PessoaId);

                entity.HasOne(d => d.Processo)
                    .WithMany(p => p.PessoaProcessos)
                    .HasForeignKey(d => d.ProcessoId);
            });

            modelBuilder.Entity<PessoaProcessoEtapa>(entity =>
            {
                entity.ToTable("PessoaProcessoEtapa", "Sistema");

                entity.HasIndex(e => e.OperadorConclusao, "IX_PessoaProcessoEtapa_OperadorConclusao");

                entity.HasIndex(e => e.PessoaProcessoId, "IX_PessoaProcessoEtapa_PessoaProcessoId");

                entity.HasIndex(e => e.ProcessoEtapaId, "IX_PessoaProcessoEtapa_ProcessoEtapaId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataDeConclusao).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.HasOne(d => d.OperadorConclusaoNavigation)
                    .WithMany(p => p.PessoaProcessoEtapas)
                    .HasForeignKey(d => d.OperadorConclusao);

                entity.HasOne(d => d.PessoaProcesso)
                    .WithMany(p => p.PessoaProcessoEtapas)
                    .HasForeignKey(d => d.PessoaProcessoId);

                entity.HasOne(d => d.ProcessoEtapa)
                    .WithMany(p => p.PessoaProcessoEtapas)
                    .HasForeignKey(d => d.ProcessoEtapaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PessoaSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pessoa_Sample");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("time(0)");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanoContum>(entity =>
            {
                entity.ToTable("PlanoConta", "Financeiro");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLancamento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<Processo>(entity =>
            {
                entity.ToTable("Processo", "Sistema");
            });

            modelBuilder.Entity<ProcessoEtapa>(entity =>
            {
                entity.ToTable("ProcessoEtapa", "Sistema");
            });

            modelBuilder.Entity<ProcessoEtapaDocumentosObrigatorio>(entity =>
            {
                entity.ToTable("ProcessoEtapaDocumentosObrigatorios", "Sistema");

                entity.HasIndex(e => e.EtapaId, "IX_ProcessoEtapaDocumentosObrigatorios_EtapaId");

                entity.HasIndex(e => e.TipoDeDocumentoId, "IX_ProcessoEtapaDocumentosObrigatorios_TipoDeDocumentoId");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.HasOne(d => d.Etapa)
                    .WithMany(p => p.ProcessoEtapaDocumentosObrigatorios)
                    .HasForeignKey(d => d.EtapaId);

                entity.HasOne(d => d.TipoDeDocumento)
                    .WithMany(p => p.ProcessoEtapaDocumentosObrigatorios)
                    .HasForeignKey(d => d.TipoDeDocumentoId);
            });

            modelBuilder.Entity<Recebimento>(entity =>
            {
                entity.ToTable("Recebimento", "Financeiro");

                entity.HasIndex(e => e.OperadorId, "IX_Recebimento_OperadorId");

                entity.HasIndex(e => e.PagadorPessoaId, "IX_Recebimento_PagadorPessoaId");

                entity.Property(e => e.DataBaseDeCalculo).HasColumnType("date");

                entity.Property(e => e.DataVencimentoFaturamento).HasColumnType("date");

                entity.Property(e => e.PagadorDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PagadorEnderecoUF");

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Recebimentos)
                    .HasForeignKey(d => d.OperadorId);

                entity.HasOne(d => d.PagadorPessoa)
                    .WithMany(p => p.Recebimentos)
                    .HasForeignKey(d => d.PagadorPessoaId);
            });

            modelBuilder.Entity<RecebimentoDetalhe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecebimentoDetalhe", "Financeiro");

                entity.Property(e => e.FormaCartaoAdquirente)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FormaCartaoAutorizacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormaCartaoBandeira)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FormaCartaoOperacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FormaChequeAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormaChequeBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormaChequeContaNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormaChequeNumero)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FormaTipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FormaValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FormaValorTroco).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescontoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNome)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ItemReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemValorJuros).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemValorMulta).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemVencimento).HasColumnType("date");

                entity.Property(e => e.Operador)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorEnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PagadorEnderecoUF");

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecebimentoEstorno>(entity =>
            {
                entity.HasKey(e => e.RecebimentoId);

                entity.ToTable("RecebimentoEstorno", "Financeiro");

                entity.HasIndex(e => e.OperadorId, "IX_RecebimentoEstorno_OperadorId");

                entity.Property(e => e.RecebimentoId).ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.RecebimentoEstornos)
                    .HasForeignKey(d => d.OperadorId);

                entity.HasOne(d => d.Recebimento)
                    .WithOne(p => p.RecebimentoEstorno)
                    .HasForeignKey<RecebimentoEstorno>(d => d.RecebimentoId);
            });

            modelBuilder.Entity<RecebimentoForma>(entity =>
            {
                entity.ToTable("RecebimentoForma", "Financeiro");

                entity.HasIndex(e => e.ChequeId, "IX_RecebimentoForma_ChequeId");

                entity.HasIndex(e => e.ContaFinanceiraId, "IX_RecebimentoForma_ContaFinanceiraId");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_RecebimentoForma_FormaCobrancaId");

                entity.HasIndex(e => e.RecebimentoId, "IX_RecebimentoForma_RecebimentoId");

                entity.HasIndex(e => e.TransacaoCartaoId, "IX_RecebimentoForma_TransacaoCartaoId");

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorTroco).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Cheque)
                    .WithMany(p => p.RecebimentoFormas)
                    .HasForeignKey(d => d.ChequeId);

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.RecebimentoFormas)
                    .HasForeignKey(d => d.ContaFinanceiraId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.RecebimentoFormas)
                    .HasForeignKey(d => d.FormaCobrancaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Recebimento)
                    .WithMany(p => p.RecebimentoFormas)
                    .HasForeignKey(d => d.RecebimentoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TransacaoCartao)
                    .WithMany(p => p.RecebimentoFormas)
                    .HasForeignKey(d => d.TransacaoCartaoId);
            });

            modelBuilder.Entity<RecebimentoItem>(entity =>
            {
                entity.ToTable("RecebimentoItem", "Financeiro");

                entity.HasIndex(e => e.ContaId, "IX_RecebimentoItem_ContaId");

                entity.HasIndex(e => e.RecebimentoId, "IX_RecebimentoItem_RecebimentoId");

                entity.Property(e => e.JurosValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MultaValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Conta)
                    .WithMany(p => p.RecebimentoItems)
                    .HasForeignKey(d => d.ContaId);

                entity.HasOne(d => d.Recebimento)
                    .WithMany(p => p.RecebimentoItems)
                    .HasForeignKey(d => d.RecebimentoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<RecebimentoItemDesconto>(entity =>
            {
                entity.ToTable("RecebimentoItemDesconto", "Financeiro");

                entity.HasIndex(e => e.PlanoContaId, "IX_RecebimentoItemDesconto_PlanoContaId");

                entity.HasIndex(e => e.RecebimentoItemId, "IX_RecebimentoItemDesconto_RecebimentoItemId");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.PlanoConta)
                    .WithMany(p => p.RecebimentoItemDescontos)
                    .HasForeignKey(d => d.PlanoContaId);

                entity.HasOne(d => d.RecebimentoItem)
                    .WithMany(p => p.RecebimentoItemDescontos)
                    .HasForeignKey(d => d.RecebimentoItemId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<RecebimentoListagemResumo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecebimentoListagemResumo", "Financeiro");

                entity.Property(e => e.Operador)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Pagador)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDesconto).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalItens).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalJuros).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalMulta).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<ReciboLiquidacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReciboLiquidacao", "Financeiro");

                entity.Property(e => e.EnderecoBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EnderecoUF");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDesconto).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.ItemDescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemJuros).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemMulta).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemPessoa)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.ItemReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MovimentoCartaoBandeira)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MovimentoCartaoOperacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MovimentoCartaoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MovimentoChequeBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MovimentoChequeNumero)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MovimentoTipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MovimentoTroco).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MovimentoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Operador)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Pagador)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReciboLiquidacoesOperador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ReciboLiquidacoesOperador", "Financeiro");

                entity.Property(e => e.CartaoOperacao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CartaoTipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeBanco)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNumero)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<Relacionamento>(entity =>
            {
                entity.ToTable("Relacionamento", "Associados");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResumoFinanceiro>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ResumoFinanceiro", "Financeiro");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBruto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorTaxa).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorTroco).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.ToTable("Saldo", "Financeiro");

                entity.HasIndex(e => new { e.ContaFinanceiraId, e.Dia }, "IX_Saldo_ContaFinanceiraId_Dia")
                    .IsUnique();

                entity.HasIndex(e => e.OperadorId, "IX_Saldo_OperadorId");

                entity.Property(e => e.Dia).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.Saldos)
                    .HasForeignKey(d => d.ContaFinanceiraId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Operador)
                    .WithMany(p => p.Saldos)
                    .HasForeignKey(d => d.OperadorId);
            });

            modelBuilder.Entity<SaldoDiarioContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SaldoDiarioConta", "Financeiro");

                entity.Property(e => e.Dia).HasColumnType("date");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaldoFormaCobranca>(entity =>
            {
                entity.ToTable("SaldoFormaCobranca", "Financeiro");

                entity.HasIndex(e => e.FormaCobrancaId, "IX_SaldoFormaCobranca_FormaCobrancaId");

                entity.HasIndex(e => new { e.SaldoId, e.FormaCobrancaId }, "IX_SaldoFormaCobranca_SaldoId_FormaCobrancaId")
                    .IsUnique();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ValorConfirmado).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorEntradaConfirmar).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorSaidaConfirmar).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.FormaCobranca)
                    .WithMany(p => p.SaldoFormaCobrancas)
                    .HasForeignKey(d => d.FormaCobrancaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Saldo)
                    .WithMany(p => p.SaldoFormaCobrancas)
                    .HasForeignKey(d => d.SaldoId);
            });

            modelBuilder.Entity<Setor>(entity =>
            {
                entity.ToTable("Setor", "Mapeamento");

                entity.HasIndex(e => e.LocalId, "IX_Setor_LocalId");

                entity.HasIndex(e => e.SetorPaiId, "IX_Setor_SetorPaiId");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VisaoInferior)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VisaoSuperior)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Local)
                    .WithMany(p => p.Setors)
                    .HasForeignKey(d => d.LocalId);

                entity.HasOne(d => d.SetorPai)
                    .WithMany(p => p.InverseSetorPai)
                    .HasForeignKey(d => d.SetorPaiId);
            });

            modelBuilder.Entity<Society360ContextoMigration>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Taxa>(entity =>
            {
                entity.ToTable("Taxa", "Associados");

                entity.Property(e => e.ConfiguracaoFechamento).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Recorrencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegraVencimento).IsUnicode(false);

                entity.Property(e => e.VigenciaPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxaValor>(entity =>
            {
                entity.ToTable("TaxaValor", "Associados");

                entity.HasIndex(e => e.TaxaId, "IX_TaxaValor_TaxaId");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RegraJuros).IsUnicode(false);

                entity.Property(e => e.RegraJurosId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBase).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Vigencia).IsUnicode(false);

                entity.HasOne(d => d.Taxa)
                    .WithMany(p => p.TaxaValors)
                    .HasForeignKey(d => d.TaxaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TaxaValorRegraDesconto>(entity =>
            {
                entity.ToTable("TaxaValorRegraDesconto", "Associados");

                entity.HasIndex(e => e.TaxaValorId, "IX_TaxaValorRegraDesconto_TaxaValorId");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DataUltimaAlteracao).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Regra).IsUnicode(false);

                entity.Property(e => e.RegraId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TaxaValor)
                    .WithMany(p => p.TaxaValorRegraDescontos)
                    .HasForeignKey(d => d.TaxaValorId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TaxaValorVigente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TaxaValorVigente", "Associados");

                entity.Property(e => e.ValidaApartirDe).HasMaxLength(4000);

                entity.Property(e => e.ValorBase).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TelefonesCadastrado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TelefonesCadastrados", "Sistema");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template", "CRM");

                entity.Property(e => e.Conteudo).IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estrutura)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RemetenteEnderecoEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemetenteNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateComunicacao>(entity =>
            {
                entity.ToTable("TemplateComunicacao", "CRM");

                entity.Property(e => e.Conteudo).IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateComunicacaoCampo>(entity =>
            {
                entity.ToTable("TemplateComunicacaoCampo", "CRM");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TipoDocumento", "Sistema");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataUltimaAlteracao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01T00:00:00.000')");

                entity.Property(e => e.Especializacao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DocumentoPessoal')");

                entity.Property(e => e.Mascara)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequerImagemFrente)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RequerImagemVerso)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RequerOrgaoExpeditor)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.RequerValidade)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<Transacao>(entity =>
            {
                entity.ToTable("Transacao", "Cobranca");

                entity.Property(e => e.ClienteModulo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteOrigem)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientePedidoId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CriadoEm).HasColumnType("datetime");

                entity.Property(e => e.DescontoValidoAte).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DescontoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Gateway)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNome)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorNumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaCep)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaPais)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagadorRuaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PagadorRuaUF");

                entity.Property(e => e.PagadorTipoDocumento)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PagamentoStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PagamentoValorAcrescimos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PagamentoValorDesconto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PagamentoValorPago).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PagamentoValorTaxa).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TransacaoCartao>(entity =>
            {
                entity.ToTable("TransacaoCartao", "Financeiro");

                entity.HasIndex(e => e.AdquirenteId, "IX_TransacaoCartao_AdquirenteId");

                entity.HasIndex(e => e.BandeiraId, "IX_TransacaoCartao_BandeiraId");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Especializacao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Adquirente)
                    .WithMany(p => p.TransacaoCartaos)
                    .HasForeignKey(d => d.AdquirenteId);

                entity.HasOne(d => d.Bandeira)
                    .WithMany(p => p.TransacaoCartaos)
                    .HasForeignKey(d => d.BandeiraId);
            });

            modelBuilder.Entity<TransacaoCartaoConfirmacaoTransferencium>(entity =>
            {
                entity.ToTable("TransacaoCartaoConfirmacaoTransferencia", "Financeiro");

                entity.HasIndex(e => e.ContaFinanceiraId, "IX_TransacaoCartaoConfirmacaoTransferencia_ContaFinanceiraId");

                entity.HasIndex(e => e.TransacaoId, "IX_TransacaoCartaoConfirmacaoTransferencia_TransacaoId");

                entity.HasIndex(e => e.TransferenciaCaixaId, "IX_TransacaoCartaoConfirmacaoTransferencia_TransferenciaCaixaId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ContaFinanceira)
                    .WithMany(p => p.TransacaoCartaoConfirmacaoTransferencia)
                    .HasForeignKey(d => d.ContaFinanceiraId);

                entity.HasOne(d => d.Transacao)
                    .WithMany(p => p.TransacaoCartaoConfirmacaoTransferencia)
                    .HasForeignKey(d => d.TransacaoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TransferenciaCaixa)
                    .WithMany(p => p.TransacaoCartaoConfirmacaoTransferencia)
                    .HasForeignKey(d => d.TransferenciaCaixaId);
            });

            modelBuilder.Entity<TransacaoCobranca>(entity =>
            {
                entity.ToTable("TransacaoCobranca", "Cobranca");

                entity.HasIndex(e => e.TransacaoId, "IX_TransacaoCobranca_TransacaoId")
                    .IsUnique()
                    .HasFilter("([TransacaoId] IS NOT NULL)");

                entity.Property(e => e.BoletoBanco)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_Banco");

                entity.Property(e => e.BoletoBeneficiarioClienteDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteDocumentoNumero");

                entity.Property(e => e.BoletoBeneficiarioClienteDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteDocumentoTipo");

                entity.Property(e => e.BoletoBeneficiarioClienteNome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteNome");

                entity.Property(e => e.BoletoBeneficiarioClienteNomeSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteNomeSocial");

                entity.Property(e => e.BoletoBeneficiarioClienteRua)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRua");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaBairro");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaCep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaCep");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaCidade");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaComplemento");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaNumero");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaPais)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaPais");

                entity.Property(e => e.BoletoBeneficiarioClienteRuaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioClienteRuaUF");

                entity.Property(e => e.BoletoBeneficiarioDocumentoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioDocumentoNumero");

                entity.Property(e => e.BoletoBeneficiarioDocumentoTipo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioDocumentoTipo");

                entity.Property(e => e.BoletoBeneficiarioNome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioNome");

                entity.Property(e => e.BoletoBeneficiarioNomeSocial)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioNomeSocial");

                entity.Property(e => e.BoletoBeneficiarioRua)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRua");

                entity.Property(e => e.BoletoBeneficiarioRuaBairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaBairro");

                entity.Property(e => e.BoletoBeneficiarioRuaCep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaCep");

                entity.Property(e => e.BoletoBeneficiarioRuaCidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaCidade");

                entity.Property(e => e.BoletoBeneficiarioRuaComplemento)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaComplemento");

                entity.Property(e => e.BoletoBeneficiarioRuaNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaNumero");

                entity.Property(e => e.BoletoBeneficiarioRuaPais)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaPais");

                entity.Property(e => e.BoletoBeneficiarioRuaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_BeneficiarioRuaUF");

                entity.Property(e => e.BoletoCedenteAgencia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_CedenteAgencia");

                entity.Property(e => e.BoletoCedenteCodigo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_CedenteCodigo");

                entity.Property(e => e.BoletoCodigoDeBarras)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_CodigoDeBarras");

                entity.Property(e => e.BoletoInstrucoes)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_Instrucoes");

                entity.Property(e => e.BoletoLinhaDigitavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_LinhaDigitavel");

                entity.Property(e => e.BoletoLocalDePagamento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_LocalDePagamento");

                entity.Property(e => e.BoletoNossoNumero)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_NossoNumero");

                entity.Property(e => e.BoletoUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Boleto_Url");

                entity.Property(e => e.BoletoVencimento)
                    .HasColumnType("date")
                    .HasColumnName("Boleto_Vencimento");

                entity.Property(e => e.MensagemRetorno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PermiteImpressao)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransacaoGatewayId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Transacao)
                    .WithOne(p => p.TransacaoCobranca)
                    .HasForeignKey<TransacaoCobranca>(d => d.TransacaoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TransacaoItem>(entity =>
            {
                entity.ToTable("TransacaoItem", "Cobranca");

                entity.HasIndex(e => e.TransacaoId, "IX_TransacaoItem_TransacaoId");

                entity.Property(e => e.DescontoValidoAte).HasColumnType("date");

                entity.Property(e => e.DescontoValor).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Transacao)
                    .WithMany(p => p.TransacaoItems)
                    .HasForeignKey(d => d.TransacaoId);
            });

            modelBuilder.Entity<TransferenciaRealizadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransferenciaRealizada", "Financeiro");

                entity.Property(e => e.DataSaldoDestino).HasColumnType("date");

                entity.Property(e => e.DataSaldoOrigem).HasColumnType("date");

                entity.Property(e => e.Destino)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DestinoDescricao)
                    .HasMaxLength(118)
                    .IsUnicode(false);

                entity.Property(e => e.Origem)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrigemDescricao)
                    .HasMaxLength(118)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TipoForma)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Transferencium>(entity =>
            {
                entity.ToTable("Transferencia", "Financeiro");

                entity.HasIndex(e => e.CaixaDestinoId, "IX_Transferencia_CaixaDestinoId");

                entity.HasIndex(e => e.CaixaOrigemId, "IX_Transferencia_CaixaOrigemId");

                entity.HasIndex(e => e.ChequeId, "IX_Transferencia_ChequeId");

                entity.HasIndex(e => e.ContaFinanceiraDestinoId, "IX_Transferencia_ContaFinanceiraDestinoId");

                entity.HasIndex(e => e.FormaCobrancaDestinoId, "IX_Transferencia_FormaCobrancaDestinoId");

                entity.HasIndex(e => e.FormaCobrancaOrigemId, "IX_Transferencia_FormaCobrancaOrigemId");

                entity.HasIndex(e => e.SaldoContaDestinoId, "IX_Transferencia_SaldoContaDestinoId");

                entity.HasIndex(e => e.SaldoContaOrigemId, "IX_Transferencia_SaldoContaOrigemId");

                entity.HasIndex(e => e.TransacaoCartaoId, "IX_Transferencia_TransacaoCartaoId");

                entity.Property(e => e.AprovacaoData).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.AprovacaoOperadorId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Aprovado).HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.DataSaldoDestino).HasColumnType("date");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoForma)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CaixaDestino)
                    .WithMany(p => p.TransferenciumCaixaDestinos)
                    .HasForeignKey(d => d.CaixaDestinoId);

                entity.HasOne(d => d.CaixaOrigem)
                    .WithMany(p => p.TransferenciumCaixaOrigems)
                    .HasForeignKey(d => d.CaixaOrigemId);

                entity.HasOne(d => d.Cheque)
                    .WithMany(p => p.Transferencia)
                    .HasForeignKey(d => d.ChequeId);

                entity.HasOne(d => d.ContaFinanceiraDestino)
                    .WithMany(p => p.Transferencia)
                    .HasForeignKey(d => d.ContaFinanceiraDestinoId);

                entity.HasOne(d => d.FormaCobrancaDestino)
                    .WithMany(p => p.TransferenciumFormaCobrancaDestinos)
                    .HasForeignKey(d => d.FormaCobrancaDestinoId);

                entity.HasOne(d => d.FormaCobrancaOrigem)
                    .WithMany(p => p.TransferenciumFormaCobrancaOrigems)
                    .HasForeignKey(d => d.FormaCobrancaOrigemId);

                entity.HasOne(d => d.SaldoContaDestino)
                    .WithMany(p => p.TransferenciumSaldoContaDestinos)
                    .HasForeignKey(d => d.SaldoContaDestinoId);

                entity.HasOne(d => d.SaldoContaOrigem)
                    .WithMany(p => p.TransferenciumSaldoContaOrigems)
                    .HasForeignKey(d => d.SaldoContaOrigemId);

                entity.HasOne(d => d.TransacaoCartao)
                    .WithMany(p => p.Transferencia)
                    .HasForeignKey(d => d.TransacaoCartaoId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
