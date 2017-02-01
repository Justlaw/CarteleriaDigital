using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DTO
{
    class RangoDTO
    {
        //Atributos, getters y setters
        private int? iIdRango { set; get; }
        private DateTime iFechaInicio { get; set; }
        private DateTime iFechaFin { get; set; }
        private DateTime iHoraInicio { get; set; }
        private DateTime iHoraFin { get; set; }

        //Constructor
        public RangoDTO() { }
    }
}
