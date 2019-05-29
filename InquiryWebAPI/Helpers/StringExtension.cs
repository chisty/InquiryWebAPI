using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquiryWebAPI.Helpers
{
    public static class StringExtension
    {
        public static bool IsEqual(this string stringValue, string compareString)
        {
            if (string.IsNullOrWhiteSpace(stringValue) && string.IsNullOrWhiteSpace(compareString)) return true;
            if (string.IsNullOrWhiteSpace(stringValue) || string.IsNullOrWhiteSpace(compareString)) return false;
            if (string.Equals(stringValue.ToLower().Trim(), compareString.ToLower().Trim())) return true;
            return false;
        }
    }
}
