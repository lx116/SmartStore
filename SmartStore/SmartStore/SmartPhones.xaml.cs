using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmartPhones : ContentPage
    {
        public String GetProductName(String name)
        {
            return name;
        }
        
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products;}
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }
        public SmartPhones()
        {
            this.BindingContext = this;
            Products = new ObservableCollection<Product>()
            {
                new Product
                {
                    Type = "Smartphones",
                    Name = "Galaxy S22",
                    Price = 899,
                    Specs = "",
                    Color = "#F3DFDA",
                    GradientColor1 = Color.FromHex("#CAE6D9"),
                    GradientColor2 = Color.FromHex("#263F3C"),
                    PrincipalImage = "https://i.ibb.co/FmDLyDS/2223-w320h320.png",
                    ProductView = new ProductView()
                },
                new Product
                {
                    Type = "Smartphones",
                    Name = "Mi 11",
                    Price = 699,
                    Specs = "",
                    Color = "#FFC19C",
                    GradientColor1 = Color.FromHex("#EBBCB1"),
                    GradientColor2 = Color.FromHex("#FFC19C"),
                    PrincipalImage = "https://i.ibb.co/jkpXhWD/D-NQ-NP-821915-MLA46167880402-052021-O-removebg-preview-1.png"
                },
                new Product
                {
                    Type = "Smartphones",
                    Name = "Iphone 13 Pro",
                    Price = 1099,
                    Specs = "",
                    Color = "#F6F6EF",
                    GradientColor1 = Color.FromHex("#F6F6EF"),
                    GradientColor2 = Color.FromHex("#DADBD6"),
                    PrincipalImage = "https://i.ibb.co/FmDLyDS/2223-w320h320.png"
                },
                new Product
                {
                    Type = "Smartphones",
                    Name = "OnePlus 8",
                    Price = 899,
                    Specs = "",
                    Color = "#F3DFDA",
                    GradientColor1 = Color.FromHex("#90D1C5"),
                    GradientColor2 = Color.FromHex("#E8F4F7"),
                    PrincipalImage = "https://i.ibb.co/q73d0qG/1-m00-12-6e-rb8lb16b41aaj-0taahj-1oeuxg723.png"
                },

            };
            InitializeComponent();
            
        }

        private void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushAsync(new ProductView());
        }
    }
}