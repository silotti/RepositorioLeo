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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowCadastroClientePF : Window,
        INotifyPropertyChanged
    {
        BancosSapataria ctx = new BancosSapataria(); //cria obj ctx para salvar no arquivo com os bancos de dados
        private ClientePF Cli_PF_Atual = new ClientePF(); //cria obj Cli_PF_Atual com a classe ClientePF   

        #region "selecionar pela tabela"
        //selecionar pela tabela
        public ClientePF ClientePFSelecionado
        {
            get
            {
                return Cli_PF_Atual; // lambda expression
            }
            set
            {
                Cli_PF_Atual = value;
                this.NotifyPropertyChanged("ClientePFSelecionado");
            }
        }
        #endregion

        //cria a variavel ModoAlteracao da Tabela e já seta ela como false
        public Boolean ModoCriarNovo { get; set; } = false;

        #region "VisibilidadeDataGrid"
        //se foi selecionada a tabela coloca como ModoCrirNovo como True
        public Visibility VisibilidadeDataGrid
        {
           get
           {
                // se verdade
                if (ModoCriarNovo)
                {
                    return Visibility.Hidden;
                }
                // se falso
                else
                {
                    return Visibility.Visible;
                }
            }
        }
        #endregion

        // cria IList de clientes
        public IList<Cliente> BdCliente { get; set; } 

        #region "Construtor da Classe"
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
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
        }
        #endregion

        #region "Botao de Ok"
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //verifica se ModoCriarNovo é true (criar)
            if (this.ClientePFSelecionado.id_Cliente <= 0)
            {
                //ctx.BdCliente.Add(this.ClientePFSelecionado);
                ctx.BdCliente.Add(Cli_PF_Atual); // adiciona atual ao banco de Cliente
                ctx.SaveChanges();
                MessageBox.Show("Cliente Novo Salvo com Sucesso"); //menssagem de salvo
                this.Close(); //fecha janelas

                //abre novamente para limpar tudo
                WindowCadastroClientePF window = new WindowCadastroClientePF();
                window.ShowDialog();
            }

            //verifica se ModoCriarNovo é false (alterar)
            else
            {
                ctx.SaveChanges();
                MessageBox.Show("Alteração Salva com Sucesso"); //menssagem de salvo
                //Cliente Salvar = ctx.BdCliente.Find(Cli_PF_Atual.id_Cliente);
                //Salvar.nome = Cli_PF_Atual.nome;
                //Salvar.CPF = Cli_PF_Atual.CPF;
                //Salvar.dt_Nasc = Cli_PF_Atual.dt_Nasc;
                //Salvar.enderecoPF = Cli_PF_Atual.enderecoPF;
                //ctx.Entry(Salvar).State = System.Data.Entity.EntityState.Modified;
            }

            //salva atual
            //if (ModoCriacao)
            //{
            //    ctx.BdCliente.Add(Cli_PF_Atual); // adiciona atual ao banco de Cliente
            //    ctx.SaveChanges(); // salva atualizações do banco
            //}
            //else
            //{
            //    ctx.SaveChanges();
            //}
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

        #region "Botao de Cancelar"
        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Botao Foto ou Logo"
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
                imagemFile.Read(Cli_PF_Atual.foto, 0, (int)imagemFile.Length);
                NotifyPropertyChanged("Camisa");
            }
        }
        #endregion

    }
}
