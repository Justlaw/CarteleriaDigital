using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DTO
{
    class BannerDTO
    {
        //Atributos con sus getters y setters
        private int? idBanner { get; set; }
        private int? idRango { get; set; }
        private bool activo { get; set; }
        private String nombre { get; set; }

        //Constructor
        public BannerDTO() { }
    }
}
