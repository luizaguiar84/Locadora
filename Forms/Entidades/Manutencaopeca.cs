
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Manutencaopeca
    {
        public int IDMANUTENCAOPECA { get; set; }
        public int PECAS_IDPECAS { get; set; }
        public int MANUTENCAO_IDMANUTENCAO { get; set; }
        public decimal VALOR { get; set; }
    
        public virtual Manutencao manutencao { get; set; }
        public virtual Pecas pecas { get; set; }
    }
}
