using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class phonenumber
    {
        public static string REGEX_PAT = "^[1-9]{1}[0-9]{9}$";

        public static bool ValidatePhonenumber(string pat)
        {
            return Regex.IsMatch(pat , REGEX_PAT);
        }
    }
}
