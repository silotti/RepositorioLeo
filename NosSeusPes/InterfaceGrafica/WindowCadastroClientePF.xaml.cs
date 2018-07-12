using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        public ClientePF Cli_PF_Atual { get; set; } = new ClientePF(); //cria obj Cli_PF_Atual com a classe ClientePF   
        BancosSapataria ctx = new BancosSapataria(); //cria obj ctx para salvar no arquivo com os bancos de dados
        public IList<Cliente> BdCliente { get; set; } // cria list de clientes
        //        <DataGrid Grid.Row="4" Grid.ColumnSpan= "4" Margin= "20"
        //          x:Name= "ClientePFDataGridView"
        //          Visibility= "{Binding Path=VisibilidadeDataGrid}"
        //          ItemsSource= "{Binding Path=PessoasF}"
        //          SelectedItem= "{Binding Path=cli_PF_Atual}"
        //          SelectionChanged= "PessoaFDataGridView_SelectionChanged"
        //          AutoGenerateColumns= "True" >
        //</ DataGrid >



        #region "ConstrutorDaClasse"
        public WindowCadastroClientePF()
        {
            InitializeComponent();
            this.DataContext = this;
            this.BdCliente = ctx.BdCliente.ToList(); //salva banco como lista
        }

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
        //    get => Cli_PF_Atual; // lambda expression
        //    set
        //    {
        //        Cli_PF_Atual = value;
        //        this.NotifyPropertyChanged("ClientePF");
        //    }
        //}

        public Boolean ModoCriacao { get; set; } = false;
        #region "VisibilidadeDataGrid"
        public Visibility VisibilidadeDataGrid
        {
           get
           {
                if (ModoCriacao)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }
        #endregion

        //BancosSapataria ctx = new BancosSapataria(); //cria obj ctx para salvar no arquivo com os bancos de dados
        //public IList<ClientePF> BdCliente { get; set; }
        //public ClientePF Cliente { get; }

        #region "BotaoOk"
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //if (Visao)
            //{
            //    ctx.BdClientePF.Add(Cli_PF_Atual);
            //    ctx.SaveChanges();
            //}

            //else
            //{
            //if (Cli_PF_Atual != null
            //    && Cli_PF_Atual.id_Cliente > 0)
            //{

            //ClientePF Salvar = ctx.BdClientePF.Find(Cli_PF_Atual.id_Cliente);
            //Salvar.nome = Cli_PF_Atual.nome;
            //Salvar.CPF = Cli_PF_Atual.CPF;
            //Salvar.dt_Nasc = Cli_PF_Atual.dt_Nasc;
            //Salvar.enderecoPF = Cli_PF_Atual.enderecoPF;
            //ctx.Entry(Salvar).State =
            //    System.Data.Entity.EntityState.Modified;
            //ctx.SaveChanges();
            //}
            //}



            ctx.BdCliente.Add(Cli_PF_Atual); // adiciona atual ao banco de Cliente
            ctx.SaveChanges(); // salva atualizações do banco
            MessageBox.Show("Salvo com Sucesso"); //menssagem de salvo
            this.Close(); //fecha janelas
        }
        #endregion

        // private void ClientePF_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //     foreach (ClientePF item in e.RemovedItems)
        //     {
        //         ctx.BdClientePF.Remove(item);
        //     }
        // }


        // public String Reg { get; set; }

        #region "BotaoCancelar"
        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion


        #region "BotaoFotoOuLogo"
        //função de adicionar foto
        private void BtnSelecionarFoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Fotografia"; // Nome padrão
            dlg.Filter = "Imagens (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            Nullable<bool> result = dlg.ShowDialog();

            // Somente irá salvar se o usuário selecionar um arquivo.
            if (result == true)
            {
                var uri = new Uri(dlg.FileName);
                var imagemFile = File.Open(dlg.FileName, FileMode.Open);
                Cli_PF_Atual.foto = new byte[imagemFile.Length];
                imagemFile.Read(Cli_PF_Atual.foto,
                    0, (int)imagemFile.Length);
                NotifyPropertyChanged("Camisa");
            }
        }
        #endregion

    }
}
