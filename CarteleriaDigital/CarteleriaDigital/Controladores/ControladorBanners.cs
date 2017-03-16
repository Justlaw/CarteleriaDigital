using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteleriaDigital.DTO;

namespace CarteleriaDigital.Controladores
{
    class ControladorBanners
    {
        List<BannerSimple> bannersimples = new List<BannerSimple>();
        List<BannerRSS> bannerrss = new List<BannerRSS>();

        public bool crearBannerSimple(BannerSimpleDTO pBS, RangoDTO pRango)
        {
            return true;
        }
    }
}
