using System;
using System.Linq;

namespace Codility
{
    class Solution
    {
        public int solution(int[] A)
        {
            int result = 1;
            Array.Sort(A);
            A = A.ToList().OrderBy(a => a).Distinct().ToArray<int>();
            int firstIndex = Array.BinarySearch(A, 1);
            if (firstIndex < 0) return 1;
            int correctNum = 2;
            for (int j = firstIndex + 1; j < A.Length; j++)
            {
                if (A[j] != correctNum) return correctNum;
                correctNum++;
            }
            return correctNum;
        }
    }

}
