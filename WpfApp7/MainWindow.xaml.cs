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

        private void btnForSignin_Click(object sender, RoutedEventArgs e)
        {
            Signup(txtForName.Text, txtForLogin.Text, txtForPassword.Text);
        }

        private void btnForLogin_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        public bool Signup(string name, string log, string pass)
        {
            baseeEntities2 baseeEntities2 = new baseeEntities2();
            baseeEntities2.mainn.Add(new mainn()
            {
                name = name,
                login = log,
                password = pass
            });
            baseeEntities2.SaveChanges();
            MessageBox.Show("Успешно создался аккаунт");
            return true;
        }
    }
}
