   M S B A M L   `   `   `  ����D  @Interface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Interface	Interface  5   	       Interface.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Interface     5   	   $	��450��5   	   $	��800��6     � WindowStartupLocation$  CenterScreen=�6"      ClientWindowStyle#��[  6G   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $	��400 �6   �� 5      .+�5   
   �� $��Авторизация��6   $��40(�6'   $��1��65   $��1��6E   $��Center=�6R   $��Center=�6o   $
��Bold"�6�   $��Times New Roman)�6�   �� 5   
   -   5         ��Name$ LoginTextBox��5   �   $��2��6   $��1��6   $��Center=�6/   $��Center=�6L   $
��Bold"�6g   $��Times New Roman)�6y   $	��300��6�   $��20(�6�   
�������6�   �� 5   
   -   5        $��TextBlockPlaceholder��5     $��2��6   $��1��6!   $
��Bold"�61   $��Times New Roman)�6C   $��20(�6`   $,��&Введите логин или email��6n   
���   � J� IsHitTestVisible .  $��Center=�6�   $��Center=�6�   $��0,0,0,0q�6�   6  �� 5   
   -   5        $ LoginTextBox1��5   �   $��3��6   $��1��6   $��Center=�6/   $��Center=�6L   $
��Bold"�6g   $��Times New Roman)�6y   $	��300��6�   $��20(�6�   
�������6�   �� 5   
   -   5        $��TextBlockPlaceholder1��5      $��3��6   $��1��6!   $
��Bold"�61   $��Times New Roman)�6C   $��20(�6`   $*��$Введите свой пароль��6n   
���   � .  $��Center=�6�   $��Center=�6�   $��0,0,0,0q�6�   6   �� 5   
   -   5        $"��Авторизоваться��5      $��1��6*   $��4��6:   $��Center=�6G   $��Center=�6d   $
��Bold"�6   $��Times New Roman)�6�   $	��300��6�   $��20(�6�   6�   �� 5   
   -   5        $��5��5      $��1��6!   $Q��KНе зарегистрированы? Зарегистрироваться��61   $��18(�6�    �� TextAlignment$ Center=�6�   $	��Top=�6�   $
��Bold"�6�   $��Times New Roman)�6�   �� 5   
   -   5        $$��Вход для мастера��5      $��1��6,   $��5��6<   $��18(�6I   $ Center=�6W   $��Center=�6n   $
��Bold"�6�   $��Times New Roman)�6�   6�   5      5       