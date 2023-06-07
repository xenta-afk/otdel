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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Window
    {
        private employee _currentEmployee = new employee();

        public AddEditPage(employee selectedemployee)
        {
            InitializeComponent();
            if (selectedemployee != null)
                _currentEmployee = selectedemployee;

            DataContext = _currentEmployee;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentEmployee.ФИО))
                errors.AppendLine("Укажите ФИО сотрудника");
            if (string.IsNullOrWhiteSpace(_currentEmployee.Адрес))
                errors.AppendLine("Укажите адрес сотрудника");
            if (string.IsNullOrWhiteSpace(_currentEmployee.Номер_телефона))
                errors.AppendLine("Укажите номер телефона сотрудника");
            if (string.IsNullOrWhiteSpace(_currentEmployee.Должность))
                errors.AppendLine("Укажите должность сотрудника");
            if (_currentEmployee.Дата_рождения == null)
                errors.AppendLine("Укажите дату рождения сотрудника");
            if (string.IsNullOrWhiteSpace(_currentEmployee.Пол))
                errors.AppendLine("Укажите пол сотрудника");
            if (_currentEmployee.Дата_найма == null)
                errors.AppendLine("Укажите дату найма сотрудника");
            if (_currentEmployee.Заработная_плата < 1)
                errors.AppendLine("Укажите заработную плату сотрудника");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentEmployee.id == 0)
                OtdelEntities.GetContext().employees.Add(_currentEmployee);

            try
            {
                OtdelEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCanc_Click(object sender, RoutedEventArgs e)
        {
            Window1 c = new Window1();
            c.Show();
            Close();
        }
    }
}
