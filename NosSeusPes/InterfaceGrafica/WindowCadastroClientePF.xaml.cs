﻿using SapatariaBiblioteca;
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
        //valor atual dos campos de preenchimento
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

        // cria IList de clientes para usar na tabela
        public IList<Cliente> BdCliente { get; set; } 

        #region "Construtor da Classe"
        public WindowCadastroClientePF()
        {
            InitializeComponent();
            this.DataContext = this;
            this.BdCliente = ctx.BdCliente.ToList(); //salva banco como lista de clientes
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
            //verifica se o cliente atual é 0 (criar)
            if (this.ClientePFSelecionado.id_Cliente <= 0)
            {
                //ctx.BdCliente.Add(this.ClientePFSelecionado);
                ctx.BdCliente.Add(this.ClientePFSelecionado); //adiciona atual ao banco de Cliente
                ctx.SaveChanges();
                MessageBox.Show("Cliente Novo Salvo com Sucesso"); //menssagem de salvo
                this.Close(); //fecha janelas       
                WindowCadastroClientePF window = new WindowCadastroClientePF();//abre novamente zerada
                window.ShowDialog(); //mostra janela
            }

            //verifica se caso o id_Cliente não seja 0 (alterar)
            else
            {
                ctx.SaveChanges();
                MessageBox.Show("Alteração Salva com Sucesso"); //menssagem de salvo
            }
        }
        #endregion

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
