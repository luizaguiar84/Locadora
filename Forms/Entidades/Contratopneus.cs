
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Contratopneus
    {
        public int IDCONTRATOPNEUS { get; set; }
        public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }
        public Nullable<int> KMUSADA { get; set; }
    
        public virtual Contratocarro contratocarro { get; set; }
    }
}
