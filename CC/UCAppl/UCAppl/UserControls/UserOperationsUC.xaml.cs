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

namespace UCAppl.UserControls
{
    /// <summary>
    /// Interaction logic for UserOperationsUC.xaml
    /// </summary>
    public partial class UserOperationsUC : UserControl
    {
        public bool PostLiked { get; set; }
        public UserOperationsUC()
        {
            InitializeComponent();
        }

        public void LikePost()
        {
            Heart.Source = new BitmapImage(
                new Uri(Environment.CurrentDirectory + @"..\..\Icons\like.png", UriKind.RelativeOrAbsolute)
                );
            PostLiked = true;
        }

        public void UnLikePost()
        {
            Heart.Source = new BitmapImage(
                new Uri(Environment.CurrentDirectory + @"..\..\Icons\nolike.png", UriKind.RelativeOrAbsolute)
                );
            PostLiked = false;
        }

        void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!PostLiked)
            {
                LikePost();
            } else
            {
                UnLikePost();
            }

        }
    }
}
