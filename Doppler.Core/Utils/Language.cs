using System.Resources;

namespace Doppler.Core.Utils
{
    public static class Language
    {
        const string RESOURCE = "Doppler.Core.Resources.Language";
        public static string GetString(string resName)
        {
            ResourceManager rm = new ResourceManager(RESOURCE, typeof(DopplerCore).Assembly);
            var value = rm.GetString(resName);
            return value ?? "Not found";
        }
    }
}