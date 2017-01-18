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
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.jpg";
            openFileDialog1.Filter = "Cursor Files|*.png";
            openFileDialog1.Title = "Select a Cursor File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                this.Cursor = new Cursor(openFileDialog1.OpenFile());
                
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
    }
}