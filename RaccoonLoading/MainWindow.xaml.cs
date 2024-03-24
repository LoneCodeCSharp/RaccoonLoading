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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RaccoonLoading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.Duration = new Duration(TimeSpan.FromSeconds(10));

            RotateTransform rt = new RotateTransform();
            RotateTransform rt1 = new RotateTransform();
            RotateTransform rt2 = new RotateTransform();
            RotateTransform rt3 = new RotateTransform();
            leye.RenderTransformOrigin = new Point(0.75, 0.75);
            leye.RenderTransform = rt;
            reye.RenderTransformOrigin = new Point(0.75, 0.75);
            reye.RenderTransform = rt1;
            
            fish.RenderTransformOrigin = new Point(4.2, 4.2);
            fish.RenderTransform = rt1;

            el.RenderTransformOrigin = new Point(0.5, 0.5);
            el.RenderTransform = rt1;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
            rt1.BeginAnimation(RotateTransform.AngleProperty, da);
            rt2.BeginAnimation(RotateTransform.AngleProperty, da);
            rt3.BeginAnimation(RotateTransform.AngleProperty, da);

        }
    }
}
