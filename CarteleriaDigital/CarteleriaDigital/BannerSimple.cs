﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital
{
    class BannerSimple : Banner
    {
        private String iText;

        public BannerSimple(String pText, Boolean pActivo, String pNombre)
        {
            this.iActivo = pActivo;
            this.iNombre = pNombre;
            this.iText = pText;
        }

        public Boolean Activo
        {
            get { return this.iActivo; }
            set { this.iActivo = value; }
        }

        public String Nombre
        {
            get { return this.Nombre; }
            set { this.iNombre = value; }
        }

        public String Text
        {
            get { return this.iText; }
            set { this.iText = value; }
        }

    }
}
