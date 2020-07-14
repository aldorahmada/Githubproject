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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pnlMainGrid.MouseUp += new MouseButtonEventHandler(pnlMainGrid_MouseUp);
      
        }
        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs a)
        {
            MessageBox.Show("You clicked me at " + a.GetPosition(this).ToString());
        }

        private void pnlMainGrid_KeyUp(object sender, KeyEventArgs a)
        {
            txt1.Text = "sundul";
        }
        private void Button_Click(object sender, RoutedEventArgs a)
        {
            txt1.Text = "COK";
        }
        private void Application_Startup(object sender, StartupEventArgs a)
        {
            MainWindow wnd = new MainWindow();
            if (a.Args.Length == 1)
                MessageBox.Show("Now opening file: \n\n" + a.Args[0]);
            wnd.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs a)
        {
            txt1.Text = "saat waktunya sudah habis bilang";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs a)
        {
            txt1.Text = txtb1.Text;
        }
    }
}
