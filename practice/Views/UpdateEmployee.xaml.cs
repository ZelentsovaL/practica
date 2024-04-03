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
    /// Логика взаимодействия для UpdateEmployee.xaml
    /// </summary>
    public partial class UpdateEmployee : Window
    {

        private Employee _selectedEmployee;

        public UpdateEmployee(Employee employee)
        {
            InitializeComponent();
            _selectedEmployee = employee;
            LastNameBox.Text = employee.Lastname;
            FirstNameBox.Text = employee.Firstname;
            MiddleNameBox.Text = employee.Middlename;
            PositionIdBox.Text = employee.Positionid.ToString();
            DepartmentIdBox.Text = employee.Departmentid.ToString();
            InfoBox.Text = employee.Contactinfo;
        }

        private void UpdEmployee_Click(object sender, RoutedEventArgs e)
        {
            var ctx = new PractikaContext();
            _selectedEmployee.Lastname = LastNameBox.Text;
            _selectedEmployee.Firstname = FirstNameBox.Text;
            _selectedEmployee.Middlename = MiddleNameBox.Text;
            _selectedEmployee.Positionid = int.Parse(PositionIdBox.Text);
            _selectedEmployee.Departmentid = int.Parse(DepartmentIdBox.Text);
            _selectedEmployee.Contactinfo = InfoBox.Text;
            ctx.Employees.Update(_selectedEmployee);
            ctx.SaveChanges();
        }
    }
}
