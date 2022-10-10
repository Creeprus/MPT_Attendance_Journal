using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MPT_Attendance_Journal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         

        }
        public string hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
        private void Authorize_Click(object sender, RoutedEventArgs e)
        {
            MPT_Attendance_Journal.JournalDB journalDB = ((MPT_Attendance_Journal.JournalDB)(this.FindResource("journalDB")));
            MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter journalDBuser_mptTableAdapter = new MPT_Attendance_Journal.JournalDBTableAdapters.user_mptTableAdapter();
            string role=journalDBuser_mptTableAdapter.AuthorizeUser(Login.Text, hash(Password.Password));
      
            switch (role)
            {
                case "Администратор":
                    {
                        Admin window = new Admin();
                        window.Show();
                        this.Hide();
                        break;
                    }
                case "Студент":
                    {
                        Student window = new Student();
                        window.Login = Login.Text;
                        window.Show();
                       
                        this.Hide();
                        break;
                    }
                case "Преподаватель":
                    {
                        Teacher window = new Teacher();
                        window.Login = Login.Text;
                        window.Show();
                        this.Hide();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Неправильной ввод данных пароля или логина");
                        break;
                    }

            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
