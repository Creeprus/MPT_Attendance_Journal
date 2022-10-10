using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MPT_Attendance_Journal
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }
        MainWindow AdminWindow = new MainWindow();
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
            // Загрузить данные в таблицу user_mpt. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
            journalDBuser_mptTableAdapter.Fill(journalDB.user_mpt);
            System.Windows.Data.CollectionViewSource user_mptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("user_mptViewSource")));
            user_mptViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу group_mpt. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();
            journalDBgroup_mptTableAdapter.Fill(journalDB.group_mpt);
            System.Windows.Data.CollectionViewSource group_mptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("group_mptViewSource")));
            group_mptViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу lesson_mpt. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
            journalDBlesson_mptTableAdapter.FillLesson(journalDB.lesson_mpt);
            System.Windows.Data.CollectionViewSource lesson_mptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lesson_mptViewSource")));
            lesson_mptViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу user_mptteacher. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptteacherTableAdapter journalDBuser_mptteacherTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptteacherTableAdapter();
            journalDBuser_mptteacherTableAdapter.Fill(journalDB.user_mptteacher);
            System.Windows.Data.CollectionViewSource user_mptteacherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("user_mptteacherViewSource")));
            user_mptteacherViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу studentgroup. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter journalDBstudentgroupTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter();
            journalDBstudentgroupTableAdapter.Fill(journalDB.studentgroup);
            System.Windows.Data.CollectionViewSource studentgroupViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentgroupViewSource")));
            studentgroupViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу user_mptstudent. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter journalDBuser_mptstudentTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter();
            journalDBuser_mptstudentTableAdapter.Fill(journalDB.user_mptstudent);
            System.Windows.Data.CollectionViewSource user_mptstudentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("user_mptstudentViewSource")));
            user_mptstudentViewSource.View.MoveCurrentToFirst();
        }


        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            if (group_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();
                DataRowView row = (DataRowView)group_mptDataGrid.SelectedItem;
                if (row != null)
                {
                    journalDBgroup_mptTableAdapter.AddGroupQuery(row.Row.ItemArray[1].ToString());
                }
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));

                FillAll();

            }


            
        }

   

        private void DeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            if (group_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                DataRowView row = (DataRowView)group_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();
                journalDBgroup_mptTableAdapter.DeleteGroupQuery(Convert.ToInt32(row.Row.ItemArray[0]));
                FillAll();

            }
        }

        private void group_mptDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)  {   group_mptDataGrid.FrozenColumnCount = 0; }

        private void group_mptDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)   {  group_mptDataGrid.FrozenColumnCount = 0;}

        private void group_mptDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)        {            group_mptDataGrid.FrozenColumnCount = 0;        }

        private void UpdateGroup_Click(object sender, RoutedEventArgs e)
        {
            if (group_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                DataRowView row = (DataRowView)group_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();
                if(row!=null)
                journalDBgroup_mptTableAdapter.UpdateGroupQuery(row.Row.ItemArray[1].ToString(),Convert.ToInt32(row.Row.ItemArray[0]));
                FillAll();

            }
        }

        private void user_mptDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)        {user_mptDataGrid.FrozenColumnCount = 0; }


        private void user_mptDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)        { user_mptDataGrid.FrozenColumnCount = 0; }

        private void user_mptDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)        { user_mptDataGrid.FrozenColumnCount = 0; }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (user_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
                DataRowView row = (DataRowView)user_mptDataGrid.SelectedItem;
                if (row != null)
                {
                    journalDBuser_mptTableAdapter.InsertUserQuery(row.Row.ItemArray[1].ToString(), row.Row.ItemArray[2].ToString(), row.Row.ItemArray[3].ToString(), row.Row.ItemArray[4].ToString(), row.Row.ItemArray[5].ToString(), AdminWindow.hash(row.Row.ItemArray[6].ToString()));
                }
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));

                FillAll();
            }

        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (user_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                DataRowView row = (DataRowView)user_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
                journalDBuser_mptTableAdapter.DeleteUserQuery(Convert.ToInt32(row.Row.ItemArray[0]));
                FillAll();

            }
        }

        

        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            if (user_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                DataRowView row = (DataRowView)user_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
                if (row != null)
                    journalDBuser_mptTableAdapter.UpdateUserQuery(row.Row.ItemArray[1].ToString(), row.Row.ItemArray[2].ToString(), row.Row.ItemArray[3].ToString(), row.Row.ItemArray[4].ToString(), row.Row.ItemArray[5].ToString(), AdminWindow.hash(row.Row.ItemArray[6].ToString()),Convert.ToInt32(row.Row.ItemArray[0]));
                FillAll();

            }
        }
        public static T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            if (parent == null)
            {
                return null;
            }

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                T childType = child as T;

                if (childType == null)
                {
                    foundChild = FindChild<T>(child, childName);

                    if (foundChild != null) break;
                }
                else
                    if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;

                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        foundChild = (T)child;
                        break;
                    }
                    else
                    {
                        foundChild = FindChild<T>(child, childName);

                        if (foundChild != null)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }
        private DataGridColumnHeader FindColumnHeader(DependencyObject parent, DataGridColumn column)
        {
            if (parent == null)
                return null;

            DataGridColumnHeader foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                //
                if (child as DataGridColumnHeader == null)
                {
                    foundChild = FindColumnHeader(child, column);
                    //
                    if (foundChild != null)
                        break;
                }
                else
                {
                    if (column != null)
                    {
                        //FrameworkElement elem = child as FrameworkElement;
                        //
                        if ((child as DataGridColumnHeader).Column == column)
                        {
                            foundChild = child as DataGridColumnHeader;
                            break;
                        }
                        else
                        {
                            foundChild = FindColumnHeader(child, column);
                            //
                            if (foundChild != null)
                                break;
                        }
                    }
                    else
                    {
                        foundChild = (DataGridColumnHeader)child;
                        break;
                    }
                }
            }

            return foundChild;
        }
        private void AddLesson_Click(object sender, RoutedEventArgs e)
        {
            if (lesson_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();

                MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
                DataRowView row = (DataRowView)lesson_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();

                if (row != null)
                {


                   // MessageBox.Show(row.Row.ItemArray[1].ToString());

            //        foreach(DataGridColumn column in lesson_mptDataGrid.Columns)
            //{
            //            DataGridColumnHeader header = FindColumnHeader(lesson_mptDataGrid, column);
                       
            //            ComboBox combo = null;

            //            if (header != null)
            //            {
                           
            //                combo = FindChild<ComboBox>(header, "Жмыхов");
            //                if (combo != null)
            //                MessageBox.Show(combo.SelectedValuePath.ToString());
            //            }
            //        }
                   
                     journalDBlesson_mptTableAdapter.InsertLessonQuery(row.Row.ItemArray[1].ToString(), Convert.ToDateTime(row.Row.ItemArray[2]), Convert.ToInt32(row.Row.ItemArray[3]), Convert.ToInt32(journalDBuser_mptTableAdapter.SeekIDUser(row.Row.ItemArray[6].ToString())), Convert.ToInt32(journalDBgroup_mptTableAdapter.SeekIDGroup((row.Row.ItemArray[7]).ToString())));
                }

                FillAll();
            }
        }

        private void DeleteLesson_Click(object sender, RoutedEventArgs e)
        {
            if (lesson_mptDataGrid.SelectedIndex != -1)
            {
               MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
                DataRowView row = (DataRowView)lesson_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
            
                if (row != null)
                {
                    journalDBlesson_mptTableAdapter.DeleteLessonQuery( Convert.ToInt32(row.Row.ItemArray[0]));

                }

                FillAll();
            }
        }

        private void UpdateLesson_Click(object sender, RoutedEventArgs e)
        {
            if (lesson_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();

                MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
                DataRowView row = (DataRowView)lesson_mptDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();

                if (row != null) 
                {
                    journalDBlesson_mptTableAdapter.UpdateLessonQuery(row.Row.ItemArray[1].ToString(), Convert.ToDateTime(row.Row.ItemArray[2]), Convert.ToInt32(row.Row.ItemArray[3]), Convert.ToInt32(journalDBuser_mptTableAdapter.SeekIDUser(row.Row.ItemArray[6].ToString())), Convert.ToInt32(journalDBgroup_mptTableAdapter.SeekIDGroup((row.Row.ItemArray[7]).ToString())), Convert.ToInt32(row.Row.ItemArray[0]));
                   
                }

                FillAll();
            }
        }

  
        private void SaveStudent_Click(object sender, RoutedEventArgs e)
        {
            // try
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter journalDBuser_mptstudentTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter();

                MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter journalDBstudentgroupTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter();
                    DataRowView row = (DataRowView)studentgroupDataGrid.SelectedItem;
                if (row!=null)
                {
                    DataRowView vrow = (DataRowView)student_combobox.SelectedItem;
                    DataRow row1 = vrow.Row;
                    string current_item = row1[1].ToString() + " " + row1[2].ToString() + " " + row1[3].ToString();
                  if (row.Row.ItemArray[1].ToString()== current_item)
                    {
                        journalDBstudentgroupTableAdapter.UpdateStudentGroupQuery(Convert.ToInt32(student_combobox.SelectedValue), Convert.ToInt32(group_nameComboBox.SelectedValue), Convert.ToInt32(row.Row.ItemArray[0]));

                    }
                    else
                    {
                        journalDBstudentgroupTableAdapter.InsertStudentGroupQuery(Convert.ToInt32(student_combobox.SelectedValue), Convert.ToInt32(group_nameComboBox.SelectedValue));

                    }
                }
              FillAll();
            }
           // catch
            {

            }
        }
        private void FillAll()
        {
            MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
         
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
            journalDBuser_mptTableAdapter.Fill(journalDB.user_mpt);
            MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter journalDBgroup_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.group_mptTableAdapter();
            journalDBgroup_mptTableAdapter.Fill(journalDB.group_mpt);
            MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
            journalDBlesson_mptTableAdapter.FillLesson(journalDB.lesson_mpt);
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptteacherTableAdapter journalDBuser_mptteacherTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptteacherTableAdapter();
            journalDBuser_mptteacherTableAdapter.Fill(journalDB.user_mptteacher);
           MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter journalDBstudentgroupTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter();
            journalDBstudentgroupTableAdapter.Fill(journalDB.studentgroup);
          MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter journalDBuser_mptstudentTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptstudentTableAdapter();
            journalDBuser_mptstudentTableAdapter.Fill(journalDB.user_mptstudent);
           
        }

        private void DeleteStudentFromGroup_Click(object sender, RoutedEventArgs e)
        {
            if (studentgroupDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter journalDBstudentgroupTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter();
                DataRowView row = (DataRowView)studentgroupDataGrid.SelectedItem;
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));

                if (row != null)
                {
                    journalDBstudentgroupTableAdapter.DeleteStudentGroupQuery(Convert.ToInt32(row.Row.ItemArray[0]));

                }

                FillAll();
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
