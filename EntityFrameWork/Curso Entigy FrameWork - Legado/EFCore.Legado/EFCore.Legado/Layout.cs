using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore.Legado
{
    public partial class Layout
    {
        public int Id { get; set; }
        public string CorPrimaria { get; set; }
        public string CorSecundaria { get; set; }
        public string CorLinks { get; set; }
        public string Favicon { get; set; }
        public string LogoExterno { get; set; }
        public string LogoInterno { get; set; }
    }
}
