using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Lugar
    {
        public int Id { get; set; }
        public int FilaId { get; set; }
        public int Ordem { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public bool Bloqueado { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Fila Fila { get; set; }
    }
}
