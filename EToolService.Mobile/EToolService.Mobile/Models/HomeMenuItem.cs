using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Mobile.Models
{
    public enum MenuItemType
    {
        Pocetna,
        MojaKorpa,
        Proizvodi,
        MojeNarudzbe,
        NoviZahtjev,
        MojiServisi,
        Pocetak,
        Postavke
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
