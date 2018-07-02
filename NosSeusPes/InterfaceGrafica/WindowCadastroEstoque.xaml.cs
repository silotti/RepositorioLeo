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
    /// Interaction logic for WindowCadastroEstoque.xaml
    /// </summary>
    public partial class WindowCadastroEstoque : Window,
        INotifyPropertyChanged
    {
        public WindowCadastroEstoque()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Estoque EstoqueParaSalvar { get; set; } = new Estoque();
        BancosSapataria ctx = new BancosSapataria();
        public Boolean ModoCriacaoEstoque { get; set; } = false;
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

            ctx.BdEstoque.Add(EstoqueParaSalvar);
            ctx.SaveChanges();
            this.Close();
        }



    }
}
