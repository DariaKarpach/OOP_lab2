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
    class Quadrangle: Shape
    {
        private List<Point> points { get; set; }

        public Quadrangle(Point point1, Point point2, Point point3, Point point4)
        {
            points = new List<Point>() { point1, point2, point3, point4 }; 
        }

        public override void Draw(Canvas drawing)
        {
            Polygon myQuadrangle = new Polygon();

            myQuadrangle.Stroke = System.Windows.Media.Brushes.Blue;
            myQuadrangle.Fill = System.Windows.Media.Brushes.White;
            myQuadrangle.StrokeThickness = 2;
            myQuadrangle.HorizontalAlignment = HorizontalAlignment.Left;
            myQuadrangle.VerticalAlignment = VerticalAlignment.Center;

            foreach (var point in points)
            {
                myQuadrangle.Points.Add(point);
            }

            drawing.Children.Add(myQuadrangle);
        }
    }
}
