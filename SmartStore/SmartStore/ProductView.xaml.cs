using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SmartStore.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        public ProductView()
        {
            InitializeComponent();
        }
    }
}