using System;
using System.Collections.Generic;
using System.Text;

namespace EToolService.Mobile.Converters
{
    public class CustomServiceConverter
    {
        public CustomServiceConverter(EToolService.Model.Models.Services service)
        {
            _service = service;
        }
        private EToolService.Model.Models.Services _service;
        private const string ERR_MSG = "Zahtjev još uvijek nije odobren";

        public int Id { get; set; }
        public string ToolName { get; set; }
        public string ServiceType { get; set; }
        public string Note { get; set; }
        public string Urgent { get; set; }
        public string Attachment { get; set; }
        public string DateCreated { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Approved { get; set; }
        public string Price { get; set; }
        public string Viewed { get; set; }
        public string FinishDate { get; set; }
        public string Explanation { get; set; }
        public string Quantity { get; set; }
        public string Responsed { get; set; }

        public CustomServiceConverter Convert()
        {
            Id = _service.Id;
            Approved = _service.Approved ? "Zahtjev je odobren" : "Zahtjev nije odobren";
            CustomerId = _service.CustomerId;
            CustomerName = _service.CustomerName;
            DateCreated = _service.DateCreated.ToString("dd/MM/yyyy");
            Explanation = _service.Explanation != null ? _service.Explanation : ERR_MSG;
            FinishDate = _service.FinishDate != null ? _service.FinishDate?.ToString("dd/MM/yyyy") : ERR_MSG;
            Note = _service.Note != null ? _service.Note : "Niste dodali detalje za servis";
            Price = _service.Price != 0 ? Math.Round(_service.Price, 2).ToString() + " KM" : "Nepoznato";
            Quantity = _service.Quantity != 0 ? _service.Quantity.ToString() : "Nepoznato";
            Responsed = (bool)_service.Responsed ? "Odgovoreno" : "Nije odgovoreno";
            ServiceType = _service.ServiceType;
            ToolName = _service.ToolName;
            Urgent = _service.Urgent ? "Hitno" : "";
            Viewed = (bool)_service.Viewed ? "Vaš zahtjev je pregledan od strane administratora" : "Zahtjev još uvijek nije pregledan";

            return this;
        }
    }
}
