using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteleriaDigital.Pantallas
{
    public partial class PanBannerSimple : Form
    {
        public PanBannerSimple()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("¿Está seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.SetVisibleCore(false);

                    Campaña cerrar = new Campaña();
                    cerrar.Hide();
                    this.SetVisibleCore(false);

                    PantallaInicio abrir = new PantallaInicio();
                    abrir.Show();
                }
           
        }

        private void PanBannerSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
