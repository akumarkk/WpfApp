using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MSApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBoxCodeBeh_RatingChanged(object sender, CustomControls.RatingChangesEventArg e)
    {
        TextBlock block = new();
        block.Text = $"Your rating update from {e.OldVal} to {e.NewVal}";
        block.Background = Brushes.Cornsilk;
        block.Foreground = Brushes.DarkOrange;
        // can't add block to Content!

        Debug.WriteLine($"Your rating update from {e.OldVal} to {e.NewVal}");

    }
}