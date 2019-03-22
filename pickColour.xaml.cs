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
using System.Windows.Shapes;

namespace _313616_PickDrawing
{
    /// <summary>
    /// Interaction logic for pickColour.xaml
    /// </summary>
    public partial class pickColour : Window
    {
        public pickColour()
        {
            InitializeComponent();

            for (int r = 0; r < 256; r = r + 33)
            {
                //Button btnColour = new Button();
                //btnColour.Background = new SolidColorBrush(Color.FromRgb((byte)r, 0, 0));
                //btnColour.Height = 10;
                //btnColour.Click += B_Click;
                //stackPanel.Children.Add(btnColour);
                for (int g = 0; g < 256; g = g + 33)
                {
                    //Button btnColour2 = new Button();
                    //btnColour2.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, 0));
                    //btnColour2.Height = 10;
                    //btnColour2.Click += B_Click;
                    //stackPanel.Children.Add(btnColour2);
                    for (int b = 0; b < 256; b = b + 33)
                    {
                        Button btnColour3 = new Button();
                        btnColour3.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
                        btnColour3.Content = " ";
                        btnColour3.Click += B_Click;
                        stackPanel.Children.Add(btnColour3);
                    }
                }
            }
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.b = ((Button)sender).Background;
            DialogResult = true;
        }
    }
}