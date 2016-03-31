using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Figures
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Figures.Shape> figures = new List<Figures.Shape>();

            figures.Add(new Quadrangle(new Point(450, 100), new Point(425, 200), new Point(450, 150), new Point(475, 200)));
            figures.Add(new Rectangle(400, 240, 490, 290));
            figures.Add(new Square(440, 0, 50));
            figures.Add(new Ellipse(200, 150, 40, 150));
            figures.Add(new Circle(50, 200, 80));
            figures.Add(new Line(new Point(5, 5), new Point(50, 220)));

            foreach (Shape figure in figures )
            {
                figure.Draw(drawing);
            }

        }

    }
}
