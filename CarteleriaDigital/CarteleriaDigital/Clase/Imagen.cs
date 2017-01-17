using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital
{
    class Imagen
    {
        private String iRutaImagen;
        private short iDuracion;

        public Imagen(String pRutaImagen, short pDuracion)
        {
            this.iDuracion = pDuracion;
            this.iRutaImagen = pRutaImagen;
        }

        public short Duracion
        {
            set { iDuracion = value; }
            get { return this.iDuracion; }
        }

        public String RutaImagen
        {
            set { iRutaImagen = value; }
            get { return this.iRutaImagen; }
        }
    }
}
