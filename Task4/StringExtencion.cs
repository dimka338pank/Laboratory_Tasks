using System.Text.RegularExpressions;

namespace Task4
{
    internal static class StringExtencion
    {
        public static string RemoveExtraSpaces(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return Regex.Replace(str.Trim(), @"\s+", " ");
        }
    }
}
