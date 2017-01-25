using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteleriaDigital
{
    public partial class ElegirBanner : Form
    {
        public ElegirBanner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallas.PanBannerSimple abrir = new Pantallas.PanBannerSimple();
            abrir.Show();
            this.SetVisibleCore(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElegirBanner cerrar = new ElegirBanner();
            cerrar.Hide();
            // this.SetVisibleCore(false);

            PantallaInicio abrir = new PantallaInicio();
            abrir.Show();
        }
    }
}
