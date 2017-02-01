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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
                        
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                                         
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
            pictureBox1.Image = null;            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox8.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:/Imágenes";
            openFileDialog.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.ImageLocation = openFileDialog.FileName;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = null;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = null;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = null;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = null;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = null;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;

            //pictureBox2.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            //pictureBox2.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            //pictureBox2.DragDrop += new DragEventHandler(pictureBox1_DragDrop);         
                        
        }

        private void AgregarCampaña_Load(object sender, EventArgs e)
        {                        


        }

        
       /*  private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
         {
             //var img = pictureBox1.Image;
             //if (img == null) return;
             //if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
             //{
             //    pictureBox1.Image = null;
             //}

             PictureBox pb = (PictureBox)sender;
             pb.Select();
             pb.DoDragDrop(pb.Image, DragDropEffects.Move);

         }

         private void pictureBox1_DragEnter(object sender, DragEventArgs e)
         {
             if (e.Data.GetDataPresent(DataFormats.Bitmap))
             {
                 e.Effect = DragDropEffects.Move;
             }
             else
             {
                 e.Effect = DragDropEffects.None;
             }

         }

         private void pictureBox1_DragDrop(object sender, DragEventArgs e)
         {
             PictureBox pb = (PictureBox)sender;
             pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

         } */
    }
}