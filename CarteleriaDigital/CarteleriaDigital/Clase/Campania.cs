using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteleriaDigital
{
    class Campania
    {
        private Boolean iActivo;
        private String iNombre;
        private List<Imagen> iListaImagenes;

        public Campania(Boolean pActivo, String pNombre, List<Imagen> pListaImagenes)
        {
            this.iActivo = pActivo;
            this.iNombre = pNombre;
            this.iListaImagenes = pListaImagenes;
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

        public List<Imagen> ListaImagenes
        {
            get { return this.iListaImagenes; }
            set { this.iListaImagenes = value; }
        }
    }
}
