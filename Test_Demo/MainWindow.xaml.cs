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

namespace Test_Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TradeEntities _entities = new TradeEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string loginUser = LoginTxt.Text;
            string passUser = PassTxt.Text;

            User user = _entities.User.FirstOrDefault(u => u.UserLogin==loginUser && u.UserPassword==passUser);
            if (user != null)
            {
                if(user.UserRole == 3)
                {
                    ListProductAuthUser listProduct = new ListProductAuthUser();
                    this.Close();
                    listProduct.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }
    }
}
