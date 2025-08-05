using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using System;
using System.IO;
using Application = System.Windows.Forms.Application;

namespace Doppler
{
    internal static class Doppler
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static string LOGFILE => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            Constants.PROJECT,
            "logs",
            "doppler.log"
            );

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupLogger(LOGFILE);
            Logger.Info("Launching Addams Application");
            Logger.Debug(string.Concat("Welcome to ", Constants.PROJECT, " - Version : ", Constants.VERSION));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DopplerForm());
        }

        /// <summary>
        /// Setup the logger with its path and it's minimum level
        /// </summary>
        /// <param name="filePath">path of the file</param>
        private static void SetupLogger(string filePath)
        {
            LoggingConfiguration config = new LoggingConfiguration();
            Layout layout = "level:${uppercase:${level}} - date:${date} - caller: ${callsite-filename}:${callsite-linenumber} - ${message} ${exception:format=tostring}";

            // Targets where to log to: File and Console
            FileTarget logfile = new FileTarget("logfile")
            {
                FileName = filePath,
                ArchiveEvery = FileArchivePeriod.Month,
                MaxArchiveFiles = 5,
                Layout = layout
            };

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);

            // Apply config           
            LogManager.Configuration = config;
        }
    }
}
