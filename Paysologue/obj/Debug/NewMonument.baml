   M S B A M L   `   `   `  ����E  APaysologue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Paysologue
Paysologue  5   	       Paysologue.NewMonument   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *localclr-namespace:Paysologue     5   	     � Title$  Nouveau monument��5   	   $	��300��6"   $	��336��6/    � 	Resources 5      )   #Paysologue.ErrorsToMessageConverter 	  EToMC��%   &	          5   
   6)   5	      ��5      �� 5   
    �� ImageSource$ App/WindowBackground5.jpg��6   .��5      � .+�5   
   ]� .+�5      �� $	��Top=�6   $��Center=�6-    �� Padding$ 5,5,5,5q�6J   $��5,5,5,5q�6\   $
��Bold"�6m   $��	underline{�6   $��18(�6�   
�������Ajouter un nouveau monument6�   �� 5      $��Bottom=�6    �� Orientation$ 
Horizontal=�61   $��Center=�6J   .+�5      �� -   5        $��3,3,3,3q�5      $��5,5,5,5q�6+   .��6R   	Valider6[   �� 5      -   5        $��3,3,3,3q�5      $��5,5,5,5q�6+   .��6R   	Annuler6[   5      � 5      $	��Top=�6    � ColumnDefinitions 5      �� 5      $��80 �6'   �� 5       � RowDefinitions 5      �� 5      �� 5       �� 5!      .+�5%      �� $��Right=�6   $��5,15,5,5q�68   $��14(�6J   
�������Nom :6r   �� 5&      -   5        $	��Nom��5&   =   $��1��6   $��	5,10,15,5q�6*   .��6H   ��5'      �� 5(       �� Path$ NewMonu.Nom�6"    �� Mode$ OneWayToSource=�65   	 �� UpdateSourceTrigger$	 PropertyChanged=�6K   
 �� ValidationRules
 5)      '   !Paysologue.NotEmptyValidationRule  5*   "   5,      .��5-   $   5.      �� 5/      $��2q�6   
���  ��$
��Bold"�68   ��6J   ��  �� ElementName$	 Nom��$ (Validation.Errors)� �� 	Converter# [  �� 50      $��1��6   $��Right=�6)   $��5,5,5,5q�6E   $��14(�6V   
�������	Image :6�   �� 51      -   5        $��ParcourirMonu��51   �   $��1��6   $��1��6&   $��	Parcourir��66   $
��Left=�6J   $��5,0,5,0q�6�   $��5,5,5,5q�6�   52      ]� 53      $	��Top=�6   54      55      56      