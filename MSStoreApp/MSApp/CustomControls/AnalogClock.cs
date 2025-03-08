using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MSApp.CustomControls
{
    public class AnalogClock : Control
    {
        public AnalogClock()
        {
            TextBlock text = new TextBlock();
            text.Text = "Hello, Welcome!";

            Debug.WriteLine($"{this.Name}");

            this.AddVisualChild(text);
        }

        static AnalogClock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnalogClock), new FrameworkPropertyMetadata(typeof(AnalogClock)));

        }
    }

}
