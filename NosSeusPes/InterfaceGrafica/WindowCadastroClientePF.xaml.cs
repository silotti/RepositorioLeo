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
    public partial class WindowCadastroClientePF : Window,
        INotifyPropertyChanged
    {
        private ClientePF cli_PF = new ClientePF();
        public ClientePF ClientePFAtual
        {
            get
            {
                return cli_PF;
            }
            set
            {
                cli_PF = value;
                this.NotifyPropertyChanged("ClientePFAtual");
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
        public IList<ClientePF> BdClientePF { get; set; }
        public WindowCadastroClientePF()
        {
            InitializeComponent();
            //this.clienteParaSalvar = new Cliente();
            this.DataContext = this;
            SalvaClientePF crie = new SalvaClientePF();
            this.BdClientePF = crie.ObterClientePF();
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
                ctx.BdClientePF.Add(ClientePFAtual);
                ctx.SaveChanges();
            }
            else
            {
                if (ClientePFAtual != null
                    && ClientePFAtual.id_Cliente > 0)
                {
                    ClientePF Salvar = ctx.BdClientePF.Find(ClientePFAtual.id_Cliente);
                    Salvar.nome = ClientePFAtual.nome;
                    Salvar.CPF = ClientePFAtual.CPF;
                    Salvar.data_Nasc = ClientePFAtual.data_Nasc;
                    Salvar.enderecoPF = ClientePFAtual.enderecoPF;
                    ctx.Entry(Salvar).State =
                        System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            
            //ctx.BdClientePF.Add(ClientePFAtual);
            //ctx.BdCliente.Add(clienteParaSalvar);
            ctx.SaveChanges();
            MessageBox.Show("Salvo com Sucesso");
            this.Close();
        }

        private void PessoaFDataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (ClientePF item in e.RemovedItems)
            {
                ctx.BdClientePF.Remove(item);
            }
        }
        //public String Reg { get; set; }


    }
}
