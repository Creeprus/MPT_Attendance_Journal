   M S B A M L   `   `   `  ????Q  MMPT_Attendance_Journal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MPT_Attendance_JournalMPT_Attendance_Journal  5   	   $    MPT_Attendance_Journal.Student   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MPT_Attendance_Journal     5   	   -   5          ? Title$  Student??5   	   $
??1080??6   $
??1920??6'   $
??1600??64   $	??800??6D    ? WindowState$ 	Maximized=?6T    ? 	Resources 5	      &    MPT_Attendance_Journal.JournalDB   	journalDB  lesson_mptViewSource ?? Source ?? Source  attendanceViewSource??%?   &	        &	      7   &	 C     7     5
   
   6   ?? 5   
    6<   ?? *
lesson_mpt+8   ?? 5   
    6<   ?? *
attendance+8   5      .??5      ?  ? DataContext# [ 6   .+?5   
   ?? $
??Left=?6   $
??1049??6+   $	??Top=?69   $
??1912??6Q   $
??Fill=?6^   $??AdminBackGround.jpg??6m   $??2??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ lesson_mptDataGrid??5         AutoGenerateColumns .     EnableRowVirtualization . $??578,0,0,386q?6?   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=?6?   $	??526??6?   $??Bottom=?6   $
??Left=?6  $	??772??66  
 J? IsManipulationEnabled
 .    
IsReadOnly . ??6j   ?? # [    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        id_lesson_mptColumn??,  &System.Windows.Controls.DataGridColumn   Header$ id lesson mpt??5   d      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6{      
Visibility$ 	Collapsed=?6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   ?? *id_lesson_mpt+6?     5      -   5        disciplineColumn??$ Дисциплина??5   ^   $ SizeToHeader 6r    6?   ?? *
discipline+6r   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        date_of_lessonColumn??$# Дата проведения??5   G   $ SizeToHeader 6`      CellTemplate 5      ?? 5      .R?5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   ?? *date_of_lesson+ ?? Mode$ TwoWay=? ?? NotifyOnValidationError .  ?? ValidatesOnExceptions . 5      5        5      -   5        lesson_orderColumn??$ Пара по счёту??5   b   $ SizeToHeader 6y    6A   ?? *lesson_order+6y     5      $  Преподаватель??6)   -   5        teacher_Column??$	 300 5   X    5      ?? 5      .R?5      ??  ??Name$ id_user_mptComboBox??6)   $??1??6F   $
??Left=?6W   $
??Auto??6r   $??3q?6?   $??0??6?   $??Center=?6?   $	??100??6?   ??6?   ?? *surname_user+6?   5!      5$        5%      $ Группа??6)   -   5        group_Column??$	 100 5%   O   $ 	Collapsed=?6[    5&      ?? 5'      .R?5(      ??  ??Name$ id_group_mptComboBox??6:    ?? SelectedIndex$ -1??6'   $??1??6X   $
??Left=?6l   $
??Auto??6?    ?? SelectedValuePath$ id_group_mpt??6?   $??3q?6  $??0??6%  $??Center=?62  $	??120??6M   ?? DisplayMemberPath$ 
group_name??6Z   ?? Text 6?   ?? *
group_name+??6?   ?? *	group_mpt+# [  ??5)   "   ?? 5*   &   .R?5+   *   $? 5,   '   5/      52      55       ? ContextMenu 57      ?? 58      .@?59      ?? -	   5        $??Attend??59      $(??"Отметиться на паре??6+   6_   5:      5<      ?? 5=   
   -
   5         ??Name$ 
Login_Copy??5=      $??777,0,0,917q?6&    ?? TextWrapping$ NoWrap=?6;   $??Пары??6Q    J? Opacity$
 0.75Q?6]   $??0q?6m   
???????$??42(?6?     ?? TextAlignment$  Center=?6?   $
??Left=?6?   $	??408??6?   $??59??6?   $??Bottom=?6?     5>   
   -   5        $ attendanceDataGrid??5>       .   . $??720,1430,792,-581q?6?   $	 VisibleWhenSelected=?6?   $y?	Collapsed=?6?   ??6j   ?? # [  5?        5@      -   5        id_attendancetColumn??$ id attendancet??5@   f   $ SizeToHeader 6~    6C   ?? *id_attendancet+6~     5A      -   5        statusColumn??$ status??5A   V   $ SizeToHeader 6f    6;   ?? *status+6f     5B      -   5        lesson_idColumn??$ 	lesson id??5B   \   $ SizeToHeader 6o    6>   ?? *	lesson_id+6o     5C      -   5        user_idColumn??$ user id??5C   X   $ SizeToHeader 6i    6<   ?? *	user_id+6i   5E      ?? 5F   
   ! ?? CornerRadius$! 13??6   
???   ?$??3q?67   " ? UseLayoutRounding" . $??Bottom=?6d   $??81??6   $??1630,0,0,938q?6?   ???	#FF96DFE8$
??Left=?6?   $	??228??6?   ._?5G      ?? -   5        $??LogOut??5G      $
??Left=?6#   $??81??6>   $??	7,-3,0,-3q?6J   $??
Выйти??6]   $	??Top=?6n   $	??208??6?   $
 0.75Q?6?   $??0q?6?   
?????? $??42(?6?   6?   5H      5J      5K      