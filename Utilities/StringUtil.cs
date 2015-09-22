using System;
using System.Text.RegularExpressions;

namespace Utilities
{
    static public class StringUtil
    {
        static public string UpperCaseFirstCharacter(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            //Turns the first (^) lowercase letter character ([a-z]) to an Uppercase one
            return Regex.Replace(text, "^[a-z]", m => m.Value.ToUpper());
        }
    }
}
