using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Rectangle
    {
        public Square(int x1, int y1, int lengthSide)
            :base(x1, y1, (x1+lengthSide), (y1+lengthSide))
        {

        }
    }
}
