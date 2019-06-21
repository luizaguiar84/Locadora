
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Telefonecliente
    {
        public int IDTELEFONE { get; set; }
        public int CLIENTE_IDCLIENTE { get; set; }
        public string TIPO { get; set; }
        public string NUMTELEFONE { get; set; }
    
        public virtual Cliente cliente { get; set; }
    }
}
