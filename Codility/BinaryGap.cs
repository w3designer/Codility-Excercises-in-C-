using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class BinaryGap
    {
        public int solution(int N)
        {
            string binary = Convert.ToString(N, 2);
            short binaryGap = 0, Counter = 0;
            foreach (var ch in binary)
            {
                if (ch == '0') Counter++;
                else if (Counter > binaryGap)
                {
                    binaryGap = Counter;
                    Counter = 0;
                }
            }
            return binaryGap;
        }
    }
}
