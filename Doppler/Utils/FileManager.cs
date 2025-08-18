using System.Windows.Forms;

namespace Doppler.Utils
{
    public class FileManager
    {
        FileDialog Dialog;

        public void AttachComponents(DopplerForm app)
        {
            Dialog = app.fileDialog;
        }

        /// <summary>
        /// Open FileDialog and return file selected
        /// </summary>
        /// <returns>path of the file selected</returns>
        public string SearchFile()
        {
            Dialog.ShowDialog();
            return Dialog.FileName;
        }

        /// <summary>
        /// Open FileDialog and return folder selected
        /// </summary>
        /// <returns>path of the folder selected</returns>
        public string SearchFolder()
        {
            Dialog.CheckFileExists = false;
            Dialog.ValidateNames = false;
            var result = Dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                return System.IO.Path.GetDirectoryName(Dialog.FileName);
            }
            else
            {
                MessageBox.Show("Aucun dossier sélectionné.");
                return string.Empty;
            }
        }
    }
}