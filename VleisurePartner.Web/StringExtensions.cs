using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace VleisurePartner.Web
{
    public static class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string s1, string s2)
        {
            return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
        }

        public static DateTime? ToDateTime(this string stringValue)
        {
            DateTime dateTime;
            if (!DateTime.TryParse(stringValue, out dateTime))
            {
                return null;
            }

            return dateTime;
        }

        public static DateTime? ToTime(this string time)
        {
            if (string.IsNullOrWhiteSpace(time))
            {
                return null;
            }

            DateTime temp;
            if (!DateTime.TryParseExact(time, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
            {
                return null;
            }

            return temp;
        }

        /// <summary>
        /// Tries to convert the string to a decimal based on the current culture's format for currency.
        /// e.g. $1,000.00 -> 1000.00
        /// </summary>
        /// <returns>The decimal equivalent of the string currency.
        /// Null or empty strings will be converted to 0.
        /// If the string is not a valid currency format (e.g. ABC), null is returned.</returns>
        public static decimal? ToCurrency(this string stringValue)
        {
            var currency = 0M;
            if (!string.IsNullOrEmpty(stringValue) && !decimal.TryParse(stringValue, NumberStyles.Currency, CultureInfo.CurrentCulture, out currency))
            {
                return null;
            }

            return currency;
        }

        public static string ToSHA256Hash(this string expression, string salt)
        {
            var saltedBytes = Encoding.UTF8.GetBytes(string.Concat(expression, salt));
            var hashed = new SHA256Managed().ComputeHash(saltedBytes);

            return Convert.ToBase64String(hashed);
        }

        /// <summary>
        /// Returns defaultValue if the string is null or empty.
        /// </summary>
        public static string DefaultTo(this string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }

        public static string DefaultToNotSpecified(this string value)
        {
            return value.DefaultTo("(Not specified)");
        }

        public static string LimitFinalLengthTo(this string value, int finalLength, string suffix = "...")
        {
            return value.Length <= finalLength
                ? value
                : $"{value.Substring(0, finalLength - suffix.Length)}{suffix}";
        }

        public static string MakeValidFileName(this string fileName)
        {
            return Regex.Replace(fileName.Trim(), @"[^\w\.]", "_");
        }

        //String insensitive replace
        public static string Replace(this string str, string oldValue, string newValue, StringComparison comparison)
        {
            StringBuilder sb = new StringBuilder();

            int previousIndex = 0;
            int index = str.IndexOf(oldValue, comparison);
            while (index != -1)
            {
                sb.Append(str.Substring(previousIndex, index - previousIndex));
                sb.Append(newValue);
                index += oldValue.Length;

                previousIndex = index;
                index = str.IndexOf(oldValue, index, comparison);
            }
            sb.Append(str.Substring(previousIndex));

            return sb.ToString();
        }

        public static string CleanHtmlTags(this string value)
        {
            return Regex.Replace(value, "<.*?>", string.Empty);
        }
    }
}
