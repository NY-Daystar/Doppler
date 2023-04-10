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
using System.Windows.Forms.VisualStyles;

namespace Doppler
{
    public partial class DopplerForm : Form
    {
        private static readonly string _path = @"C:\Users\Lucas\Downloads";

        public DopplerForm()
        {
            InitializeComponent();
        }

        // TODO to delete
        private void CaptureMyScreen4()
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save(_path, ImageFormat.Jpeg);
            }

        }
        private void CaptureMyScreen3()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save(_path, ImageFormat.Jpeg);
            }
        }
        private void CaptureMyScreen2()
        {

            Bitmap bmp = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
            Rectangle cr = Screen.AllScreens[0].Bounds;
            Graphics cG = Graphics.FromImage(bmp);

            cG.CopyFromScreen(cr.Left, cr.Top, 0, 0, cr.Size);
            bmp.Save(_path, ImageFormat.Png);
        }

        /// <summary>
        /// TODO gerer la sortie des fichiers
        /// </summary>
        private void CaptureMyScreen()
        {
            try
            {
                Rectangle bounds = this.Bounds; // Set size of screen
                //Rectangle captureRectangle = Screen.AllScreens[0].Bounds; // capture our Current Screen

                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height)) // Creating a new Bitmap object
                {
                    using (Graphics g = Graphics.FromImage(bitmap)) // Creating a New Graphics Object
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size); // Copying Image from The Screen
                    }

                    string filepath = Path.Combine(_path, "screen.png");

                    bitmap.Save(filepath, ImageFormat.Png);


                }
                MessageBox.Show("Screen Captured"); // Displaying the Successfull Result
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Launch(object sender, EventArgs e)
        {

            // TODO s'inspirer de ca
            // https://github.com/BlueHippoGithub/ScreenshotDemo
            // https://www.youtube.com/watch?v=yh7Kd3o5Y3k
            // https://www.youtube.com/watch?v=b6wT8Iq4A3E

            // 0 - Creer le repo et git flow init

            // 1 - TODO ajouter les parametres suivants dans le form
            // - SELECT pour le screen 1 - 2 -3 etc...
            // - deux textfield pour la taille en pixel
            // - un slider pour la frequence des screen de 0.5 à 5 secondes
            // - mettre un select pour la duree 1- 5- 15-30-1h-2h-5h-infite
            // - un Select poour le choix des extensions
            // - Un fileChooser pour choisir le dossier ou stocker les photos
            // - TODO enable le bouton un fois tous selectionner


            // 2 - TODO faire un bouton de test aussi pour un screen de test

            // 3 - Lancer grandeur nature le projet

            // 4 - Ajouter un bouton exit + un menubar avec (file, settings, about)

            // 5 - Ajouter un fichier ressources pour les langues

            // TODO final - TEST grandeur nature : - S"en servir pour faire les screens de l'album de voyage angleterre

            // Hide Form to get the screen
            this.Hide();

            // TODO faire la boucle pour capture les screens
            CaptureMyScreen();
        }
    }
}
