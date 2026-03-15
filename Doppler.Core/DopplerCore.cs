using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using System;
using System.IO;

namespace Doppler.Core
{
    public static class DopplerCore
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static string LOGFILE => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            Constants.PROJECT,
            "logs",
            "doppler.log"
            );

        public static void Main()
        {
            SetupLogger(LOGFILE);
            Logger.Info("Launching Addams Application");
            Logger.Debug(string.Concat("Welcome to ", Constants.PROJECT, " - Version : ", Constants.VERSION));
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

            ConsoleTarget console = new ConsoleTarget();

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, console);

            // Apply config           
            LogManager.Configuration = config;
        }
    }
}
