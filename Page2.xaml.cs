using System.Windows.Controls;

namespace IWT_
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MyFrame.Content = new Page3();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            string file = "C:\\Users\\belob\\source\\repos\\IWT_\\IWT.pdf";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = file;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            string file = "C:\\Users\\belob\\source\\repos\\IWT_\\RED.pdf";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = file;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
