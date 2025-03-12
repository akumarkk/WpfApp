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

namespace ContControls.UserControls
{
    /// <summary>
    /// Interaction logic for ScrollBarUC.xaml
    /// </summary>
    public partial class ScrollBarUC : UserControl
    {
        public ScrollBarUC()
        {
            InitializeComponent();
        }

        private void ScrollBar_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            textBoxScroll.Text = "You have scrolled " + e.NewValue.ToString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slBar.Text = "You have Slided " + e.NewValue.ToString();
            slBar.Background = Brushes.Teal;

        }
    }
}
