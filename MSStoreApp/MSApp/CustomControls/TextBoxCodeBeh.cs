using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace MSApp.CustomControls
{
    public class TextBoxCodeBeh: System.Windows.Controls.UserControl
    {
        TextBlock _label, starBox;
        private TextBox _textBox;
        private StackPanel _panel;
        

        TextBox text = new TextBox()
        {
            Text = "Hello from Yash!"
        };

        // Dependency Property for Rating
        public int Rating
        {
            get { return (int)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }

        public static readonly DependencyProperty RatingProperty =
            DependencyProperty.Register("Rating", typeof(int), typeof(TextBoxCodeBeh),
                new PropertyMetadata(0, OnStarCountChanged));

        public TextBoxCodeBeh()
        {
            
            //Content = text;
            _panel = new StackPanel();
            _panel.Orientation = Orientation.Vertical;
            _panel.Background = Brushes.Azure;

            _label = new TextBlock();
            _label.Text = "Yash App:";
            //_label.FontWeight. = new System.Windows.FontWeight() { };
            _textBox = new TextBox();

            starBox = new TextBlock();
            starBox.Text = "Your start rating value = " + Rating;

            TextBox box = new TextBox();
            _panel.Children.Add(_label);
            _panel.Children.Add(_textBox);
            _panel.Children.Add(box);
            _panel.Children.Add(starBox);
            _textBox.Text = "Hello from masterpiece!";

            
            box.TextChanged += MyTextBox_TextChanged;

            base.Content = _panel; // Use base.Content to set the content of the UserControl.
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            System.Diagnostics.Debug.WriteLine($"Text Changed: {textBox.Text}");
            starBox.Text = "Your start rating value = " + textBox.Text;
            starBox.Foreground = Brushes.Aqua;
            starBox.Background = Brushes.LightCoral;

        }

        private static void OnStarCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (TextBoxCodeBeh)d;
            int newValue = (int)e.NewValue;
            int oldValue = (int)e.OldValue;
            control.UpdateRatingVisual(newValue);

        }

        private void UpdateRatingVisual(int value)
        {

            starBox.Text = "Your start rating value = " + value;
            starBox.Background = Brushes.Bisque;
        }

    }
}
