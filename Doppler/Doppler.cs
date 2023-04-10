using Doppler;
using System;
using System.Windows.Forms;

namespace Doppler
{
    // TODO setup installer like Ankh project
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
