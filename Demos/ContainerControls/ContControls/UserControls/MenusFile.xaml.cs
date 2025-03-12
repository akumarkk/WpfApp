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
    /// Interaction logic for MenusFile.xaml
    /// </summary>
    public partial class MenusFile : UserControl
    {
        public MenusFile()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            switch (mi.Header.ToString())
            {
                case "_Open":
                    MessageBox.Show("Open clicked");
                    break;

                case "_Save":
                    MessageBox.Show("Save clicked");
                    break;

                case "E_xit":
                    break;

                default:
                    break;
            }

        }
    }
}
