using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jester.OldSchool.Extensions
{
    public static class StringExtensions
    {
        public static DateTime ParseDate(this string value)
        {
            var day = int.Parse(value.Substring(0, 2));
            var month = int.Parse(value.Substring(3, 2));
            var year = int.Parse(value.Substring(6, 4));
            return new DateTime(year, month, day);
        }

        ///[return: NotNullIfNotNull("value")]
        public static string Slugify(this string value)
        {
            //if (value == null)
            //{
            //    throw new ArgumentNullException();
            //}
            ArgumentNullException.ThrowIfNull(value);

            return value.ToLower().Replace(" ", "-");
        }

        public static string GetLastWordOfString(this string value)
        {
            var lastSpaceIndexOf = value.Trim().LastIndexOf(" ", StringComparison.InvariantCultureIgnoreCase);
            return lastSpaceIndexOf == -1 ? string.Empty : value[(lastSpaceIndexOf + 1)..];
        }

        public static ReadOnlySpan<char> GetLastWordFromStringBySpan(this string value)
        {
            var s = value.AsSpan();
            var lastSpaceIndexOf = s.LastIndexOf(" ", StringComparison.InvariantCultureIgnoreCase);
            return lastSpaceIndexOf == -1 ? ReadOnlySpan<char>.Empty : s.Slice(lastSpaceIndexOf + 1);

        }
    }
}
