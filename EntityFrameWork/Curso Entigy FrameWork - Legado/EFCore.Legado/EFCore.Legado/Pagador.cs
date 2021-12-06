using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Pagador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DocumentoTipo { get; set; }
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
    }
}
