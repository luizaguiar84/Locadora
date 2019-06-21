namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Usuarios
    {
        public Usuarios()
        {
            this.cliente = new HashSet<Cliente>();
            this.funcionarios = new HashSet<Funcionarios>();
        }
    
        public int IDUSUARIO { get; set; }
        public int NIVEL { get; set; }
        public string LOGIN { get; set; }
        public string PASS { get; set; }
    
        public virtual ICollection<Cliente> cliente { get; set; }
        public virtual ICollection<Funcionarios> funcionarios { get; set; }
    }
}
