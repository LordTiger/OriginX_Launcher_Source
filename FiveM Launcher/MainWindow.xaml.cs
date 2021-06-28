
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;


namespace FiveM_Launcher
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Rules_Btn_Checked(object sender, RoutedEventArgs e)
        {
            Process.Start("https://drive.google.com/file/d/1Ww0mISXKxqK6XCB63BgweF_7bw6nawDu/view?usp=sharing");
        }

        private void Exit_Btn_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
