using System.Runtime.CompilerServices;

namespace Codility_MaxNonoverlappingSegments
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 0;
        private const int RANGE_HIGHEST_VALUE = 30000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A, int[] B)
        {
            if (A.Length == 0)
                return 0;
            int N = A.Length;

            if (A.Length == B.Length && N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int count = 1;  // Initialize count to 1 for the first segment
                int lastEnd = B[0];

                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] > lastEnd)
                    {
                        count++;
                        lastEnd = B[i];
                    }
                }

                return count;
            }

            return 0; // the initials conditions (A.Length != B.Length or N is not valid) are not met 
        }
    }
}
