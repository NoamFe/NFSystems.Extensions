using System.Text.RegularExpressions;

namespace NFSystems.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string value) => string.IsNullOrEmpty(value);

        public static bool IsNotEmpty(this string value) => !string.IsNullOrEmpty(value);

        public static string[] SplitCamelCase(this string source) => Regex.Split(source, @"(?<!^)(?=[A-Z])");
    }
}
