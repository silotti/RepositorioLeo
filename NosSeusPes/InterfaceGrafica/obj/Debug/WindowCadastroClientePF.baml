   M S B A M L   `   `   `  ����K  GInterfaceGrafica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceGraficaInterfaceGrafica  5   	   .    (InterfaceGrafica.WindowCadastroClientePF   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InterfaceGrafica     5   	     � Title$  WindowCadastroClientePF��5   	   $	��550��6)   $	��600��66   .��5	      � $��20q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��25��6*   �� 5      $��162.4 �6   �� 5      $	��233 �6   .+�5   
   �� $��8��6   $��2��6   $��Center=�6-   $E��?http://emser.es/wp-content/uploads/2016/08/usuario-sin-foto.png��5       J� RenderTransformOrigin$ 1.044,0.498&�5      $��10,28,10,18q�64   $	��164��6I   �� 5    
   $��1��6   $��0��6   .��6-   
IdCliente:69   �� 5"   
   $��1��6   $��1��6    �� 
IsReadOnly . ��.  |�.   J� IsHitTestVisible .  ��6/   ��  �� Path$% ClientePFSelecionado.id_Cliente���5$   +   Z� �� 5&   
   $��2��6   $��0��6   .��6-   Nome:64   �� 5'   
   -   5        $
��box1��5'      $��2��6   $��1��6+   ��6;   �� $ ClientePFSelecionado.nome�5(      �� 5*   
   $��3��6   $��0��6   .��6-   Cliente é Revenda:6A   �� 5+   
   $��3��6   $��1��6     d� 	IsChecked 60   �� $" ClientePFSelecionado.revenda��� 5-   
   $��4��6   $��0��6   .��6-   CPF:63   �� 5.   
   $��4��6   $��1��6   ��6/   �� $ ClientePFSelecionado.CPF�6`   �� 50   
   $��5��6   $��0��6   .��6-   Data de Nascimento:6B   (  "System.Windows.Controls.DatePicker  51   
   $��5��6   $��1��6"      SelectedDate 62   �� $" ClientePFSelecionado.dt_Nasc�6o   �� 53   
   $��6��6   $��0��6   .��6-   EnderecoPF:6:   �� 54   
   $��6��6   $��1��6   ��6/   �� $% ClientePFSelecionado.enderecoPF�6g   �� 56   
   $��10,10,10,18q�6   	 �� Orientation$	 Vertical=�6*   $��8��6A   $��2��6N   .+�57      �� -   5        
 ��Name$
 BtnSelecionarFoto��57      .��6P   Selecionar Foto ou Logo6i   �� 58      $��5q�6   $��Uniform=�6   $	��100��61   ��6>   �� *ClientePFSelecionado.foto+59      &   System.Windows.Controls.DataGrid  5;   
   $��8��6   $��2��6       AutoGenerateColumns .  $��10,10,10,18q�5?   /   y�5<      �� $ VisibilidadeDataGrid���5=      �� $ 	BdCliente� �� SelectedItem 5>      �� $ ClientePFSelecionado�   Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
id_Cliente+6R     5C      $
 Nome��6%    63   �� *nome+6O     5D      $	 CPF��6%    62   �� *CPF+6M     5E      $ 
Nascimento��6%    69   �� *	dt_Nasc+6W     5F      $ 	Endereço��6%    67   �� *
enderecoPF+6X   5H      �� 5J   
   -   5        $
 OkButton��5L      $��9��5J      $��0��6   $	��100��6.   $��0,20,20,177q�6:   $��Right=�5K      .��5M   (   Salvar60   �� 5O   
   -   5        $
 CancelarButton��5Q      $��9��5O      $��1��6   $	��100��6.   $��20,20,0,177q�6:   $
��Left=�5P      .��5R   .   Sair64   5S      5T      