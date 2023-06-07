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
using System.Windows.Shapes;

namespace OtdelKadrov
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage c = new AddEditPage((sender as Button).DataContext as employee);
            c.Show();
            Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage c = new AddEditPage(null);
            c.Show();
            Close();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                OtdelEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                employeesDataGrid.ItemsSource = OtdelEntities.GetContext().employees.ToList();
            }
        }

        private void BtnDoc_Click(object sender, RoutedEventArgs e)
        {
            Window2 c = new Window2();//вход на следующую страницу приложения
            c.Show();
            Close();
        }
    }
}
