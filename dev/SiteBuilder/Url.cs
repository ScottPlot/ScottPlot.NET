using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SiteBuilder
{
    public static class Url
    {
        public static string Sanitize(string s)
        {
            s = s.ToLower().Replace(" ", "-").Replace(":", "");
            s = Regex.Replace(s, "[^a-zA-Z0-9-_.]+", "", RegexOptions.Compiled);
            return s;
        }
    }
}
