   M S B A M L   `   `   `  ����K  GInterfaceGrafica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceGraficaInterfaceGrafica  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   +    %InterfaceGrafica.WindowCadastroPedido   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InterfaceGrafica     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  WindowCadastroPedido��5	   	   $	��380��6&   $	��600��63   .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   .��6   
IdCliente:6)   �� 5   
   $��1��6   $��1��6   ��6/   ��  �� Path$! pedidoParaSalvar.id_Cliente�6c   �� 5   
   $��2��6   .��6   	IdPedido:6(   �� 5    
   $��2��6   $��1��6   ��6/   �� $  pedidoParaSalvar.id_Pedido�6b   �� 5"   
   $��3��6   .��6   	IdModelo:6(   �� 5#   
   $��3��6   $��1��6   ��6/   �� $  pedidoParaSalvar.id_Modelo�6b   �� 5%   
   $��4��6   .��6   Quantidade:6*   �� 5&   
   $��4��6   $��1��6   ��6/   �� $! pedidoParaSalvar.quantidade�6c   �� 5(   
   $��5��6   .��6   Preco Total:6+   �� 5)   
   $��5��6   $��1��6   ��6/   �� $! pedidoParaSalvar.precoTotal�6c   �� 5,   
   -   5         ��Name$ OkButton��5-      $��7��5,      $��0��6   $	��100��6.   $��20q�6:   $��Right=�6F   .��5-   :   Ok6>   �� 5.   
   -   5        $ CancelarButton��5/      $��7��5.      $��1��6   $	��100��6.   $��20q�6:   $
��Left=�6F   .��5/   F   
Cancelar6P   53      54      