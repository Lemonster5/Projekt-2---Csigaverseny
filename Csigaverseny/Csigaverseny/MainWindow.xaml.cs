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
        int helyezes = 1;
        List<Brush> helyezesek = new List<Brush>();
        
        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito2 = new DispatcherTimer();
            idozito3 = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.015);
            idozito2.Interval = TimeSpan.FromSeconds(0.015);
            idozito3.Interval = TimeSpan.FromSeconds(0.015);
            idozito.Tick += new EventHandler(csiga1Mozgasa);
            idozito2.Tick += new EventHandler(csiga2Mozgasa);
            idozito3.Tick += new EventHandler(csiga3Mozgasa);
            helyezesek.Add(Brushes.Yellow);
            helyezesek.Add(Brushes.Gray);
            helyezesek.Add(Brushes.Brown);
            ujFutamGomb.IsEnabled = false;

        }
        private void csiga1Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 10);
            double a2 = csiga1.Margin.Left + a;
            if (csiga1.Margin.Left >= 845 )
            {
                csiga1.Margin = new Thickness(845, 36, 0, 0);
                idozito.Stop();
                elsoHelyezes.Content = helyezes++;
                elsoSav.Fill = helyezesek [helyezes - 2];
            }
            else 
            csiga1.Margin = new Thickness(a2 +=a ,36, 0, 0);
            
        }
        private void csiga2Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int b = rnd.Next(0, 10);
            double b2 = csiga2.Margin.Left + b;
            if (csiga2.Margin.Left >= 845)
            {
                csiga2.Margin = new Thickness(845, 164, 0, 0);
                idozito2.Stop();
                masodikHelyezes.Content = helyezes++;
                masodikSav.Fill = helyezesek [helyezes - 2];
            }

            else
                csiga2.Margin = new Thickness(b2 += b, 164, 0, 0);
        }
        private void csiga3Mozgasa(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int c = rnd.Next(0, 10);
            double c2 = csiga3.Margin.Left + c; 
            if (csiga3.Margin.Left >= 845)
            {
                csiga3.Margin = new Thickness(845, 269, 0, 0);
                idozito3.Stop();

                harmadikHelyezes.Content = helyezes++;
                harmadikSav.Fill = helyezesek[helyezes -2];
                ujFutamGomb.IsEnabled = true;
                ujBajnoksagGomb.IsEnabled = true;
               
            }

            else
                csiga3.Margin = new Thickness(c2 += c, 269, 0, 0);
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            idozito2.Start();
            idozito3.Start();
            startGomb.IsEnabled = false;
            ujBajnoksagGomb.IsEnabled = false;
         
        }

        private void ujFutamGomb_Click(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(20, 36, 0, 0);
            csiga2.Margin = new Thickness(20, 164, 0, 0);
            csiga3.Margin = new Thickness(20, 269, 0, 0);
            idozito.Stop();
            idozito2.Stop();
            idozito3.Stop();
            startGomb.IsEnabled = true;
            ujFutamGomb.IsEnabled = false;
            elsoHelyezes.Content = " ";
            masodikHelyezes.Content = " ";
            harmadikHelyezes.Content = " ";
            elsoSav.Fill = Brushes.Green;
            masodikSav.Fill = Brushes.Green;
            harmadikSav.Fill = Brushes.Green;
            helyezes = 1;
        }

        private void ujBajnoksagGomb_Click(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(20, 36, 0, 0);
            csiga2.Margin = new Thickness(20, 164, 0, 0);
            csiga3.Margin = new Thickness(20, 269, 0, 0);
            idozito.Stop();
            idozito2.Stop();
            idozito3.Stop();
            startGomb.IsEnabled = true;
            ujFutamGomb.IsEnabled = false;
            elsoHelyezes.Content = " ";
            masodikHelyezes.Content = " ";
            harmadikHelyezes.Content = " ";

            elsoSav.Fill = Brushes.Green;
            masodikSav.Fill = Brushes.Green;
            harmadikSav.Fill = Brushes.Green;
            helyezes = 1;
            MessageBox.Show((string)allas.Content, "Bajnokság végeredmény:");

        }

    }
}
