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
using System.Collections.ObjectModel;

namespace Zadanie_Shablon_dannih
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> productes;
        public MainWindow()
        {
            InitializeComponent();
            productes = new List<Product>();
            productes.Add(new Product()
            {
                Nazvanie = "сыр",
                Cena = 400,
                Izobragenie = "Data/cheese.png",
                Category = Categories.Eda,
            });
            productes.Add(new Product()
            {
                Nazvanie = "молоко",
                Cena = 80,
                Izobragenie = "Data/milk.jpg",
                Category = Categories.Eda,
            });
            productes.Add(new Product()
            {
                Nazvanie = "телефон",
                Cena = 7000,
                Izobragenie = "Data/phone.png",
                Category = Categories.Technika,
            });
            productes.Add(new Product()
            {
                Nazvanie = "телевизор",
                Cena = 15000,
                Izobragenie = "Data/televizor.jpg",
                Category = Categories.Technika,
            });
            lstBox.ItemsSource = productes;
            
        }

        
    }
}
