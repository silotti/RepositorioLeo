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
        #region "ConstrutorDaClasse"
        public WindowCadastroClientePF()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public ClientePF cli_PF_Atual { get; set; } = new ClientePF(); //cria obj cli_PF_Atual com a classe ClientePF   
        BancosSapataria ctx = new BancosSapataria(); //cria obj ctx para salvar no arquivo com os bancos de dados
        #endregion

        #region "NotifyPropertyChanged"
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string Property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
        }
        #endregion

        //public Cliente ClientePF
        //{
        //    get => cli_PF_Atual;
        //    set
        //    {
        //        cli_PF_Atual = value;
        //        this.NotifyPropertyChanged("ClientePF");
        //    }
        //}
        //public Boolean Visao { get; set; } = false;
        //public Visibility VisibilidadeDataGrid
        //{
        //   get
        //    {
        //        if (Visao)
        //        {
        //            return Visibility.Hidden;
        //        }
        //        else
        //        {
        //            return Visibility.Visible;
        //        }
        //    }
        //}

        //public IList<ClientePF> BdClientePF { get; set; }
        //public ClientePF Cliente { get; }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //if (Visao)
            //{
            //    ctx.BdClientePF.Add(ClientePFAtual);
            //    ctx.SaveChanges();
            //}
            //else
            //{
                //if (ClientePFAtual != null
                //    && ClientePFAtual.id_Cliente > 0)
                //{
                //    ClientePF Salvar = ctx.BdClientePF.Find(ClientePFAtual.id_Cliente);
                //    Salvar.nome = ClientePFAtual.nome;
                //    Salvar.CPF = ClientePFAtual.CPF;
                //    Salvar.dt_Nasc = ClientePFAtual.dt_Nasc;
                //    Salvar.enderecoPF = ClientePFAtual.enderecoPF;
                //    ctx.Entry(Salvar).State =
                //        System.Data.Entity.EntityState.Modified;
                //    ctx.SaveChanges();
                //}
            //}          
            ctx.BdCliente.Add(cli_PF_Atual); // adiciona atual ao banco de Cliente
            ctx.SaveChanges(); // salva atualizações do banco
            MessageBox.Show("Salvo com Sucesso"); //menssagem de salvo
            this.Close(); //fecha janelas
        }

       // private void PessoaFDataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
       //{
       //     foreach (ClientePF item in e.RemovedItems)
       //     {
       //         ctx.BdClientePF.Remove(item);
       //     }
       // }
       // public String Reg { get; set; }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
