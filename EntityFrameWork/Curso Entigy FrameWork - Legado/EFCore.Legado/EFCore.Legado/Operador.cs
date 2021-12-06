using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Operador
    {
        public Operador()
        {
            Caixas = new HashSet<Caixa>();
            ContaPagamentos = new HashSet<ContaPagamento>();
            ContratoHistoricos = new HashSet<ContratoHistorico>();
            Devolucaos = new HashSet<Devolucao>();
            Lancamentos = new HashSet<Lancamento>();
            Movimentos = new HashSet<Movimento>();
            OperadorFormaCobrancas = new HashSet<OperadorFormaCobranca>();
            OperadorNotificacaos = new HashSet<OperadorNotificacao>();
            PessoaArmaProcessoEtapas = new HashSet<PessoaArmaProcessoEtapa>();
            PessoaDigitals = new HashSet<PessoaDigital>();
            PessoaObservacaos = new HashSet<PessoaObservacao>();
            PessoaProcessoEtapas = new HashSet<PessoaProcessoEtapa>();
            RecebimentoEstornos = new HashSet<RecebimentoEstorno>();
            Recebimentos = new HashSet<Recebimento>();
            Saldos = new HashSet<Saldo>();
        }

        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public int? PerfilId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public bool? Excluido { get; set; }
        public string Foto { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Caixa> Caixas { get; set; }
        public virtual ICollection<ContaPagamento> ContaPagamentos { get; set; }
        public virtual ICollection<ContratoHistorico> ContratoHistoricos { get; set; }
        public virtual ICollection<Devolucao> Devolucaos { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<OperadorFormaCobranca> OperadorFormaCobrancas { get; set; }
        public virtual ICollection<OperadorNotificacao> OperadorNotificacaos { get; set; }
        public virtual ICollection<PessoaArmaProcessoEtapa> PessoaArmaProcessoEtapas { get; set; }
        public virtual ICollection<PessoaDigital> PessoaDigitals { get; set; }
        public virtual ICollection<PessoaObservacao> PessoaObservacaos { get; set; }
        public virtual ICollection<PessoaProcessoEtapa> PessoaProcessoEtapas { get; set; }
        public virtual ICollection<RecebimentoEstorno> RecebimentoEstornos { get; set; }
        public virtual ICollection<Recebimento> Recebimentos { get; set; }
        public virtual ICollection<Saldo> Saldos { get; set; }
    }
}
