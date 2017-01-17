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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantallas.PanBannerSimple abrir = new Pantallas.PanBannerSimple();
            abrir.Show();
            this.SetVisibleCore(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campaña abrir = new Campaña();
            abrir.Show();
            this.SetVisibleCore(false);
        }
    }
}