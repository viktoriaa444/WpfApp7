using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
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

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = Singleton.DB.User.Where(user=>user.Login==login.Text && user.Password==password.Password).ToList();
            if (users.Count==1 ) 
            {
                Window1 window1 = new Window1();
                Hide();
                window1.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("НЕ ВЕРНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
            }
        }
    }
}
