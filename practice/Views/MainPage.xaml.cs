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

namespace practice.Views
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {


        private Employee _user;
        private Position _role;
        private Employee _selectedEmployee;

        private void DownloadData() => TableData.ItemsSource = new PractikaContext().Employees.ToList();


        public MainPage(Employee user, Position role)
        {
            InitializeComponent();
            _user = user;
            _role = role;
            CurrentRole.Content = $"Роль: {role.Name}";
            DownloadData();
        }

        private void RemoveData_Click(object sender, RoutedEventArgs e)
        {
            var ctx = new PractikaContext();
            var item = TableData.SelectedItem as Employee;
            ctx.Employees.Remove(item);
            ctx.SaveChanges();
            DownloadData();
        }

        private void TableData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void UpdateTable_Click(object sender, RoutedEventArgs e)
        {
            DownloadData();
        }

        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            new UpdateEmployee(TableData.SelectedItem as Employee).Show();
        }
    }
}
