   M S B A M L   `   `   `  ????P  LWPFModernVerticalMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WPFModernVerticalMenu.ControlsWPFModernVerticalMenu.Controls  5   	   =#clr-namespace:WPFModernVerticalMenuWPFModernVerticalMenu  5   	   &     WPFModernVerticalMenu.MainWindow   5   	   5ctls,clr-namespace:WPFModernVerticalMenu.Controls  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WPFModernVerticalMenu     5   	   -   5        $
??home??5        ? Title$  
MainWindow??5	   	   $	??650??6   $
??1000??6)    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?6.   
??????  ? AllowsTransparency .  ? 
ResizeMode$ NoResize=?5   	   $??Poppins)?6   .??5      ??    PrimaryBackgroundColor#???   6    ?? CornerRadius$ 8??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $
??Auto ?6#   ?? 5      $??* ?6#   .+?5      ?? $??0??6     SecundaryBackgroundColor#???  5      $ 8 0 0 8??5      ._?5      ? -   5         ?Name$ GridNav??5      $??60??6(    ? RowDefinitions 5      ?? 5      $??60 ?6(   ?? 5      $??* ?6(   .+?5"      ? $??0??6   .+?5$      ?? $??Tic Tac Toe??6      PrimaryTextColor#???  5%       $
??Bold"?5&       $??16(?5'       $??Center=?5(       $
??Left=?5)       $??60 0 0 0q?5*       5+      ?? 5.      $??1??6!   $??
-1 40 0 20q?6.   .+?5/      ?? -   5        	 ??Name$	 btnHome??5/   !     PopupButtonStyle#???  62   .??50      -   'WPFModernVerticalMenu.Controls.MenuItem  -   'WPFModernVerticalMenu.Controls.MenuItem
   Loaded$
 MenuItem_Loaded??6?      	GroupName$ MenuItem??6,     PrimaryBlueColor   IndicatorBrush# ?  6A     home   Icon# ?  6u      	IconWidth$ 16??6?      Text$
 Home??6?   $??Center=?6?   6?   51      ?? 52      -   5        $	 
btnSetting??52   !   #???  65   .??53        $
 MenuItem_Loaded_1??6?   $ MenuItem??6,   # ?  6A     settings# ?  6u   $ 16??6?   $ Setting??6?   $??Center=?6?   6?   54      55      ? 59      -   5         ?Name$ Popup??59       ? AllowsTransparency .  ? HorizontalOffset$ 0??6G    ? VerticalOffset$ 10??6\   .??5:      .   (WPFModernVerticalMenu.Controls.UserPopup  -   5          Name$ Header??5:   )   #???  69   5;      5>      5?      ? 5A      $??1??6    5B      ?? 5C      $??60 ?6$   ?? 5D      $
??170* ?6$   ?? 5E      $
??421* ?6$   .+?5H      d? -   5         d?Name$ Tg_Btn??5H      $??Center=?6/     iToggleButtonStyle#???  6J   $
??Left=?6w   $??0q?6?   
?????? $??10,0,0,0q?6?   $??30??6?   $??30??6?    ? Triggers 5I      :? 5J       :? RoutedEvent$ ToggleButton.Unchecked??6'   .[?5K      ?? .??5L   "   ?? -   5         ??Name$ HideStackPanel??5L   -   .??5M   &   W?  ?? 
TargetName$ GridNav??66    ?? TargetProperty$ Width?6V    g? 	BeginTime$ 0:0:0X?6x    W? From$	 210X?6?   	 W? To$ 60X?6?    g? Duration$ 0:0:0.5D?6?   5N   '   5O   #   5P      5Q      :? 5R      $ ToggleButton.Checked??6'   .[?5S      ?? .??5T   "   ?? -	   5        $ ShowStackPanel??5T   -   .??5U   &   W? $ GridNav??66   $ Width?6V   $ 0:0:0X?6x   $ 60X?6?   $	 210X?6?   $ 0:0:0.5D?6?   5V   '   5W   #   5X      5Y      5[      ?? 5^      $??0??6   $??Right=?6*   $	??Top=?6F   $??0,5,10,0q?6^   $??30??6p    ?? Orientation$ 
Horizontal=?6|   $??RightToLeft=?6?   .+?5_      ?? -
   5        $	 btnClose??5_        IconButtonsStyle#??[ 6/    		 close#??? 	 6Y   
  ? Tag$  IsCloseButton??6?   ?? 5`      -   5        $	 
btnRestore??5`      $	??5,0q?61   ??5a      ?? 5b      ! ?? 
TargetType"! ??6$   " ?? BasedOn#" [ 6A   .?5c   "   ?? # ?? Property# ? ?? 
 maximize$ ?? Value#$ ? 
 6<   % ?? Triggers% 5d   "   ?? 5e   &   & ?? Binding& 62   ?? ' ?? ElementName$
' home??( ?? Path$( WindowState?) ?? Value) 	Maximized6i   .a?5f   *   ?? # ? ??  restore#$ ?  6D   5g   '   5i      5k      ?? 5l      -   5        $	 btnMinimize??5l      #???  62     minimize#???  6]   6?   5m       ? 5p      -   5        $??
fContainer??5q      $??1??5p      $??20,20,20,20q?5r      *  ? NavigationUIVisibility$* Hidden=?5s      + J? RenderTransformOrigin$+ 0.473,0.495&?68   $??2??6\   5u      ?? 5v      -   5        , ??Name$, 	LabelHide??5v      $??Tic Tac Toe??6+   #???  5w       $	??100(?5x       $	??Top=?5y       $??Center=?5z       $??	0,154,0,0q?5{       $??1??63   $	??141??6@   $	??520??6M   $??2??6Y   $
??Bold"?6j   5|      5}      5~      5      