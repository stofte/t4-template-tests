using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T4.Generator
{
    public class Helpers
    {
        private static Dictionary<string, string> SpecialCharacterMap = new Dictionary<string, string>()
        {
            { "æ", "ae" },
            { "ø", "o" },
            { "å", "aa" },
            { "Æ", "AE" },
            { "Ø", "O" },
            { "Å", "AA" }
        };

        public static string SanitizeName(params string[] objects)
        {
            var x = String.Join("_", objects.Select(o => String.Join("_", o.Split(' '))));
            return x;
        }
    }
}
