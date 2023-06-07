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

namespace Test_Demo
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static TradeEntities _entities = new TradeEntities();

        public Window1()
        {
            InitializeComponent();

            Grid.ItemsSource = _entities.Product.ToList();
            RefreshProduct();
        }

        public void RefreshProduct()
        {
            Grid.ItemsSource = _entities.Product.OrderBy(t => t.ProductName).ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit(_entities, sender, this);
            edit.ShowDialog();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add ass = new Add(_entities,this);
            ass.ShowDialog();
        }
    }
}