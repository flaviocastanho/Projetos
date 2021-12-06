using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Armas = new HashSet<Arma>();
            ClienteMarcadors = new HashSet<ClienteMarcador>();
            Conta = new HashSet<Contum>();
            ContratoBeneficiarios = new HashSet<Contrato>();
            ContratoContratantes = new HashSet<Contrato>();
            Eventos = new HashSet<Evento>();
            Faturas = new HashSet<Fatura>();
            InversePessoaResponsavel = new HashSet<Pessoa>();
            MeioDePagamentoPagadorPessoas = new HashSet<MeioDePagamento>();
            MeioDePagamentoPessoas = new HashSet<MeioDePagamento>();
            PessoaArmas = new HashSet<PessoaArma>();
            PessoaCampoCustomizados = new HashSet<PessoaCampoCustomizado>();
            PessoaContatos = new HashSet<PessoaContato>();
            PessoaDocumentos = new HashSet<PessoaDocumento>();
            PessoaEnderecos = new HashSet<PessoaEndereco>();
            PessoaObservacaos = new HashSet<PessoaObservacao>();
            PessoaProcessos = new HashSet<PessoaProcesso>();
            Recebimentos = new HashSet<Recebimento>();
        }

        public int Id { get; set; }
        public string NomeSocial { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public DateTime? DataFundacao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public int Especializacao { get; set; }
        public bool? Excluido { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Tipo { get; set; }
        public string FotoPerfil { get; set; }
        public string DocumentoTipo { get; set; }
        public string DocumentoValor { get; set; }
        public int? PessoaResponsavelId { get; set; }

        public virtual Pessoa PessoaResponsavel { get; set; }
        public virtual ICollection<Arma> Armas { get; set; }
        public virtual ICollection<ClienteMarcador> ClienteMarcadors { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
        public virtual ICollection<Contrato> ContratoBeneficiarios { get; set; }
        public virtual ICollection<Contrato> ContratoContratantes { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Fatura> Faturas { get; set; }
        public virtual ICollection<Pessoa> InversePessoaResponsavel { get; set; }
        public virtual ICollection<MeioDePagamento> MeioDePagamentoPagadorPessoas { get; set; }
        public virtual ICollection<MeioDePagamento> MeioDePagamentoPessoas { get; set; }
        public virtual ICollection<PessoaArma> PessoaArmas { get; set; }
        public virtual ICollection<PessoaCampoCustomizado> PessoaCampoCustomizados { get; set; }
        public virtual ICollection<PessoaContato> PessoaContatos { get; set; }
        public virtual ICollection<PessoaDocumento> PessoaDocumentos { get; set; }
        public virtual ICollection<PessoaEndereco> PessoaEnderecos { get; set; }
        public virtual ICollection<PessoaObservacao> PessoaObservacaos { get; set; }
        public virtual ICollection<PessoaProcesso> PessoaProcessos { get; set; }
        public virtual ICollection<Recebimento> Recebimentos { get; set; }
    }
}
