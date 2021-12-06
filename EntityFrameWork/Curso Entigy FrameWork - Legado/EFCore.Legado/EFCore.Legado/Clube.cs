using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Clube
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoUf { get; set; }
        public string EnderecoCep { get; set; }
        public string EnderecoPais { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Site { get; set; }
    }
}
