using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital
{
    class BannerSimple : Banner
    {
        private String iText;

        public BannerSimple(String pText, Boolean pActivo, String pNombre, Rango pRango)
        {
            base.Activo = pActivo;
            base.Nombre = pNombre;
            this.iText = pText;
            base.Rango = pRango;
        }

        public new Boolean Activo
        {
            get { return this.iActivo; }
            set { this.iActivo = value; }
        }

        public new string Nombre
        {
            get { return base.Nombre; }
            set { base.Nombre = value; }
        }

        public String Text
        {
            get { return this.iText; }
            set { this.iText = value; }
        }

        public new Rango Rango
        {
            get { return base.Rango; }
            set { base.Rango = value; }
        }
    }
}
