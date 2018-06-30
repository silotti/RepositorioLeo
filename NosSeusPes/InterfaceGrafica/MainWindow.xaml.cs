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

namespace InterfaceGrafica
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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == MenuModelo)
            {
                WindowCadastroModelo window = new WindowCadastroModelo();
                window.ShowDialog();
            }
            else if (sender == MenuNovoPedido)
            {
                WindowCadastroPedido window = new WindowCadastroPedido();
                window.ShowDialog();
            }
            else if (sender == MenuNovoCliente)
            {
                WindowCadastroCliente window = new WindowCadastroCliente();
                window.ShowDialog();
            }
            else if (sender == MenuGerarVenda)
            {
                WindowGerarVenda window = new WindowGerarVenda();
                window.ShowDialog();
            }
            //else if (sender == TipoCliente)
            //{
            //    WindowGerarVenda window = new WindowGerarVenda();
            //    window.ShowDialog();
            //}


        }


    }
}
