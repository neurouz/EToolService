using EToolService.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EToolService.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pocetak, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.MojaKorpa, Title="Moja korpa" },
                new HomeMenuItem {Id = MenuItemType.MojeNarudzbe, Title="Moje narudžbe" },
                new HomeMenuItem {Id = MenuItemType.MojiServisi, Title="Moji servisi" },
                new HomeMenuItem {Id = MenuItemType.NoviZahtjev, Title="Novi servis" },
                new HomeMenuItem {Id = MenuItemType.Proizvodi, Title="Proizvodi" },
                new HomeMenuItem {Id = MenuItemType.Postavke, Title="Postavke" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}