using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Ellipse
    {
        public Circle(int x, int y, int diameter)
            :base (x, y, diameter, diameter)
        {

        }
    }
}
