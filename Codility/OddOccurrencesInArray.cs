using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            HashSet<int> numSet = new HashSet<int>();
            foreach (var item in A)
            {
                if (numSet.Contains(item)) numSet.Remove(item);
                else numSet.Add(item);
            }
            return numSet.First();
        }
    }
}
