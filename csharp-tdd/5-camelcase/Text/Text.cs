namespace Text
{
    /// <summary>
    /// Provides operations on strings.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <remarks>
        /// Every word after the first begins with an uppercase letter, so the
        /// word count is the number of uppercase letters plus one for the
        /// leading (lowercase) word.
        /// </remarks>
        /// <param name="s">The camelCase string to inspect.</param>
        /// <returns>
        /// The number of words in <paramref name="s"/>, or 0 if it is empty or
        /// <c>null</c>.
        /// </returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int count = 1;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
