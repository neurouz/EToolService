using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EToolService.Desktop.Services;
using EToolService.Model.Requests;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EToolService.Desktop.Forms.Report
{
    public partial class frmReport : Form
    {
        private readonly APIService _service = new APIService("Report");
        private const string _path = "..\\..\\Data\\Months.json";
        private string __path = Path.Combine(Directory.GetCurrentDirectory(),
            "Data", "Months.json");
        public frmReport()
        {
            InitializeComponent();
            HideAll();
            loader1.Visible = true;
            try
            {
                using (StreamReader reader = new StreamReader(__path))
                {
                    string json = reader.ReadToEnd();
                    List<KeyValuePair<int, string>> items = JsonConvert
                        .DeserializeObject<List<KeyValuePair<int, string>>>(json);

                    comboMjesec.DataSource = items;
                    comboMjesec.ValueMember = "key";
                    comboMjesec.DisplayMember = "value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska prilikom ucitavanja fajla: {ex.Message}", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setting default values for year and month to avoid exceptions
            comboMjesec.SelectedValue = DateTime.Now.Month;
        }

        private void HideAll()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = false;
            }
        }

        private void ShowAll()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Visible = true;
            }
        }

        private async void frmReport_Load(object sender, EventArgs e)
        {
            var years = await _service.GetWithUrl<List<int>>(null, "Years");
            comboGodina.DataSource = years;
            comboGodina.SelectedIndex = years.Count - 1;
            Reload();

            ShowAll();
            loader1.Visible = false;
        }

        private async Task<int> GetProductCount(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<int>(request, "ProductCount");
        }
        private async Task<EToolService.Model.Models.Product> GetMostSellingProduct(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<EToolService.Model.Models.Product>(request, "MostSelling");
        }
        private async Task<int> GetNumberOfServices(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<int>(request, "ServiceNumber");
        }
        private async Task<decimal> GetServiceEarnings(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<decimal>(request, "ServiceEarnings");
        }
        private async Task<decimal> GetProductionEarnings(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<decimal>(request, "ProductionEarnings");
        }
        private async Task<EToolService.Model.Models.Customer> GetTopCustomer(ReportSearchRequest request)
        {
            return await _service.GetWithUrl<EToolService.Model.Models.Customer>(request, "TopCustomer");
        }

        private async void Reload()
        {
            try
            {
                var month = int.Parse(comboMjesec.SelectedValue.ToString());
                var year = int.Parse(comboGodina.SelectedValue.ToString());

                var request = new ReportSearchRequest
                {
                    year = year,
                    month = month
                };

                var productCount = await GetProductCount(request);
                valBrojProdanih.Text = productCount.ToString();

                var mostSelling = await GetMostSellingProduct(request);

                if (mostSelling != null)
                {
                    valNajprodavaniji.Text = mostSelling.ProductName;
                    valNajprodavaniji.ForeColor = System.Drawing.Color.SeaGreen;
                }
                else
                {
                    valNajprodavaniji.Text = "Nema prodanih proizvoda";
                    valNajprodavaniji.ForeColor = System.Drawing.Color.DarkRed;
                }

                var months = (List<KeyValuePair<int, string>>) comboMjesec.DataSource;

                lblSubtitle.Text = "Izvještaj za mjesec " + months[comboMjesec.SelectedIndex].Value + " " + year.ToString() + ". godine";

                var numberOfServices = await GetNumberOfServices(request);
                valBrojServisa.Text = numberOfServices.ToString();

                var serviceEarnings = await GetServiceEarnings(request);
                valUkupnoServis.Text = serviceEarnings.ToString("N") + " KM";

                var productionEarnings = await GetProductionEarnings(request);
                valUkupnoProizvodnja.Text = productionEarnings.ToString("N") + " KM";

                var topCustomer = await GetTopCustomer(request);
                if (topCustomer != null)
                {
                    valNajboljiKupac.Text = topCustomer.CompanyName;
                    valNajboljiKupac.ForeColor = System.Drawing.Color.SeaGreen;
                }
                else
                {
                    valNajboljiKupac.Text = "Nema ostvarenih narudžbi";
                    valNajboljiKupac.ForeColor = System.Drawing.Color.DarkRed;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void comboGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void comboMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private async void btnPdf_Click(object sender, EventArgs e)
        {
            var months = (List<KeyValuePair<int, string>>)comboMjesec.DataSource;

            var year = int.Parse(comboGodina.SelectedValue.ToString());
            var month = months[comboMjesec.SelectedIndex].Value;

            var fileName = month.ToLower() + "_" + year.ToString() + ".pdf";
            var path = Path.Combine(Directory.GetCurrentDirectory(),
                "Data", "Reports", $"izvjestaj_{fileName}");

            // var path = "..\\..\\Data\\Reports\\izvjestaj_" + fileName;

            var mjesec = int.Parse(comboMjesec.SelectedValue.ToString());
            var godina = int.Parse(comboGodina.SelectedValue.ToString());

            var request = new ReportSearchRequest { year = godina, month = mjesec };

            var tableData = await _service.GetWithUrl<List<EToolService.Model.Models.Services>>(request, "GetServices");

            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Izvještaj za mjesec " + month + " " + year + ". godine")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            document.Add(new Paragraph(new Text("\n")));
            document.Add(new Paragraph("Ukupan broj servisiranih alata:   " + await GetNumberOfServices(request)));
            document.Add(new Paragraph("Mjesečna zarada na servisiranju: " + await GetServiceEarnings(request) + " KM"));
            document.Add(new Paragraph("Broj reparisanih alata:                 " + tableData.Where(x => x.ServiceType.Equals("Reparacija")).Count()));
            document.Add(new Paragraph("Broj naoštrenih alata:                  " + tableData.Where(x => x.ServiceType.Equals("Oštrenje")).Count()));
            document.Add(new Paragraph(new Text("\n")));

            float[] columnWidths = { 1, 5, 4, 3.5f, 5.5f, 2.3f, 4 };
            Table table = new Table(UnitValue.CreatePercentArray(columnWidths));
            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            
            Cell cell = new Cell(1, 7)
                .Add(new Paragraph("Prikaz servisiranih alata"))
                .SetFontSize(13)
                .SetFontColor(DeviceGray.BLACK)
                .SetBackgroundColor(DeviceGray.WHITE)
                .SetTextAlignment(TextAlignment.CENTER);

            table.AddHeaderCell(cell);

            Cell[] headerFooter = new Cell[]{
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("RB.")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Naziv alata")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Tip alata")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Datum kreiranja")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Kupac")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Potvrdjeno")),
                new Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(new DeviceGray(0.75f)).Add(new Paragraph("Cijena"))
            };

            foreach (Cell hfCell in headerFooter)
            {
                table.AddHeaderCell(hfCell);
            }

            int counter = 1;

            tableData = tableData.OrderBy(x => x.ServiceType).ToList();

            if(tableData != null)
            {
                foreach (var service in tableData)
                {
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(counter++.ToString())));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.ToolName)));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.ServiceType)));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.DateCreated.ToString("dd/MM/yyyy"))));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.CustomerName)));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.Approved ? "DA" : "NE")));
                    table.AddCell(new Cell().SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(service.Price.ToString("N") + " KM")));
                }
            }

            Cell sum = new Cell(1, 7)
                .Add(new Paragraph("Ukupno: " + tableData?.Where(x => x.Approved).Sum(x => x.Price).ToString("N") + " KM"))
                .SetFontSize(13)
                .SetFontColor(DeviceGray.BLACK)
                .SetBackgroundColor(DeviceGray.WHITE)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetBold();

            document.Add(table);
            document.Add(sum);

            document.Close();

            System.Diagnostics.Process.Start(path);
        }
    }
}