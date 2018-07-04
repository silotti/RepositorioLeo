using SapatariaBiblioteca;
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
            if (sender == MenuNovoCliente)
            {
                WindowCadastroCliente window = new WindowCadastroCliente();
                window.ShowDialog();
            }
            else if (sender == MenuNovoModelo)
            {
                WindowCadastroModelo window = new WindowCadastroModelo();
                window.ShowDialog();
            }
            else if (sender == MenuNovoEstoque)
            {
                WindowCadastroEstoque window = new WindowCadastroEstoque();
                window.ShowDialog();
            }
            else if (sender == MenuNovoPedido)
            {
                WindowCadastroPedido window = new WindowCadastroPedido();
                window.ShowDialog();
            }

            else if (sender == MenuGerarVenda)
            {
                //WindowGerarVenda window = new WindowGerarVenda();
                //window.ShowDialog();




                BancosSapataria ctx = new BancosSapataria();
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Relatorio"; // Nome padrão
                dlg.DefaultExt = ".xlsx"; // Extensão do arquivo
                dlg.Filter = "Excel (.xlsx)|*.xlsx"; // Filtros
                Nullable<bool> result = dlg.ShowDialog();

                // Somente irá salvar se o usuário selecionar um arquivo.
                if (result == true)
                {
                    // Salvar Documento
                    ServiceMakeXML.CriarPlanilhaPedidos(ctx.BdPedido.ToList(), dlg.FileName);
                }
            }
        }
    }
}
