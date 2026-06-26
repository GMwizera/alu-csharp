using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides basic mathematical operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer contained in <paramref name="nums"/>.
        /// </summary>
        /// <param name="nums">The list of integers to scan.</param>
        /// <returns>
        /// The largest integer in <paramref name="nums"/>, or <c>0</c> if the list is empty.
        /// </returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
    }
}
