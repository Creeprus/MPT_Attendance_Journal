using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MPT_Attendance_Journal
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class Teacher : Window
    {
        public Teacher()
        {
            InitializeComponent();
        }
        public string Login = "";
        int id_teacher = -1;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();

            MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
            // Загрузить данные в таблицу attendance. Можно изменить этот код как требуется.
            MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter journalDBattendanceTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter();
           // journalDBattendanceTableAdapter.Fill(journalDB.attendance);
            System.Windows.Data.CollectionViewSource attendanceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("attendanceViewSource")));
            attendanceViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу lesson_mpt. Можно изменить этот код как требуется.
           
            MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
            id_teacher = Convert.ToInt32(journalDBuser_mptTableAdapter.SeekIDUser_Login(Login));
            journalDBlesson_mptTableAdapter.FillByTeacher(journalDB.lesson_mpt, id_teacher);
            System.Windows.Data.CollectionViewSource lesson_mptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lesson_mptViewSource")));
            lesson_mptViewSource.View.MoveCurrentToFirst();

     
          
        }

        private void lesson_mptDataGrid_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lesson_mptDataGrid_Copy.SelectedItem!=null)
            {
                MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
                DataRowView row = (DataRowView)lesson_mptDataGrid_Copy.SelectedItem;
                MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter journalDBattendanceTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter();
                 journalDBattendanceTableAdapter.FillByLesson(journalDB.attendance,Convert.ToInt32(row.Row.ItemArray[0]));

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
