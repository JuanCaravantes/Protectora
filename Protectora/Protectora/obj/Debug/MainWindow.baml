   M S B A M L   `   `   `  ����E  AProtectora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Protectora
Protectora  5   	       Protectora.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Protectora     5   	   -   5          �Name$  loginWindow��5   	    � Title$ Login��5   	   $
��1920��6   $
��1080��6$    � WindowStartupLocation$ CenterScreen=�62   $��Verdana)�5	   	    � Icon$ Iconos/usuario.png��6    � WindowState$ 	Maximized=�68    � 
ResizeMode$ NoResize=�6P   ��5      �� 5   
    �� ImageSource$ /Imágenes/fondo.jpg��6    j� Stretch$ UniformToFill=�5      .��5      �  � RowDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��130* �6   �� 5      $	��61* �6   �� 5      $	��48* �6   �� 5      $	��61* �6   �� 5      $
��115* �6   �� 5      $
��566* �6   	 � ColumnDefinitions	 5   
   �� 5      $	��800 �6   �� 5      $��220.8 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��110* �6   �� 5!      $
��159* �6   .+�5%   
   �� $��1��6   $��5��6!   $��1��62   $��4��6B   
�������$��4��5&   #   ���	#FF5D1212
 �� RadiusX$
 10��6I    �� RadiusY$ 10��6V   �� 5(   
   $��Iniciar Sesión��6   $��Center=�6)   $��Center=�6F   $��70��5)      $	��340��6   
�������$��48(�6;   $��Verdana)�6I   $��1��5*      $��1��6    $��2��6-   �� 5,   
   $��Usuario��6   $��Right=�6"   $��Center=�6>   $��1��5-      $��36��6    $��86��6,   $��2��67   
�������$��20(�5.      �� 50   
   $��Contraseña��6   $��Right=�6%   $��Center=�6A   $��1��51      $��36��6    $	��124��6,   $��4��68   
�������$��20(�52      �� 54   
   -   5         ��Name$ lblRecordarContrasena��54      $��3��55      $��1��6   $��¿Olvidó su contraseña?��6-   $��Italic$�56      ���	#FFC4C6E0 � Cursor$
 Hand��6:   $��13(�57      $��3��6   $��Right=�62   $��Bottom=�6N    � ToolTip$= 7Pulse para restablecer su contraseña (no implementado)��58      5:      �� 5<   
   -   5         ��Name$ txtUser��5<      $��2��6#   $��2��63   $��5q�6@   $��28(�6K   $��2��5=      $ Introduzca su usuario��6@   .��6`   ��5?      �� 5@       �� 
TargetType" ��6    �� Triggers 5A      P� 5B       P� Property �@J�	IsFocused P� Value . . �5C      ��  �� Property � �� �� Value$ 2q�6@   �� 5D       � ��
 �����6;   5E      5G      .��5H      5I      G� 5K   
   -   5         G�Name$ txtPass��5K      $��2��6'   $��4��67   $��5q�6D   $��28(�6O    G� PasswordChar$ *��5L      $��2��6'   $ Introduzca su contraseña��6U   ��5M      �� 5N      " G�6    5O      P� 5P       �@J�	IsFocused . . �5Q      ��  � ��$ 2q�6@   �� 5R       � ��
 �����6;   5S      5U      5W      �� 5Y   
   -   5         ��Name$ btnLogin��5Y      $��Iniciar Sesión��6#   $��2��6<   $��5��6L   $	��180��5Z      $��50��6   $��20(�6)   $
��Bold"�67   
���   �$��5,0,15,0q�5[      $  Pulse para iniciar sesión��6#   $
 Hand��6G   $��Center=�5\   &   $
��Left=�6A    J� Effect 5^      3  -System.Windows.Media.Effects.DropShadowEffect  5_      5a      �� 5c   
   -   5         ��Name$ stpAdvertencia��5c       �� Orientation$ 
Horizontal=�6-   $��3��6F   $	��100��6V   $��5��6c   $��Center=�5d      $	��239��60   $y�Hidden=�6<   .+�5f      �� -   5         ��Name$ imgAdvertencia��5f      $��50��6,   $��50��67   $
��Left=�6C   $
��0,25q�6^   $��/Iconos/warning.png��5g      $��Bottom=�61   �� 5i      -   5        $ lblAdvertencia��5i      
�������$
��Bold"�5j      $��13(�6&   $��	0,10,0,25q�64   5l      5n      5o      