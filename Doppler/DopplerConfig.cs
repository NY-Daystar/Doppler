using Doppler.Exceptions;
using Doppler.Utils;
using NLog;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Doppler
{
    /// <summary>
    /// Config to use this project
    /// </summary>
    public class DopplerConfig
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Source path of the video
        /// </summary>
        [JsonPropertyName("source_path")]
        public string SourcePath { get; set; } = string.Empty;

        /// <summary>
        /// Folder to save images after processing
        /// </summary>
        [JsonPropertyName("destination_path")]
        public string DestinationFolderPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of FFMPEG path executable
        /// </summary>
        [JsonPropertyName("ffmpeg_path")]
        public string FfmpegPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of seconde source video file to merge with SourcePath
        /// </summary>
        [JsonPropertyName("merge_path")]
        public string MergePath { get; set; } = string.Empty;

        /// <summary>
        /// Start time to truncate video
        /// </summary>
        [JsonPropertyName("start")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// End time to truncate video
        /// </summary>
        [JsonPropertyName("end")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// Light or Dark Theme
        /// </summary>
        [JsonPropertyName("theme")]
        public DopplerTheme Theme { get; set; }

        /// <summary>
        /// Config file store in AppData folder : %APPDATA%\Addams
        /// </summary>
        public static string ConfigFilepath
        {
            get
            {
                const string _appDataFolderName = Constants.PROJECT; // Name of the project for %APPDATA% folder
                const string _appDataConfigFilename = "config.json"; // Config file name 
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _appDataFolderName, _appDataConfigFilename);
            }
        }

        /// <summary>
        /// Retrieve config if already exists if not we create it
        /// </summary>
        /// <returns>DopplerConfig</returns>
        public static DopplerConfig Get()
        {
            DopplerConfig config = new DopplerConfig();

            try
            {
                config = Read();
                Logger.Debug($"Config already exists:\n{config}");
            }
            catch (DopplerConfigException ex)
            {
                Logger.Debug($"Configuration cannot be read {ex.Message}");
                Logger.Warn($"This config will be saved:\n{config}");
                config.Save();
            }
            return config;
        }

        /// <summary>
        /// Init data
        /// </summary>
        public void Setup()
        {
            SourcePath = string.Empty;
            DestinationFolderPath = string.Empty;
            FfmpegPath = string.Empty;
            StartTime = string.Empty;
            EndTime = string.Empty;
            Theme = DopplerTheme.LIGHT;
        }

        /// <summary>
        /// Serialize object to save json file in appData
        /// </summary>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public void Save()
        {
            // Setup file and Directory if not exists
            if (!File.Exists(ConfigFilepath))
            {
                string folder =
                    (Path.GetDirectoryName(ConfigFilepath)
                    ?? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Constants.PROJECT))
                    ?? throw new DirectoryNotFoundException($"SpotifyConfig - Save method can't find folder based on path {ConfigFilepath}");
                if (!Directory.Exists(folder))
                {
                    _ = Directory.CreateDirectory(folder);
                }
                File.Create(ConfigFilepath).Close();
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            string content = JsonSerializer.Serialize(this, options);
            File.WriteAllText(ConfigFilepath, content);
        }

        /// <summary>
        /// Deserialize json file content store in appdata
        /// </summary>
        /// <returns>DopplerConfig with datavalue from file</returns>
        public static DopplerConfig Read()
        {
            try
            {
                string content = File.ReadAllText(ConfigFilepath);
                Logger.Debug($"Read config path {ConfigFilepath}");
                return JsonSerializer.Deserialize<DopplerConfig>(content) ?? new DopplerConfig();
            }
            catch
            {
                throw new DopplerConfigException();
            }
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DopplerConfig p = (DopplerConfig)obj;

            return SourcePath == p.SourcePath
                && DestinationFolderPath == p.DestinationFolderPath
                && FfmpegPath == p.FfmpegPath;
        }

        public override int GetHashCode()
        {
            return SourcePath.GetHashCode() + DestinationFolderPath.GetHashCode() + FfmpegPath.GetHashCode();
        }

        public override string ToString()
        {
            return $"\tSourcePath: '{SourcePath}'\n" +
                $"\tDestinationFolderPath: '{DestinationFolderPath}'\n" +
                $"\tFfmpegPath: '{FfmpegPath}'\n";
        }
    }
}