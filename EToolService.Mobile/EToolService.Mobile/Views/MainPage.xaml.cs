using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EToolService.Mobile.Models;

namespace EToolService.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Pocetna, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Pocetak:
                        MenuPages.Add(id, new NavigationPage(new IndexPage()));
                        break;
                    case (int)MenuItemType.MojaKorpa:
                        MenuPages.Add(id, new NavigationPage(new MyCartPage()));
                        break;
                    case (int)MenuItemType.MojeNarudzbe:
                        MenuPages.Add(id, new NavigationPage(new OrdersPage()));
                        break;
                    case (int)MenuItemType.MojiServisi:
                        MenuPages.Add(id, new NavigationPage(new MyServicesPage()));
                        break;
                    case (int)MenuItemType.NoviZahtjev:
                        MenuPages.Add(id, new NavigationPage(new RequestFormPage()));
                        break;
                    case (int)MenuItemType.Proizvodi:
                        MenuPages.Add(id, new NavigationPage(new ProductsPage()));
                        break;
                    case (int)MenuItemType.Postavke:
                        MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}