using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class MeioDePagamento
    {
        public MeioDePagamento()
        {
            Conta = new HashSet<Contum>();
            Contratos = new HashSet<Contrato>();
            Faturas = new HashSet<Fatura>();
        }

        public int Id { get; set; }
        public int FormaCobrancaId { get; set; }
        public int PessoaId { get; set; }
        public int DiaDeCobranca { get; set; }
        public string Nome { get; set; }
        public string DocumentoNumero { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string DocumentoTipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public bool? Excluido { get; set; }
        public int? PagadorPessoaId { get; set; }

        public virtual FormaCobranca FormaCobranca { get; set; }
        public virtual Pessoa PagadorPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<Fatura> Faturas { get; set; }
    }
}
