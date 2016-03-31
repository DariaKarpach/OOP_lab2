using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Figures
{
    class Line : Shape
    {  
        private Point beginLine, endLine;

        public Line(Point beginLine, Point endLine)
        {
            this.beginLine = beginLine;
            this.endLine = endLine;
        }

            public override void Draw(Canvas drawing)
        {
            System.Windows.Shapes.Line myLine = new System.Windows.Shapes.Line();

            myLine.Stroke = System.Windows.Media.Brushes.Blue;
            myLine.StrokeThickness = 2;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;

            myLine.X1 = beginLine.X;
            myLine.X2 = endLine.X;
            myLine.Y1 = beginLine.Y;
            myLine.Y2 = endLine.Y;

            drawing.Children.Add(myLine);
        }


    }
}
