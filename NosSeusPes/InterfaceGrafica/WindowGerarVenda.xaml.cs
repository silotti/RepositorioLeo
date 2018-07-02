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
    /// Interaction logic for WindowGerarVenda.xaml
    /// </summary>
    public partial class WindowGerarVenda : Window,
        INotifyPropertyChanged
    {
        public WindowGerarVenda()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public Venda VendaParaSalvar { get; set; } = new Venda();
        BancosSapataria ctx = new BancosSapataria();
        public Boolean ModoCriacaoVenda { get; set; } = false;
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

            ctx.BdVenda.Add(VendaParaSalvar);
            ctx.SaveChanges();
            this.Close();
        }



    }
}
