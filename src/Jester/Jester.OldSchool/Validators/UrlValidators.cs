using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jester.OldSchool.Validators
{
    public static class RegexExpressions
    {
        public const string Url = @"/^https?:\/\/(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$/";
    }

    // < c# 11
    public class UrlValidator
    {
        public static readonly Regex UrlRegex = new Regex(RegexExpressions.Url);

        public bool IsMatch(string input) => UrlRegex.IsMatch(input);
    }

    // c# 11
    public partial class UrlValidatorNew
    {
        [GeneratedRegex(RegexExpressions.Url, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase)]
        public static partial Regex regex();
        public bool IsMatch(string input) => regex().IsMatch(input);
    }
}
