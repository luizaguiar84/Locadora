
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargos
	{
		public Cargos()
        {
            this.funcionarios = new HashSet<Funcionarios>();
        }
    
        public int IDCARGO { get; set; }
        public string CARGO { get; set; }
    
        public virtual ICollection<Funcionarios> funcionarios { get; set; }
    }
}
