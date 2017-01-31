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
    public partial class AgregarCampaña : Form
    {
        public AgregarCampaña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
           
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                                        
            }

            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = "C:\\";
            openFileDialog2.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog2.FilterIndex = 2;

            openFileDialog2.Multiselect = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog2.FileName;

            }

            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();

                Campaña abrir = new Campaña();
                abrir.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("La campaña ha sido agregada exitosamente", "Advertencia", MessageBoxButtons.OK) == DialogResult.Yes)
            {
                this.Close();
            }
            AgregarCampaña cerrar = new AgregarCampaña();
            cerrar.Hide();
            this.SetVisibleCore(false);

            Campaña abrir = new Campaña();
            abrir.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}