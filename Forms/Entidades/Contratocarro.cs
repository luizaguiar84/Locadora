
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Contratocarro
    {
        public Contratocarro()
        {
            this.carros = new HashSet<Carros>();
            this.contratopneus = new HashSet<Contratopneus>();
            this.contratoseguros = new HashSet<Contratoseguros>();
            this.contratosinistros = new HashSet<Contratosinistros>();
            this.contratoviagens = new HashSet<Contratoviagens>();
            this.motoristas = new HashSet<Motoristas>();
            this.multas = new HashSet<Multas>();
        }
    
        public int IDCONTRATOCARRO { get; set; }
        public int CONTRATOS_IDCONTRATO { get; set; }
        public int CARRO_IDCARRO { get; set; }
    
        public virtual ICollection<Carros> carros { get; set; }
        public virtual Carros carros1 { get; set; }
        public virtual Contratos contratos { get; set; }
        public virtual ICollection<Contratopneus> contratopneus { get; set; }
        public virtual ICollection<Contratoseguros> contratoseguros { get; set; }
        public virtual ICollection<Contratosinistros> contratosinistros { get; set; }
        public virtual ICollection<Contratoviagens> contratoviagens { get; set; }
        public virtual ICollection<Motoristas> motoristas { get; set; }
        public virtual ICollection<Multas> multas { get; set; }
    }
}
