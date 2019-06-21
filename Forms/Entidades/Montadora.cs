
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Montadora
    {
        public Montadora()
        {
            this.modelos = new HashSet<Modelos>();
        }
    
        public int IDMONTADORA { get; set; }
        public string NOME { get; set; }
    
        public virtual ICollection<Modelos> modelos { get; set; }
    }
}
