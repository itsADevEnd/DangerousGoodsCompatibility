using System;
using System.Collections.Generic;
using System.Text;

namespace DangerousGoodsCompatibility
{
    public static class StringModification
    {
        public static string ConvertStringToFileName(string fullString)
        {
            return fullString.Replace("File: ", string.Empty);
        }
    }
}
