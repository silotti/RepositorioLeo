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
    public partial class WindowCadastroClientePJ : Window,
        INotifyPropertyChanged
    {
        private ClientePJ cli_PJ = new ClientePJ();
        public ClientePJ ClientePJAtual
        {
            get
            {
                return cli_PJ;
            }
            set
            {
                cli_PJ = value;
                this.NotifyPropertyChanged("ClientePJAtual");
            }
        }

        public Boolean Visao { get; set; } = false;
        public Visibility VisibilidadeDataGrid
        {
            get
            {
                if (Visao)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }

        private BancosSapataria ctx = new BancosSapataria();
        public IList<ClientePJ> BdClientePJ { get; set; }

        //public Cliente clienteParaSalvar { get; set; } = new Cliente();

        //public Boolean ModoCriacaoCliente { get; set; } = false;
        // public event PropertyChangedEventHandler PropertyChanged;
        public WindowCadastroClientePJ()
        {
            InitializeComponent();
            //this.clienteParaSalvar = new Cliente();
            this.DataContext = this;
            SalvaClientePJ crie = new SalvaClientePJ();
            this.BdClientePJ = crie.ObterClientePJ();
        }
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
            if (Visao)
            {
                ctx.BdClientePJ.Add(ClientePJAtual);
                ctx.SaveChanges();
            }
            else
            {
                if (ClientePJAtual != null
                    && ClientePJAtual.id_Cliente > 0)
                {
                    ClientePJ Salvar = ctx.BdClientePJ.Find(ClientePJAtual.id_Cliente);
                    //Salvar.nome = ClientePJAtual.nome;
                    Salvar.CNPJ = ClientePJAtual.CNPJ;
                    Salvar.razao = ClientePJAtual.razao;
                    Salvar.enderecoPJ = ClientePJAtual.enderecoPJ;
                    ctx.Entry(Salvar).State =
                        System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            MessageBox.Show("Salvo com Sucesso");
            ctx.BdClientePJ.Add(this.ClientePJAtual);
            //ctx.BdCliente.Add(clienteParaSalvar);
            ctx.SaveChanges();
            this.Close();
        }

        private void PessoaFDataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (ClientePJ item in e.RemovedItems)
            {
                ctx.BdClientePJ.Remove(item);
            }
        }
        //public String Reg { get; set; }


    }
}
