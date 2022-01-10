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

namespace Csigaverseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozito;
        DispatcherTimer idozito2;
        DispatcherTimer idozito3;
        int a = new int();
        int b = new int();
        int c = new int();
        
        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito2 = new DispatcherTimer();
            idozito3 = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.01);
            idozito2.Interval = TimeSpan.FromSeconds(0.01);
            idozito3.Interval = TimeSpan.FromSeconds(0.01);
            idozito.Tick += new EventHandler(csiga1Mozgasa);
            idozito2.Tick += new EventHandler(csiga2Mozgasa);
            idozito3.Tick += new EventHandler(csiga3Mozgasa);
        }
        private void csiga1Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 10);
            double a2 = csiga1.Margin.Left + a;
            csiga1.Margin = new Thickness(a2 +=a ,36, 0, 0);
        }
        private void csiga2Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int b = rnd.Next(0, 10);
            double b2 = csiga2.Margin.Left + b;
            csiga2.Margin = new Thickness(b2 += a, 164, 0, 0);
        }
        private void csiga3Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int c = rnd.Next(0, 10);
            double c2 = csiga3.Margin.Left + c;
            csiga3.Margin = new Thickness(c2 += c, 269, 0, 0);
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            idozito2.Start();
            idozito3.Start();

        }
    }
}
