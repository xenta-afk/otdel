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
    /// Логика взаимодействия для AddEditPage2.xaml
    /// </summary>
    public partial class AddEditPage2 : Window
    {
        private document _currentDocument = new document();

        public AddEditPage2()
        {
            InitializeComponent();
            DataContext = _currentDocument;
        }

        private void BtnSaveDoc_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentDocument.Номер_документа < 1)
                errors.AppendLine("Укажите номер документа");
            if (_currentDocument.Дата_документа == null)
                errors.AppendLine("Укажите дату документа");
            if (string.IsNullOrWhiteSpace(_currentDocument.Тип_документа__приход__расход_))
                errors.AppendLine("Укажите тип документа");
            if (string.IsNullOrWhiteSpace(_currentDocument.Описание_документа))
                errors.AppendLine("Добавьте описание документа");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentDocument.id == 0)
                OtdelEntities.GetContext().documents.Add(_currentDocument);
            
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

        private void BtnCancDoc_Click(object sender, RoutedEventArgs e)
        {
            Window2 c = new Window2();
            c.Show();
            Close();
        }
    }
}
