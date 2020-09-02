using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using EToolService.Mobile.Services;
using EToolService.Model.Models;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace EToolService.Mobile.ViewModels
{
    public class ProductDetailModel : BaseViewModel
    {
        public ProductDetailModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina = Kolicina >= 1 ? Kolicina - 1 : Kolicina);
            NaruciCommand = new Command(async () => await AddToCart());
        }

        public async Task AddToCart()
        {
            OrderService.AddProduct(Proizvod, Kolicina);
            await Application.Current.MainPage.DisplayAlert("Info", "Artikal dodan u korpu", "OK");
        }

        public Product Proizvod { get; set; }

        int _kolicina = 1;
        public int Kolicina
        {
            get { return _kolicina; }
            set => SetProperty(ref _kolicina, value); 
        }

        decimal _cijena = 0;
        public decimal Cijena
        {
            get { return _cijena; }
            set => SetProperty(ref _cijena, value);
        }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand NaruciCommand { get; set; }
    }
}
