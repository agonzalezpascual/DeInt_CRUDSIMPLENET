   M S B A M L   `   `   `  ����H  DCrudSimpleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CrudSimpleWPFCrudSimpleWPF  5   	       CrudSimpleWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CrudSimpleWPF     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� 
���<��$	��111��6&   $	��Top=�63   .+�5      �� -   5         ��Name$ textoBuscar��5       �� Left$	 338��6+    �� TextWrapping$
 Wrap=�6=   
 �� Top$ 44��6Q   $	��124��6a   $��23��6m   �� 5      -   5         ��Name$ botonBuscar��5      $��Buscar��6*   $	 508��6;   $ 46��6M   $��63��6w   5      �� 5   
   $
��Left=�6   $��	28,45,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $	��276��6n   $
��Bold"�6z   $��16(�6�   
���������6�   Z� �� 6�   $
�C#: ��6�   �� 6�    � Language$ es-es�6�   $ �MySQL/MariaDB : SMART CRUD��6�   6  �� 5   
   $
��Left=�6   $��
52,141,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ es-es�6t   $�Nombre��6�   6�   �� 5   
   $
��Left=�6   $��
52,174,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ es-es�6t   $�	Apellidos��6�   6�   �� 5   
   $
��Left=�6   $��
52,217,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $ es-es�6t   $�Género��6�   6�   �� 5   
   -   5        $ textoNom��5      $
��Left=�6$   $��166,141,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   6�   �� 5   
   -   5        $ textoApe��5      $
��Left=�6$   $��166,174,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5         ��Name$ comboGenero��5      $
��Left=�6(   $��166,211,0,0q�6C   $	��Top=�6X   $	��120��6p   .@�5      �� $��Hombre��6   �� 5      $��Mujer��6   �� 5      $
��Otro��6    �� 
IsSelected$
 True��6*   5      �� 5   
   -   5        $ botonInsertar��5      $��INSERTAR��6(   $
��Left=�6;   $��355,133,0,0q�6V   $	��Top=�6k   $	��100��6�   $	��107��6�   6�   �� 5   
   -   5        $ botonActualizar��5      $��
ACTUALIZAR��6*   $
��Left=�6?   $��504,131,0,0q�6Z   $	��Top=�6o   $	��102��6�   $	��107��6�   6�   �� 5   
   -   5        $ botonBorrar��5      $��BORRAR��6&   $
��Left=�67   $��658,129,0,0q�6R   $	��Top=�6g   $	��104��6   $	��107��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        	  Name$	 tabla��5      $��
0,264,0,99q�6M   6�   �� 5   
   $��Número de filas
��6   $
��Left=�64   $��	0,481,0,0q�6O   $	��Top=�6b   �� 5   
   -
   5        
 ��Name$
 filas��5      $��
��6   $
��Left=�64   $��
99,481,0,0q�6O   $	��Top=�6c   5      5       