
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Carros
    {
        public Carros()
        {
            this.contratocarro1 = new HashSet<Contratocarro>();
            this.entradasaida = new HashSet<Entradasaida>();
        }
    
        public int IDCARROS { get; set; }
        public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }
        public int MANUTENCAO_IDMANUTENCAO { get; set; }
        public int MODELOS_IDMODELO { get; set; }
        public int COR_IDCOR { get; set; }
        public string PLACA { get; set; }
        public string RENAVAM { get; set; }
        public string CHASSI { get; set; }
        public int ANO_FAB { get; set; }
        public int ANO_MOD { get; set; }
        public int QUILOMETRAGEM { get; set; }
        public decimal VALOR_DIARIA { get; set; }
        public System.DateTime DATA_AQUISICAO { get; set; }
        public Nullable<sbyte> ARCONDICIONADO { get; set; }
        public Nullable<sbyte> DIRECAOHIDRAULICA { get; set; }
        public Nullable<sbyte> VIDROELETRICO { get; set; }
        public Nullable<sbyte> AIRBAG { get; set; }
        public Nullable<sbyte> ABS { get; set; }
        public int LUGARES { get; set; }
        public int PORTAS { get; set; }
    
        public virtual Modelos modelos { get; set; }
        public virtual Cor cor { get; set; }
        public virtual Manutencao manutencao { get; set; }
        public virtual Contratocarro contratocarro { get; set; }
        public virtual ICollection<Contratocarro> contratocarro1 { get; set; }
        public virtual ICollection<Entradasaida> entradasaida { get; set; }
    }
}
