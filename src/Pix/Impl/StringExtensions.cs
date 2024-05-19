using System;
using System.Collections.Generic;
using System.Text;

namespace PixDotNet.Impl
{
    internal static class StringExtensions
    {
        internal static string Prepend(this string string1, string string2) 
        {
            return string.Format("{0}{1}", string1, string2);
        }
    }
}
