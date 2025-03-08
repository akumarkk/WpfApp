using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace MSApp.CustomControls
{
    public class TextBoxCodeBeh: System.Windows.Controls.UserControl
    {
        TextBlock _label;
        private TextBox _textBox;
        private StackPanel _panel;

        TextBox text = new TextBox()
        {
            Text = "Hello from Yash!"
        };

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

            _panel.Children.Add(_label);
            _panel.Children.Add(_textBox);
            _textBox.Text = "Hello from masterpiece!";

            base.Content = _panel; // Use base.Content to set the content of the UserControl.

            
        }
        
        


    }
}
