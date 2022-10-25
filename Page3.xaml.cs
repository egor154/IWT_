using System.Windows.Controls;
using System.Diagnostics;
using Microsoft.Win32;

namespace IWT_
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string file = "C:\\Users\\belob\\source\\repos\\IWT_\\IWT.pdf";//путь к файлу
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = file;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            string file = "C:\\Users\\belob\\source\\repos\\IWT_\\RED.pdf";//путь к файлу
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = file;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
