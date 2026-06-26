using System;

namespace Text
{
    /// <summary>
    /// Provides string-related utility methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in
        /// <paramref name="s"/>. The input is assumed to contain only
        /// lowercase ASCII letters, with no spaces or special characters.
        /// </summary>
        /// <param name="s">The string to scan.</param>
        /// <returns>
        /// The index of the first character that occurs exactly once in
        /// <paramref name="s"/>, or <c>-1</c> if every character repeats
        /// (or the string is empty / <c>null</c>).
        /// </returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            int[] counts = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}
