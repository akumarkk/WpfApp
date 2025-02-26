using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PersInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> PersInfo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PersInfo = new();
            PersInfo.Add(new Person() { Name = "Punith", Locality = "Bangalore", Org = "Cinema" });
            PersInfo.Add(new Person() { Name = "Yash", Locality = "Bangalore", Org = "Cinema" });
            this.DataContext= this;
        }
    }
}
