
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Endereco
    {
        public Endereco()
        {
            this.cliente = new HashSet<Cliente>();
            this.motoristas = new HashSet<Motoristas>();
        }
    
        public int IDENDERECO { get; set; }
        public string TIPO { get; set; }
        public string CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUM { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
    
        public virtual ICollection<Cliente> cliente { get; set; }
        public virtual ICollection<Motoristas> motoristas { get; set; }
    }
}
