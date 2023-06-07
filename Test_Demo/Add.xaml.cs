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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        private TradeEntities entities1;
        private Window1 parent1;

        public Add(TradeEntities entities, Window1 window1)
        {
            InitializeComponent();
            this.entities1 = entities;
            this.parent1 = window1; 
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            //entities1.Product.Add(
            //    )
        }
    }
}
