using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Doppler.Utils
{
    public static class AutoUpdater
    {
        private const string ASSET_EXTENSION = ".msi";

        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task CheckForUpdateAsync()
        {
            try
            {
                var latest = await GetLatestReleaseAsync();

                if (latest == null) return;

                if (IsNewerVersion(latest.TagName, Constants.VERSION))
                {
                    var result = MessageBox.Show(
                        $"A new version {latest.TagName} is available.\n" +
                        "Do you want to install it ?",
                        "New version available",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string msiUrl = latest.GetMsiUrl().AbsoluteUri;
                        if (msiUrl != null)
                        {
                            await DownloadAndInstallAsync(msiUrl);
                        }
                        else
                        {
                            MessageBox.Show($"No .{ASSET_EXTENSION} file found in the release");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification de mise à jour : " + ex.Message);
            }
        }

        private static async Task<GitHubRelease> GetLatestReleaseAsync()
        {
            string url = $"https://api.github.com/repos/{Constants.OWNER}/{Constants.PROJECT}/releases/latest";

            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApp-Updater");

            string json = await httpClient.GetStringAsync(url);
            return JsonSerializer.Deserialize<GitHubRelease>(json);
        }

        private static bool IsNewerVersion(string latest, string current)
        {
            Version vLatest = new Version(latest.TrimStart('v'));
            Version vCurrent = new Version(current.TrimStart('v'));

            return vLatest > vCurrent;
        }

        private static async Task DownloadAndInstallAsync(string url)
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "update.msi");

            using (var response = await httpClient.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                using (var fs = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
                {
                    await response.Content.CopyToAsync(fs);
                }
            }

            // Launch .msi
            Process.Start(new ProcessStartInfo
            {
                FileName = tempFile,
                UseShellExecute = true
            });

            Application.Exit(); // Quit application to authorize update
        }

        private sealed class GitHubRelease
        {
            [JsonPropertyName("tag_name")]
            public string TagName { get; set; }

            [JsonPropertyName("assets")]
            public IEnumerable<GitHubAsset> Assets { get; set; }

            public Uri GetMsiUrl()
            {
                return new Uri(Assets.First(asset => asset.Name.EndsWith(ASSET_EXTENSION, StringComparison.OrdinalIgnoreCase)).BrowserDownloadUrl);
            }
        }

        private sealed class GitHubAsset
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("browser_download_url")]
            public string BrowserDownloadUrl { get; set; }
        }
    }
}
