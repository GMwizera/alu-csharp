using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides basic mathematical operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the largest integer contained in a list.
        /// </summary>
        /// <param name="nums">The list of integers to search.</param>
        /// <returns>
        /// The maximum integer in <paramref name="nums"/>, or 0 if the list is
        /// empty or <c>null</c>.
        /// </returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}
