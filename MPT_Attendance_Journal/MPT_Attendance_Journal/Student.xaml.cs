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
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }
        public string Login = "";
        int id_student =-1;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
            // Загрузить данные в таблицу user_mpt. Можно изменить этот код как требуется.

            MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter journalDBstudentgroupTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.studentgroupTableAdapter();
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
            // journalDBuser_mptTableAdapter.Fill(journalDB.user_mpt);
             id_student = Convert.ToInt32(journalDBuser_mptTableAdapter.SeekIDUser_Login(Login));
            int group_id = Convert.ToInt32(journalDBstudentgroupTableAdapter.SeekGroupID(id_student));
            MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter journalDBlesson_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.lesson_mptTableAdapter();
            journalDBlesson_mptTableAdapter.FillLessonByGroup(journalDB.lesson_mpt,group_id);
            System.Windows.Data.CollectionViewSource lesson_mptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lesson_mptViewSource")));
            lesson_mptViewSource.View.MoveCurrentToFirst();

            MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter attendanceTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter();


        }

        private void Attend_Click(object sender, RoutedEventArgs e)
        {
            if (lesson_mptDataGrid.SelectedIndex != -1)
            {
                MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter attendanceTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.attendanceTableAdapter();


                DataRowView row = (DataRowView)lesson_mptDataGrid.SelectedItem;
                int lesson_order = Convert.ToInt32(row.Row.ItemArray[3]);
                TimeSpan time;
                if (lesson_order==1)
                {
                    time = TimeSpan.FromMinutes(600);
                    if (DateTime.Now.TimeOfDay>= TimeSpan.FromMinutes(510) && DateTime.Now.TimeOfDay<=time)
                    {
                        attendanceTableAdapter.InsertQueryAttendance("Да", Convert.ToInt32(row.Row.ItemArray[0]), id_student);
                        MessageBox.Show("Вы отметились на паре");
                    }
                    else
                    {
                        MessageBox.Show("Пара уже прошла. На ней отметиться нельзя");
                    }
                }
                if (lesson_order == 2)
                {
                    time = TimeSpan.FromMinutes(700);
                    if (DateTime.Now.TimeOfDay >= TimeSpan.FromMinutes(610) && DateTime.Now.TimeOfDay <= time)
                    {
                        attendanceTableAdapter.InsertQueryAttendance("Да", Convert.ToInt32(row.Row.ItemArray[0]), id_student);
                        MessageBox.Show("Вы отметились на паре");
                    }
                    else
                    {
                        MessageBox.Show("Пара уже прошла. На ней отметиться нельзя");
                    }
                }
                if (lesson_order == 3)
                {
                    time = TimeSpan.FromMinutes(810);
                    if (DateTime.Now.TimeOfDay >= TimeSpan.FromMinutes(720) && DateTime.Now.TimeOfDay <= time)
                    {
                        attendanceTableAdapter.InsertQueryAttendance("Да", Convert.ToInt32(row.Row.ItemArray[0]), id_student);
                        MessageBox.Show("Вы отметились на паре");
                    }
                    else
                    {
                        MessageBox.Show("Пара уже прошла. На ней отметиться нельзя");
                    }
                }
                if (lesson_order == 4)
                {
                    time = TimeSpan.FromMinutes(930);
                    if (DateTime.Now.TimeOfDay >= TimeSpan.FromMinutes(840) && DateTime.Now.TimeOfDay <= time)
                    {
                        attendanceTableAdapter.InsertQueryAttendance("Да", Convert.ToInt32(row.Row.ItemArray[0]), id_student);
                        MessageBox.Show("Вы отметилиь на паре");
                    }
                    else
                    {
                        MessageBox.Show("Пара уже прошла. На ней отметиться нельзя");
                    }
                }
                if (lesson_order == 5)
                {
                    time = TimeSpan.FromMinutes(1030);
                    if (DateTime.Now.TimeOfDay >= TimeSpan.FromMinutes(940) && DateTime.Now.TimeOfDay <= time)
                    {
                        attendanceTableAdapter.InsertQueryAttendance("Да", Convert.ToInt32(row.Row.ItemArray[0]), id_student);
                        MessageBox.Show("Вы отметилиь на паре");
                    }
                    else
                    {
                        MessageBox.Show("Пара уже прошла. На ней отметиться нельзя");
                    }
                }
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
