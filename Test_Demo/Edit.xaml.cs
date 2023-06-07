using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public string path;
        private TradeEntities entities;
        private Product _product;
        private Window1 window11;

        public Edit(TradeEntities entities, object sender, Window1 window1)
        {
            InitializeComponent();
            this.entities = entities;
            _product = (sender as Button).DataContext as Product;
            this.window11 = window1;

            TxtCat.ItemsSource = entities.CategoryProduct.ToList();

            TxtArticul.Text = _product.ProductArticleNumber;
            TxtName.Text = _product.ProductName;
            TxtDescr.Text = _product.ProductDescription;
            TxtPhoto.Text = Convert.ToString(_product.ProductPhoto);
            TxtManuf.Text = _product.ProductManufacturer;
            TxtCost.Text = Convert.ToString(_product.ProductCost);
            TxtDiscaunt.Text = Convert.ToString(_product.ProductDiscountAmount);
            TxtStok.Text = Convert.ToString(_product.ProductQuantityInStock);
            TxtStatus.Text = _product.ProductStatus;
            TxtUnit.Text = _product.ProductUnit;
            TxtMax.Text = Convert.ToString(_product.ProductMaxDiscoun);
            TxtProvider.Text = _product.ProductProvider;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            _product.ProductArticleNumber = TxtArticul.Text;
            _product.ProductName = TxtName.Text;
            _product.ProductUnit = TxtUnit.Text;
            _product.ProductCost = Convert.ToDecimal(TxtCost.Text);
            _product.ProductMaxDiscoun = (byte)Math.Round(Convert.ToDecimal(TxtMax.Text));
            _product.ProductManufacturer = TxtManuf.Text;
            _product.ProductProvider = TxtProvider.Text;
            //_product.ProductCategory = Convert.ToInt32(TxtCat.Text);
            _product.ProductDiscountAmount = (byte)Math.Round(Convert.ToDecimal(TxtDiscaunt.Text));
            _product.ProductQuantityInStock = Convert.ToInt32(TxtStok.Text);
            _product.ProductDescription = TxtDescr.Text;

            window11.RefreshProduct();
            entities.SaveChanges();
            this.Close();
        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
         "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
         "Portable Network Graphic (*.png)|*.png";
            openFileDialog1.DefaultExt = ".jpeg";

            path = openFileDialog1.FileName;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить товар?", "", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                entities.Product.Remove(_product);
                entities.SaveChanges();
                window11.RefreshProduct();
                this.Close();
            }
           
        }
    }
}
