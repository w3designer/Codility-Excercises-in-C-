using System;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution(new int[] { -1, -3, -10, 8, 1,2,3,4,5,6,7 }));
            Console.WriteLine(new BinaryGap().solution(80));
            Console.WriteLine(new OddOccurrencesInArray().solution(new int[] { 1, 1, 2, 2, 2, 2, 4, 4, 4,5,5,5,5,5,5 }));
            Console.WriteLine(new FrogJmp().solution(10, 85, 30));
            Console.WriteLine(new PermMissingElem().solution(new int[] { 2,3,1,5 }));
            Console.ReadKey();
        }
    }
}
