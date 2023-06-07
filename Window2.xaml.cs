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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace OtdelKadrov
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void BtnDelDoc_Click(object sender, RoutedEventArgs e)
        {
            var documentsForRemoving = documentsDataGrid.SelectedItems.Cast<document>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {documentsForRemoving.Count} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    OtdelEntities.GetContext().documents.RemoveRange(documentsForRemoving);
                    OtdelEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    documentsDataGrid.ItemsSource = OtdelEntities.GetContext().documents.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnAddDoc_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage2 c = new AddEditPage2();
            c.Show();
            Close();
        }


        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                OtdelEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                documentsDataGrid.ItemsSource = OtdelEntities.GetContext().documents.ToList();
            }
        }
    }
}
