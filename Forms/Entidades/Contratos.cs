
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Contratos
    {
        public Contratos()
        {
            this.contratocarro = new HashSet<Contratocarro>();
            this.pneus = new HashSet<Pneus>();
        }
    
        public int IDCONTRATO { get; set; }
        public int CLIENTE_IDCLIENTE { get; set; }
        public Nullable<sbyte> STATUS { get; set; }
        public System.DateTime DATACONTRATO { get; set; }
        public Nullable<System.DateTime> DATAINICIO { get; set; }
        public Nullable<System.DateTime> DATAFINAL { get; set; }
        public decimal VALOR { get; set; }
        public int KMINICIAL { get; set; }
        public int KMFINAL { get; set; }
    
        public virtual Cliente cliente { get; set; }
        public virtual ICollection<Contratocarro> contratocarro { get; set; }
        public virtual ICollection<Pneus> pneus { get; set; }
    }
}
