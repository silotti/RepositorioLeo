   M S B A M L   `   `   `  ����K  GInterfaceGrafica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceGraficaInterfaceGrafica  5   	   +    %InterfaceGrafica.WindowCadastroModelo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InterfaceGrafica     5   	     � Title$  WindowCadastroModelo��5   	   $	��550��6&   $	��600��63   .��5	      � $��20q�6    � ColumnDefinitions 5
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
   $��1��6   $��0��6   .��6-   	IdModelo:68   �� 5!   
   $��1��6   $��1��6    �� 
IsReadOnly . ��.  |�.   J� IsHitTestVisible .  ��6/   ��  �� Path$! ModeloSelecionado.id_Modelo���5#   +   Z� �� 5%   
   $��2��6   $��0��6   .��6-   Nome:64   �� 5&   
   -   5        $
��box1��5&      $��2��6   $��1��6+   ��6;   �� $ ModeloSelecionado.nome�6j   �� 5(   
   $��3��6   $��0��6   .��6-   	Cadarço:67   �� 5)   
   $��3��6   $��1��6     d� 	IsChecked 60   �� $ ModeloSelecionado.cadarco��� 5+   
   $��4��6   $��0��6   .��6-   	Material:68   �� 5,   
   $��4��6   $��1��6   ��6/   �� $  ModeloSelecionado.material�6b   �� 5.   
   $��5��6   $��0��6   .��6-   Cor:63   �� 5/   
   $��5��6   $��1��6   ��6/   �� $ ModeloSelecionado.cor�6]   �� 51   
   $��6��6   $��0��6   .��6-   
Tamanho:67   �� 52   
   $��6��6   $��1��6   ��6/   �� $ ModeloSelecionado.tamanho�6a   �� 54   
   $��7��6   $��0��6   .��6-   	Preço:65   �� 55   
   $��7��6   $��1��6   ��6/   �� $ ModeloSelecionado.preco�6_   �� 57   
   $��10,10,10,18q�6    �� Orientation$ Vertical=�6*   $��8��6A   $��2��6N   .+�58      �� -   5        	 ��Name$	 BtnSelecionarFoto��58      .��6P   Selecionar Foto ou Logo6i   �� 59      $��5q�6   $��Uniform=�6   $	��100��61   ��6>   �� *ModeloSelecionado.foto+5:      &   System.Windows.Controls.DataGrid  5<   
   $��8��6   $��2��6    
   AutoGenerateColumns
 .  $��10,10,10,18q�5@   /   y�5=      �� $ VisibilidadeDataGrid���5>      �� $ BdModelo� �� SelectedItem 5?      �� $ ModeloSelecionado�   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	id_Modelo+6Q     5D      $
 Nome��6%    63   �� *nome+6O     5E      $ Cadarco��6%    66   �� *	cadarco+6U     5F      $ Material��6%    67   �� *
material+6V     5G      $	 Cor��6%    62   �� *cor+6L     5H      $ Tamanho��6%    66   �� *	tamanho+6T     5I      $ Preco��6%    64   �� *preco+6P   5K      �� 5M   
   -   5        $	 OkButton��5O      $��9��5M      $��0��6   $	��100��6.   $��0,20,20,177q�6:   $��Right=�5N      .��5P   (   Salvar60   �� 5R   
   -   5        $	 CancelarButton��5T      $��9��5R      $��1��6   $	��100��6.   $��20,20,0,177q�6:   $
��Left=�5S      .��5U   .   Sair64   5V      5W      