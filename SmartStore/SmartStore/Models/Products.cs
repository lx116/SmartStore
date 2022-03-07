using System;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SmartStore.Models
{
    public class Product
    {
        public String Type { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public String Specs { get; set; }
        public ImageSource PrincipalImage { get; set; }
        public ImageSource SideImage { get; set; }
        public ImageSource FrontImage { get; set; }
        public ImageSource BackImage { get; set; }
        public String TrailerUrl { get; set; }
        public String Color { get; set; }
        public Color GradientColor1 { get; set; }
        public Color GradientColor2 { get; set; }
        public Page ProductView { get; set; }
    }
}