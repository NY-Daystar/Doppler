using System;
using System.IO;

namespace Doppler.Core.Utils
{
    internal static class ProcessUtil
    {
        public static string EscapeArgument(string arg)
        {
            if (string.IsNullOrEmpty(arg))
                return "\"\"";

            // échappe les guillemets
            arg = arg.Replace("\"", "\\\"");

            return $"\"{arg}\"";
        }

        public static void ValidatePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("Invalid path");

            var fullPath = Path.GetFullPath(path);
        }

        public static bool IsValidTime(string time)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(time, @"^\d{2}:\d{2}:\d{2}$");
        }
    }
}
