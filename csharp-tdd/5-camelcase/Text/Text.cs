using System;

namespace Text
{
    /// <summary>
    /// Provides string-related utility methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// The first word starts in lowercase; every subsequent word starts
        /// with an uppercase letter.
        /// </summary>
        /// <param name="s">The camelCase string to inspect.</param>
        /// <returns>
        /// The number of words in <paramref name="s"/>, or <c>0</c> if
        /// <paramref name="s"/> is <c>null</c> or empty.
        /// </returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;
            }
            return count;
        }
    }
}
