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

namespace practice.Views
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var ctx = new PractikaContext();
            var user = new Employee
            {
                Employeeid = int.Parse(IDBox.Text),
                Lastname = LastName.Text,
                Firstname = FirstName.Text,
                Middlename = MiddleName.Text,
                Positionid = int.Parse(PositionBox.Text),
                Departmentid = int.Parse(DepartmentBox.Text),
                Contactinfo = InfoBox.Text,
            };

            ctx.Employees.Add(user);
            ctx.SaveChanges();
            ctx.Dispose();
            this.Close();
        }
    }
}
