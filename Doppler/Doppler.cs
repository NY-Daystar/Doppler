using Doppler;
using System;
using System.Windows.Forms;

namespace Doppler
{
    // https://github.com/NY-Daystar/Doppler
    // TODO ajouter une icone d'installation pour le setup
    internal static class Doppler
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DopplerForm());
        }
    }
}
