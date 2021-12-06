using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Setor
    {
        public Setor()
        {
            Filas = new HashSet<Fila>();
            InverseSetorPai = new HashSet<Setor>();
        }

        public int Id { get; set; }
        public int LocalId { get; set; }
        public string Codigo { get; set; }
        public int? SetorPaiId { get; set; }
        public string VisaoInferior { get; set; }
        public string VisaoSuperior { get; set; }
        public string Descricao { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public virtual Local Local { get; set; }
        public virtual Setor SetorPai { get; set; }
        public virtual ICollection<Fila> Filas { get; set; }
        public virtual ICollection<Setor> InverseSetorPai { get; set; }
    }
}
