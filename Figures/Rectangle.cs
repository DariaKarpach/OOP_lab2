using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Figures
{
    class Rectangle : Quadrangle
    {
        public Rectangle(int x1, int y1, int x2, int y2)
            :base(new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new Point(x1, y2))
        {

        }
    }
}
