using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital.DTO
{
    class ImagenDTO
    {
        //Atributos
        private int? iIdImagen { get; set; }
        private int? iIdCampaña { get; set; }
        private String iRutaImagen { get; set; }
        private short iDuracion { get; set; }

        //Constructor
        public ImagenDTO() { }

    }
}
