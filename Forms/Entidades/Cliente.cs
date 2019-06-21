
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Cliente
    {
        public Cliente()
        {
            this.contratos = new HashSet<Contratos>();
            this.telefonecliente = new HashSet<Telefonecliente>();
        }
    
        public int IDCLIENTE { get; set; }
        public int USUARIO_IDUSUARIO { get; set; }
        public int ENDERECO_IDENDERECO { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string TIPO_CLIENTE { get; set; }
        public Nullable<sbyte> STATUS_CLIENTE { get; set; }
		public string RG { get; set; }
		public string IE { get; set; }
		public string PROFISSAO { get; set; }
		public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> DT_NASCIMENTO { get; set; }
    
        public virtual Usuarios usuarios { get; set; }
        public virtual Endereco endereco { get; set; }
        public virtual ICollection<Contratos> contratos { get; set; }
        public virtual ICollection<Telefonecliente> telefonecliente { get; set; }
    }
}
