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

namespace Практика_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
            public List<Product> Products { get; set; }
        public object SelectedItem { get; private set; }

        public MainWindow()
            {
                InitializeComponent();
                Products = new List<Product>();
            ProductsDataGrid.ItemsSource = Products;
            }

            private void AddProductButton_Click(object sender, RoutedEventArgs e)
            {
                string productName = ProductNameTextBox.Text;
                string productPrice = ProductPriceTextBox.Text;
                string productQuantity = ProductQuantityTextBox.Text;

                Products.Add(new Product
                {
                    ProductName = productName,
                    ProductPrice = productPrice,
                    ProductQuantity = productQuantity,
                });

                ProductNameTextBox.Clear();
                ProductPriceTextBox.Clear();
                ProductQuantityTextBox.Clear();
            }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ProductsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e, object myComboBox)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;
            if (SelectedItem != null);
            {
                MessageBox.Show($"Вы выбрали {selectedItem.Content}");
                List<string> items = new List<string> { "Элемент 1", "Элемент 2", "Элемент 3" };
                myComboBox = (myComboBox, items);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }

        
    }

    public class Product
        {
            public string ProductName { get; set; }
            public string ProductPrice { get; set; }
            public string ProductQuantity { get; set; }
        }
    


