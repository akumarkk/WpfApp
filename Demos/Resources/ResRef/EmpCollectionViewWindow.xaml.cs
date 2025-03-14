using ResRef.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CollectionViewWindow.xaml
    /// </summary>
    public partial class EmpCollectionViewWindow : Window
    {
        public EmpCollectionViewWindow()
        {
            InitializeComponent();
            this.empList.ItemsSource = new Employee().GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var empList = new Employee().GetEmployees();
            // view associated with the collection, not with the new obj!
            ICollectionView view = CollectionViewSource.GetDefaultView(this.empList.ItemsSource);
            switch(((Button)sender).Content.ToString())
            {
                case "Prev":
                    view.MoveCurrentToPrevious();
                    break;
                case "Next":
                    view.MoveCurrentToNext();
                    break;
                case "Get Current Item":
                    Employee em = (Employee)view.CurrentItem;
                    MessageBox.Show(em.ToString());
                    break;
            }
            if(view.IsCurrentAfterLast)
            {
                view.MoveCurrentToLast();
            }
            if(view.IsCurrentBeforeFirst)
            {
                view.MoveCurrentToFirst();
            }

        }
    }
}
