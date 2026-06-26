using System;

namespace Text
{
    /// <summary>
    /// Provides string-related utility methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines whether <paramref name="s"/> is a palindrome.
        /// Comparison is case-insensitive and ignores any character that is
        /// not a letter or digit (spaces, punctuation, etc.).
        /// </summary>
        /// <param name="s">The string to test.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="s"/> reads the same forwards and
        /// backwards (after normalization); otherwise <c>false</c>.
        /// An empty or <c>null</c> string is considered a palindrome.
        /// </returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                    left++;
                while (left < right && !char.IsLetterOrDigit(s[right]))
                    right--;

                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
