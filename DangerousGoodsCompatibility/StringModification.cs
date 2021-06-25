using System;
using System.Collections.Generic;
using System.Text;

namespace DangerousGoodsCompatibility
{
    public static class StringModification
    {
        public static string ConvertStringToFileName(string fullString)
        {
            fullString = fullString.Replace("File: ", string.Empty);
            return fullString;
        }

        public static string ConvertStringToFileNameWithoutExtension(string fullString)
        {
            fullString = fullString.Replace("File: ", string.Empty);
            fullString = fullString.Replace(".png", string.Empty);
            return fullString;
        }
    }
}
