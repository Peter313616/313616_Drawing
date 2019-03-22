/*
 * Peter McEwen
 * March 22, 2019
 * lets user create their own shapes
 */
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Shape;
        public static Brush b;
        System.IO.StreamWriter sw = new System.IO.StreamWriter("SavedShapes.txt", true);
        System.IO.StreamReader sr = new System.IO.StreamReader("SavedShapes.txt");

        public MainWindow()
        {
            InitializeComponent();

            while (!sr.EndOfStream)
            {
                string tempValues = sr.ReadLine();
                string[] Values = tempValues.Split(',');
                DrawingHelper DH = new DrawingHelper()
            }
        }

        private void setColour_Click(object sender, RoutedEventArgs e)
        {
            pickColour p = new pickColour();
            p.ShowDialog();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            string[] temp = txtInput.Text.Split(',');
            int[] dimensions = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int.TryParse(temp[i], out dimensions[i]);
            }
            //MessageBox.Show(b.ToString());
            DrawingHelper DH = new DrawingHelper(canvas, dimensions[0], dimensions[1], dimensions[2], dimensions[3], b, Shape);
            sw.WriteLine("canvas," + dimensions[0] + "," + dimensions[1] + ","
                + dimensions[2] + "," + dimensions[3] + "," + b + "," + Shape);
        }

        private void rbRec_Checked(object sender, RoutedEventArgs e)
        {
            Shape = "Rectangle";
        }

        private void rbEli_Checked(object sender, RoutedEventArgs e)
        {
            Shape = "Ellipse";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            sw.Flush();
        }
    }
}
