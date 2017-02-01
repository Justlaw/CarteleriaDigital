using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DTO
{
    class CampañaDTO
    {
        //Atributos, getters y setters
        private int? iIdCampaña { get; set; }
        private int? iIdRango { get; set; }
        private bool iActivo { get; set; }
        private String iNombre { get; set; }

        //Constructor
        public CampañaDTO() { }
    }
}
