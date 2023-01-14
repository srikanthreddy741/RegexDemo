using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Pincode
    {
        public static string REGEX_PAT = "^[1-9]{1}[0-9]{2}[' ']?[0-9]{3}$";

        public static bool ValidatePincode(string pat)
        {
            return Regex.IsMatch(pat, REGEX_PAT);
        }
    }
}
