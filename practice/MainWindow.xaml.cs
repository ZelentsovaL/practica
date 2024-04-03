using practice.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Authbtn_Click(object sender, RoutedEventArgs e)
        {
            var user = new PractikaContext().Employees.Where(x => x.Firstname == Loginbox.Text && x.Lastname == Passwordbox.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверные данные");
                return;
            }

            var role = new PractikaContext().Positions.Where(x => x.Positionid == user.Positionid).FirstOrDefault();

            new MainPage(user, role).Show();
        }
    }
}