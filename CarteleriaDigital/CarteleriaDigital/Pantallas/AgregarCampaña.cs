using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Falta ingresar el nombre de la campaña", "Advertencia");

            }

            else
            {
               //para guardar UN pictureBox en disco
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    // pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                   int  Numimagen = 1;
                        if (pictureBox1.Image != null) { pictureBox1.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox2.Image != null) { pictureBox2.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox3.Image != null) { pictureBox3.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox4.Image != null) { pictureBox4.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox5.Image != null) { pictureBox5.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox6.Image != null) { pictureBox6.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox7.Image != null) { pictureBox7.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox8.Image != null) { pictureBox8.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox9.Image != null) { pictureBox9.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }
                        if (pictureBox10.Image != null) { pictureBox10.Image.Save(saveFileDialog1.FileName + Numimagen.ToString() + ".jpg", ImageFormat.Jpeg); Numimagen++; }

                MessageBox.Show("La campaña ha sido agregada exitosamente", "Atención", MessageBoxButtons.OK);
                }
                
                this.Close();
                Campaña abrir = new Campaña();
                abrir.Show();

                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "C:/Imágenes";
                saveFileDialog1.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
                                            


            }
            
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
                if (pictureBox1.Image == null) { pictureBox1.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox2.Image == null) { pictureBox2.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox3.Image == null) { pictureBox3.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox4.Image == null) { pictureBox4.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox5.Image == null) { pictureBox5.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox6.Image == null) { pictureBox6.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox7.Image == null) { pictureBox7.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox8.Image == null) { pictureBox8.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox9.Image == null) { pictureBox9.ImageLocation = openFileDialog.FileName; }
                else if (pictureBox10.Image == null) { pictureBox10.ImageLocation = openFileDialog.FileName; }

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

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) 
        {
            
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
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