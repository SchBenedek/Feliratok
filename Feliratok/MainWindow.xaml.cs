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

namespace Feliratok
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
        Feladatok f1 = new Feladatok();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(f1.Beolvas())
            {
                MessageBox.Show("Jó");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sorokSzama.Content = f1.lista.Count;
            leghosszabb.Content = f1.szavakSzama();
        }
    }
}
