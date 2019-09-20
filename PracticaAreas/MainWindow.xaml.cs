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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RecCalcular_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(RecBase.Text);
            int numero2 = int.Parse(RecAltu.Text);
            int area = numero1 * numero2;
            RecArea.Text = area.ToString();


        }

        private void TriCalcular_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(TriBase.Text);
            int numero2 = int.Parse(TriAltu.Text);
            int area = (numero1 * numero2)/2;
            TriArea.Text = area.ToString();
        }

        private void CirCalcular_Click(object sender, RoutedEventArgs e)
        {
            double radio = double.Parse(CirRadio.Text);
            double area = (radio * radio) * Math.PI;
            CirArea.Text = area.ToString();
        }

        private void TraCalcular_Click(object sender, RoutedEventArgs e)
        {
            int numero1 = int.Parse(TraBaseM.Text);
            int numero2 = int.Parse(TraBasem.Text);
            int numero3 = int.Parse(TraAlca.Text);
            int area = ((numero1 * numero2) / 2)* numero3;
            TraArea.Text = area.ToString();
        }
    }
}
