   M S B A M L   `   `   `  ����K  GInterfaceGrafica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceGraficaInterfaceGrafica  5   	   .    (InterfaceGrafica.WindowCadastroClientePJ   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InterfaceGrafica     5   	     � Title$  WindowCadastroClientePJ��5   	   $	��550��6)   $	��600��66   .��5	      � $��20q�6    � ColumnDefinitions 5
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
IdCliente:69   �� 5!   
   -   5        $��	tbFocusMe��5"   H   $��1��5!      $��1��6    �� 
IsReadOnly . ��.  |�.   J� IsHitTestVisible .  ��6/   ��  �� Path$% ClientePJSelecionado.id_Cliente���5#   +   Z� �� 5%   
   $��2��6   $��0��6   .��6-   Nome:64   �� 5&   
   -   5        $
��box1��5&      $��2��6   $��1��6+   ��6;   �� $ ClientePJSelecionado.nome�6m   �� 5(   
   $��3��6   $��0��6   .��6-   Cliente é Revenda:6A   �� 5)   
   $��3��6   $��1��6     d� 	IsChecked 60   �� $" ClientePJSelecionado.revenda��� 5+   
   $��4��6   $��0��6   .��6-   CNPJ:64   �� 5,   
   $��4��6   $��1��6   ��6/   �� $ ClientePJSelecionado.CNPJ�6a   �� 5.   
   $��5��6   $��0��6   .��6-   Razão Social:6<   �� 5/   
   $��5��6   $��1��6   ��6/   �� $  ClientePJSelecionado.razao�6b   �� 51      $��6��6   $��0��6   .��6.   EnderecoPJ:6;   �� 52   
   $��6��6   $��1��6   ��6/   �� $% ClientePJSelecionado.enderecoPJ�6g   �� 54   
   $��10,10,10,18q�6    �� Orientation$ Vertical=�6*   $��8��6A   $��2��6N   .+�55      �� -   5        	 ��Name$	 BtnSelecionarFoto��55      .��6P   Selecionar Foto ou Logo6i   �� 56      $��5q�6   $��Uniform=�6   $	��100��61   ��6>   �� *ClientePJSelecionado.foto+57      &   System.Windows.Controls.DataGrid  59   
   $��8��6   $��2��6    
   AutoGenerateColumns
 .  $��10,10,10,18q�5=   /   y�5:      �� $ VisibilidadeDataGrid���5;      �� $ 	BdCliente� �� SelectedItem 5<      �� $ ClientePJSelecionado�   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
id_Cliente+6R     5A      $
 Nome��6%    63   �� *nome+6O     5B      $
 CNPJ��6%    63   �� *CNPJ+6O     5C      $ Razao��6%    64   �� *razao+6P     5D      $ 	Endereço��6%    67   �� *
enderecoPJ+6X   5F      �� 5H   
   -   5        $	 OkButton��5J      $��9��5H      $��0��6   $	��100��6.   $��0,20,20,177q�6:   $��Right=�5I      .��5K   (   Salvar60   �� 5M   
   -   5        $	 CancelarButton��5O      $��9��5M      $��1��6   $	��100��6.   $��20,20,0,177q�6:   $
��Left=�5N      .��5P   .   Sair64   5Q      5R      