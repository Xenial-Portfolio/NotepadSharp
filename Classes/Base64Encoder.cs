using System;
using System.Collections.Generic;
using System.Text;

namespace NotepadSharp.Classes
{
    public static class Base64Encoder
    {
        public static string Encode(string text)
        {
            var textBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        }

        public static string Decode(string base64)
        {
            var base64Bytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(base64Bytes);
        }
    }
}
