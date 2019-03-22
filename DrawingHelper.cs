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

namespace _313616_PickDrawing
{
    class DrawingHelper
    {
        //Canvas c = new Canvas();
        Rectangle r = new Rectangle();

        public DrawingHelper(Canvas C, double X, double Y, double W, double H, Brush colour, string Shape) 
        {
            if (Shape == "Rectangle")
            {
                Rectangle r = new Rectangle();
                r.Height = H;
                r.Width = W;
                r.Fill = colour;
                Canvas.SetLeft(r, X);
                Canvas.SetTop(r, Y);
                C.Children.Add(r);
            }
            else
            {
                Ellipse e = new Ellipse();
                e.Height = H;
                e.Width = W;
                e.Fill = colour;
                Canvas.SetLeft(e, X);
                Canvas.SetTop(e, Y);
                C.Children.Add(e);
            }
        }
    }
}
