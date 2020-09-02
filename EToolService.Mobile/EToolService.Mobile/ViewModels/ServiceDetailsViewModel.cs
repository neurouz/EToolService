using EToolService.Mobile.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Mobile.ViewModels
{
    public class ServiceDetailsViewModel
    {
        public EToolService.Model.Models.Services Service { get; set; }
        public CustomServiceConverter ServiceConverted { get; set; }
        public ServiceDetailsViewModel()
        {
        }
    }
}