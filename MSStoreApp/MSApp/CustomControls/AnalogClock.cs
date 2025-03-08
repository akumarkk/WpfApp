using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MSApp.CustomControls
{
    public class AnalogClock : Control
    {
        private Line Hour;
        private Line Minute;
        private Line Second;
        DispatcherTimer timer;
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


        public override void OnApplyTemplate()
        {
            Hour = Template.FindName("PART_Hour", this) as Line;
            Minute = Template.FindName("PART_Minute", this) as Line;
            
            Second = Template.FindName("PART_Second", this) as Line;

            UpdateANgle();
            InitializeClock();

            base.OnApplyTemplate();
        }

        void InitializeClock()
        {
            // Set up a timer to update the clock every second
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateANgle(); // Initial update
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            UpdateANgle();
        }

        public void UpdateANgle()
        {
            Hour.RenderTransform = new RotateTransform((DateTime.Now.Hour/24.0)*360, 0.5, 0.5);
            Minute.RenderTransform = new RotateTransform((DateTime.Now.Minute / 60.0) * 360, 0.5, 0.5);
            Second.RenderTransform = new RotateTransform((DateTime.Now.Second / 60.0) * 360, 0.5, 0.5);

            Debug.WriteLine($"Hour = {((RotateTransform)Hour.RenderTransform).Angle} " +
                $"Minute = {((RotateTransform)Minute.RenderTransform).Angle} " +
                $"Second = {((RotateTransform)Second.RenderTransform).Angle}");
        }
    }

}
