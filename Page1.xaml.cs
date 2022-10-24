using Microsoft.Win32;
using System.Windows.Controls;
using CefSharp;
using System.Diagnostics;
using DocumentFormat.OpenXml.Drawing;

namespace IWT_
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MyFrame.Content = new Page2();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            string fn = "/RED.pdf";//путь к файлу
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fn;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}