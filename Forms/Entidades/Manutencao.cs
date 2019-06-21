
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Manutencao
    {
        public Manutencao()
        {
            this.carros = new HashSet<Carros>();
            this.manutencaopeca = new HashSet<Manutencaopeca>();
        }
    
        public int IDMANUTENCAO { get; set; }
        public string DESCRICAO { get; set; }
        public decimal VALORMANUTENCAO { get; set; }
    
        public virtual ICollection<Carros> carros { get; set; }
        public virtual ICollection<Manutencaopeca> manutencaopeca { get; set; }
    }
}
