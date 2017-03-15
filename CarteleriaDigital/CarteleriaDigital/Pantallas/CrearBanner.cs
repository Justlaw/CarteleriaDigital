using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarteleriaDigital.DTO;

namespace CarteleriaDigital.Pantallas
{
    public partial class CrearBanner : Form
    {
        public CrearBanner()
        {
            InitializeComponent();
            rdB_BannerSimple.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtURL.ReadOnly = true;
            txtTexto.ReadOnly = false;
            txtURL.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.ReadOnly = true;
            txtURL.ReadOnly = false;
            txtTexto.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Controlando que las fechas indicadas no sean anteriores a hoy
            if (dtpFechaInicio.Value > DateTime.Today && dtpFechaFin.Value > dtpFechaInicio.Value)
            {

                //En el caso de que haya seleccionado banner simple:
                if (rdB_BannerSimple.Checked)
                {
                    DTO.BannerSimpleDTO bsDto = new DTO.BannerSimpleDTO();
                    bsDto.Nombre = txtNombre.Text;
                    bsDto.Texto = txtTexto.Text;
                }

                //si seleccionó banner rss
                if (rdB_BannerRSS.Checked)
                {
                    DTO.BannerRSSDTO brssDto = new DTO.BannerRSSDTO();
                    brssDto.Nombre = txtNombre.Text;
                    brssDto.FuenteRSS = txtURL.Text;
                }

                //Rango para el banner
                RangoDTO ran = new RangoDTO();

                //Carga de fechas
                ran.FechaInicio = dtpFechaInicio.Value;
                ran.FechaFin = dtpHoraFin.Value;

                //Carga de rango horario
                ran.HoraInicio = dtpHoraInicio.Value;
                ran.HoraFin = dtpHoraFin.Value;
            }
            else
            {
                MessageBox.Show("Las fechas no están ingresadas correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    }
}
