using System.Resources;

namespace Doppler.Utils
{
    public static class Language
    {
        const string RESOURCE = "Doppler.Resources.Language";
        public static string GetString(string resName)
        {
            ResourceManager rm = new ResourceManager(RESOURCE, typeof(Doppler).Assembly);
            var value = rm.GetString(resName);
            return value ?? "Not found";
        }
    }
}