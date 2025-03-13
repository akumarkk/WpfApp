using ResRef.Models;
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

namespace ResRef
{
    /// <summary>
    /// Interaction logic for SolidBrushResourceWindow.xaml
    /// </summary>
    public partial class SolidBrushResourceWindow : Window
    {
        public SolidBrushResourceWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_GotFocus(object sender, RoutedEventArgs e)
        {
            SolidColorBrush br = new();
            br.Color = Color.FromArgb(77, 77, 0, 0);
            this.Resources["brush"] = br;
        }

        private void Rectangle_LostFocus(object sender, RoutedEventArgs e)
        {
            SolidColorBrush br = new();
            br.Color = Color.FromArgb(77, 0, 77, 0);
            this.Resources["brush"] = br;

            this.Resources["e1"] = new Employee() { FirstName="Suraj", LastName="Dev", Id="Investor!" };
        }
    }
}
