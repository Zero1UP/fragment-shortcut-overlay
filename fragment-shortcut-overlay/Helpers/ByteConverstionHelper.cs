using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fragment_shortcut_overlay.Helpers
{
    public static class ByteConverstionHelper
    {
        public static string converyBytesToSJIS(byte[] data)
        {
            try
            {
                var cleanedString = Encoding.GetEncoding(932).GetString(data).Split(new string[] { "\0" }, StringSplitOptions.None);
                return cleanedString[0].Replace(',', ' ');
            }
            catch (Exception)
            {

                return "";
            }


        }
    }
}
