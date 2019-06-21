namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Funcionarios
    {
        public int IDFUNCIONARIO { get; set; }
        public int CARGOS_IDCARGO { get; set; }
        public int USUARIOS_IDUSUARIO { get; set; }
        public int MATRICULA { get; set; }
        public string NOME { get; set; }
		public string EMAIL { get; set; }
		public decimal SALARIO { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public int PIS { get; set; }
		public int CTPS { get; set; }
		public int TITELEITOR { get; set; }
		public string NASCIMENTO { get; set; }
		public string CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUM { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELCEL { get; set; }
        public string TELRES { get; set; }
		public DateTime ADMISSAO { get; set; }
		public DateTime DEMISSAO { get; set; }

		public virtual Cargos cargos { get; set; }
        public virtual Usuarios usuarios { get; set; }


		public Funcionarios()
		{
		}

		public Funcionarios(string nOME, string eMAIL, decimal sALARIO,
			string cPF, string rG, int pIS, int cTPS, int tITELEITOR, string nASCIMENTO,
			string cEP, string lOGRADOURO, string nUM, string bAIRRO,
			string cIDADE, string uF, DateTime aDMISSAO)
		{
			NOME = nOME;
			EMAIL = eMAIL;
			SALARIO = sALARIO;
			CPF = cPF;
			RG = rG;
			PIS = pIS;
			CTPS = cTPS;
			TITELEITOR = tITELEITOR;
			NASCIMENTO = nASCIMENTO;
			CEP = cEP;
			LOGRADOURO = lOGRADOURO;
			NUM = nUM;
			BAIRRO = bAIRRO;
			CIDADE = cIDADE;
			UF = uF;
			ADMISSAO = aDMISSAO;
		}
	}
}
