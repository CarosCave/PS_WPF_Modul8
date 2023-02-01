using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PS_WPF_Modul8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class MyStackPanel : StackPanel
    {
        public static readonly DependencyProperty IsBlueProperty = DependencyProperty.Register(
            "IsBlue", typeof(bool), typeof(MyStackPanel), 
            new FrameworkPropertyMetadata(false,new PropertyChangedCallback(IsBluePropertyChanged)));

        public bool IsBlue
        {
            get { return (bool)GetValue(IsBlueProperty); }
            set{ SetValue(IsBlueProperty, value); }   
        }

        static void IsBluePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            MyStackPanel stackpanel = sender as MyStackPanel;

            if (stackpanel.IsBlue == true)
            {
                stackpanel.Background = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                stackpanel.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}