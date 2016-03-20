

namespace HW3.Models
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder SubstringBuilder (this StringBuilder sb, int position)

        {
            string result = sb.ToString().Substring(position, sb.Length - position);
            StringBuilder resultNew = new StringBuilder(result);
            return resultNew;
        }

        public static StringBuilder StringBuilder1 (this StringBuilder sb, int position, int length)
        {
        string result = sb.ToString().Substring (position,length);

            StringBuilder resultNew1 = new StringBuilder(result);

            return resultNew1;
        
        }
    }
}
