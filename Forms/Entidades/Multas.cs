
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Multas
    {
        public int IDMULTAS { get; set; }
        public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
    
        public virtual Contratocarro contratocarro { get; set; }
    }
}
