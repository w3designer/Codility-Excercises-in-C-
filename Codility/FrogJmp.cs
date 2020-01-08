using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling(Decimal.Divide((Y - X) , D));
        }
    
    }
}
