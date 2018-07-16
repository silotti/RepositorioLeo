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
    public partial class WindowCadastroModelo : Window,
        INotifyPropertyChanged
    {
        BancosSapataria ctx = new BancosSapataria(); //cria obj ctx para salvar no arquivo com os bancos de dados
        private Modelo Modelo_Atual = new Modelo(); //cria obj Modelo_Atual com a classe Modelo  

        #region "selecionar pela tabela"
        //valor atual dos campos de preenchimento
        public Modelo ModeloSelecionado
        {
            get
            {
                return Modelo_Atual; // lambda expression
            }
            set
            {
                Modelo_Atual = value;
                this.NotifyPropertyChanged("ModeloSelecionado");
            }
        }
        #endregion

        //cria a variavel ModoCriarNovo da Tabela e já seta ela como false
        public Boolean ModoCriarNovo { get; set; } = false;

        #region "VisibilidadeDataGrid"
        //se foi selecionada da tabela retorna os dados
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

        // cria IList de Modelos para usar na tabela
        public IList<Modelo> BdModelo { get; set; }

        #region "Construtor da Classe"
        public WindowCadastroModelo()
        {
            InitializeComponent();
            this.DataContext = this;
            this.BdModelo = ctx.BdModelo.ToList(); //salva banco como lista de Modelos
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
            //verifica se o Modelo atual é 0 (criar)
            if (this.ModeloSelecionado.id_Modelo <= 0)
            {
                //ctx.BdModelo.Add(this.ModeloPFSelecionado);
                ctx.BdModelo.Add(this.ModeloSelecionado); //adiciona atual ao banco de Modelo
                ctx.SaveChanges();
                MessageBox.Show("Modelo Novo Salvo com Sucesso"); //menssagem de salvo
                this.Close(); //fecha janelas       
                WindowCadastroModelo window = new WindowCadastroModelo();//abre novamente zerada
                window.ShowDialog(); //mostra janela
            }

            //verifica se caso o id_Modelo não seja 0 (alterar)
            else
            {
                ctx.SaveChanges();
                MessageBox.Show("Alteração Salva com Sucesso"); //menssagem de salvo
            }
        }
        #endregion

        // private void ModeloPF_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //     foreach (ModeloPF item in e.RemovedItems)
        //     {
        //         ctx.BdModeloPF.Remove(item);
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
                Modelo_Atual.foto = new byte[imagemFile.Length];
                imagemFile.Read(Modelo_Atual.foto, 0, (int)imagemFile.Length);
                NotifyPropertyChanged("Camisa");
            }
        }
        #endregion

    }
}
