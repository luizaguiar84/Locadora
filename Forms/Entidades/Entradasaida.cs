
namespace Forms.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public class Entradasaida
    {
        public int IDENTRADASAIDA { get; set; }
        public int CARROS_IDCARRO { get; set; }
        public Nullable<System.TimeSpan> HORAENTRADA { get; set; }
        public Nullable<System.TimeSpan> HORASAIDA { get; set; }
    
        public virtual Carros carros { get; set; }
    }
}
