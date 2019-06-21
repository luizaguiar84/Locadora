
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Cor
    {
        public Cor()
        {
            this.carros = new HashSet<Carros>();
        }
    
        public int IDCOR { get; set; }
        public string COR1 { get; set; }
    
        public virtual ICollection<Carros> carros { get; set; }
    }
}
