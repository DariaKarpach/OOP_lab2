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
    class Ellipse : Shape
    {
        private int x, y, height, width;

        public Ellipse(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public override void Draw(Canvas drawing)
        {
            System.Windows.Shapes.Ellipse myEllipse = new System.Windows.Shapes.Ellipse();
            myEllipse.Stroke = System.Windows.Media.Brushes.Blue;
            myEllipse.Fill = System.Windows.Media.Brushes.White;
            myEllipse.StrokeThickness = 2;
            myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            myEllipse.VerticalAlignment = VerticalAlignment.Center;
            myEllipse.Height = height;
            myEllipse.Width = width;

            drawing.Children.Add(myEllipse);

            Canvas.SetTop(myEllipse, x);
            Canvas.SetLeft(myEllipse, y);

        }

    }
}
