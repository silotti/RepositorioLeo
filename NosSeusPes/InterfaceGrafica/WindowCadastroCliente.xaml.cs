using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace InterfaceGrafica
{
    /// <summary>
    /// Interaction logic for WindowCadastroCliente.xaml
    /// </summary>
    public partial class WindowCadastroCliente : Window,
        INotifyPropertyChanged
    {
        public WindowCadastroCliente()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Cliente clienteParaSalvar { get; set; } = new Cliente();
        BancosSapataria ctx = new BancosSapataria();
        public Boolean ModoCriacaoCliente { get; set; } = false;
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string Property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
        }
    
        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ctx.BdCliente.Add(clienteParaSalvar);
            ctx.SaveChanges();
            this.Close();
        }
    }
}
