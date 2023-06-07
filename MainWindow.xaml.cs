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

namespace OtdelKadrov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Vhod_Click(object sender, RoutedEventArgs e)//вход на следующую страницу приложения
        {
            StringBuilder errors = new StringBuilder();
            using (var db = new UsersEntities())
            {
                var pass = db.Users.AsNoTracking().FirstOrDefault(u => u.login == usernameTextBox.Text && u.pass == passwordBox.Password);
                var login = db.Users.AsNoTracking().FirstOrDefault(u => u.login == usernameTextBox.Text);
                if (login == null)
                {
                    errors.AppendLine("Пользователь не найден");
                }

                if (pass == null)
                {
                    errors.AppendLine("Неверный пароль");
                }

                if (errors.Length > 0)
                    MessageBox.Show(errors.ToString());
                if (errors.Length == 0)
                {
                    if (pass.IsAdmin == true)
                    {
                        Window1 c = new Window1();//вход на следующую страницу приложения
                        c.Show();
                        Close();
                    }
                    else
                    {
                        Window3 c = new Window3();//вход на следующую страницу приложения
                        c.Show();
                        Close();
                    }
                }
            }
            
        }
    }
}
