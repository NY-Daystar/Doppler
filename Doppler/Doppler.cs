using Doppler.Core;
using System;
using Application = System.Windows.Forms.Application;

namespace Doppler
{
    internal static class Doppler
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DopplerCore.Main();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DopplerView());
        }
    }
}
