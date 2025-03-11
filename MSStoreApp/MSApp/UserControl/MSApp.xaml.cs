using System;
using System.Collections.Generic;
using System.IO;
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

namespace MSApp.UserControl
{
    /// <summary>
    /// Interaction logic for MSApp.xaml
    /// </summary>
    public partial class MSApp : System.Windows.Controls.UserControl
    {
        Random random = new();
        public MSApp()
        {
            InitializeComponent();
            var files = Directory.GetFiles(Environment.CurrentDirectory + @"/../../../Images");
            int rnd = random.Next(files.Length);
            var image = new BitmapImage(new Uri(files[rnd]));
            ProductImage.Source = image;

            AppNameText.Text = files[rnd].Split("//").Last().Split('-').Last().Split('.').First();


        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
