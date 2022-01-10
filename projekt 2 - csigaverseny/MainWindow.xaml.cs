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
using System.Windows.Threading;

namespace projekt_2___csigaverseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer ido;
        int szam = new int();
        public MainWindow()
        {
            InitializeComponent();

            ido = new DispatcherTimer();
            ido.Interval = TimeSpan.FromSeconds(0.1);
            ido.Tick += new EventHandler(mitCs);
            ido.Tick += new EventHandler(mCs);
            ido.Tick += new EventHandler(miCs);

        }

        private void mCs(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ++szam;
            csigusz2.Margin = new Thickness(szam * 10, 190, 0, 0);
        }

        private void miCs(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ++szam;
            csigusz3.Margin = new Thickness(szam * 10, 90, 0, 0);
        }

        private void mitCs(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ++szam;
            csigusz1.Margin = new Thickness(szam * 10, 70, 0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ido.Start();
        }

        
    }
}
